using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System.Diagnostics;


namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        string URI;
        CloudBlockBlob blockBlob_upload;
        CloudBlobContainer bakupcontainer;
        public string filenamelist;



        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet1.DataExchange_Comment' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataExchange_CommentTableAdapter.Fill(this.aZUREDBDataSet1.DataExchange_Comment);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Ship_Master_TB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.ship_Master_TBTableAdapter.Fill(this.aZUREDBDataSet.Ship_Master_TB);
            // TODO: このコード行はデータを 'aZUREDBDataSet.DataExchange' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataExchangeTableAdapter.Fill(this.aZUREDBDataSet.DataExchange);
            // TODO: このコード行はデータを 'aZUREDBDataSet1.DataExchange_Comment' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataExchange_CommentTableAdapter.Fill(this.aZUREDBDataSet1.DataExchange_Comment);
            // TODO: このコード行はデータを 'aZUREDBDataSet.DataExchange_fee' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataExchange_feeTableAdapter.Fill(this.aZUREDBDataSet.DataExchange_fee);
            // TODO: このコード行はデータを 'aZUREDBDataSet1.DataExchange_Comment' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataExchange_CommentTableAdapter.Fill(this.aZUREDBDataSet1.DataExchange_Comment);


            CloudStorageAccount storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=temmblobadmin;AccountKey=+7YLZ8+YK6td1m55K0AopQBpA/Pp+0z4iBMPind6HI87jhxF9DBe+wb11BbOyZhg+DWCqtitg/iWGexBWDaUdA==");

            ////////////////// ここまでは各Storageサービス共通 //////////////////////////////////

            //blob
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            //container
            CloudBlobContainer container = blobClient.GetContainerReference("temmfile");
            bakupcontainer = container;


            var backupBlobClient = storageAccount.CreateCloudBlobClient();
            var backupContainer = backupBlobClient.GetContainerReference("temmfile");

            // useFlatBlobListing is true to ensure loading all files in
            // virtual blob sub-folders as a plain list
            var list = backupContainer.ListBlobs(useFlatBlobListing: true);
            var listOfFileNames = new List<string>();



            var blobs = backupContainer.ListBlobs().OfType<CloudBlockBlob>().ToList();

           



            foreach (var blob in blobs)
            {
                var blobFileName = blob.Uri.Segments.Last();

                listOfFileNames.Add(blobFileName);

            }

            listBox1.DataSource = listOfFileNames;

            URI = GetBlobSasUri(container);


             //フィルターかけてdisplaynameがPresentNameのものをコンボボックス３に表示させる
               shipMasterTBBindingSource.Filter = "OwnerGroup = 1004";
               comboBox1.DataSource = shipMasterTBBindingSource;
               comboBox1.DisplayMember = "PresentName";

           //list中身とりだす　フィルターかけた結果の列の長さ分


           // this.shipMasterTBBindingSource.DataSource.ToString();

           //Textboxにロード時あらかじめ月の初めを表示させかつその月の１日目である
           DateTime dtToday = DateTime.Today;

            DateTime dateTimeFirstDay = new DateTime(dtToday.Year, dtToday.Month, 1);

            string firstday = dateTimeFirstDay.ToString();

            string firstdayrem = firstday.Remove(10,8);

            textBox1.Text = firstdayrem;

            //User Name 
            textBox2.Text = Properties.Settings.Default.username;

            //Sorting
            Sorting();

            //Timer
            SetDisplaytime();

           

        }


        public static string GetBlobSasUri(CloudBlobContainer container)
        {
            //Get a reference to a blob within the container.
            CloudBlockBlob blob = container.GetBlockBlobReference("");

            //Get a reference to a blob within the container.


            // blob.Exists();


            SharedAccessBlobPolicy sasConstraints = new SharedAccessBlobPolicy();

            sasConstraints.SharedAccessStartTime = DateTimeOffset.UtcNow.AddMinutes(-5);
            sasConstraints.SharedAccessExpiryTime = DateTimeOffset.UtcNow.AddHours(24);
            sasConstraints.Permissions = SharedAccessBlobPermissions.Read | SharedAccessBlobPermissions.Write;

            //Generate the shared access signature on the blob, setting the constraints directly on the signature.
            string sasBlobToken = blob.GetSharedAccessSignature(sasConstraints);

            //Return the URI string for the container, including the SAS token.
            return blob.Uri + sasBlobToken;

        }


        private void button3_Click_1(object sender, EventArgs e)
        {

           
            //ここでフィルターしたshipnameの列がほしい
           //  comboBox1.SelectedItem = shipMasterTBBindingSource.Filter;

        }

        public void button1_Click_1(object sender, EventArgs e)
        {
          
            decimal v1 = 0;
            decimal v2 = 0;

            
            for (int i = 0; i < dataExchange_feeDataGridView.Rows.Count;i++)
            {

                try
                {
                    //forでまわしてデシマルのv1,v2に対してグリッドロウのi番目つまり行をみていっている
                    v1 = (decimal)dataExchange_feeDataGridView.Rows[i].Cells[4].Value;
                    v2 = (decimal)dataExchange_feeDataGridView.Rows[i].Cells[5].Value;

                    //feeのほうのグリッドビュアーの列(v1 + v2).ToString()1番目にv1v2を足してtotal

                    dataExchange_feeDataGridView[6, i].Value = v1 + v2;
                }
                catch(NullReferenceException)
                {
                    MessageBox.Show("NotTotalValue");
                }
                catch(InvalidCastException)
                {
                    MessageBox.Show("NotTotalValue");
                }
                

            }
                
            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dataExchange_feeBindingSource1.RemoveCurrent();
                this.dataExchange_feeBindingSource1.EndEdit();
                this.dataExchange_feeTableAdapter.Update(this.aZUREDBDataSet.DataExchange_fee);
                MessageBox.Show("deleted");
            }

            catch (InvalidOperationException)
            {
                MessageBox.Show("Notdeletedselect");
            }
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
   
            DateTime dt = System.DateTime.Parse(textBox1.Text) ;
            DateTime dtadd = dt.AddDays(35);
            DateTime dtadd2  =  new DateTime(dtadd.Year, dtadd.Month, 1);

            //秒を消してる０から１０番目そのあと８文字すべて
            string dtrem = dtadd2.ToString().Remove(10, 8);
            textBox1.Text = dtrem;

            //Sorting
            Sorting();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //textboxをDatetimeに変換してdatetime型の変数にADDして年月、月の初めを設定している
            DateTime dt = System.DateTime.Parse(textBox1.Text);
            DateTime dtadd = dt.AddDays(-3);
            DateTime dtadd2 = new DateTime(dtadd.Year, dtadd.Month, 1);

            //秒を消してる
            string dtrem = dtadd2.ToString().Remove(10, 8);
            textBox1.Text = dtrem;

            //Sorting
            Sorting();

        }


        private void button4_Click_2(object sender, EventArgs e)
        {
            Sorting();
        }


        private void Sorting ()
        {

            try{
                comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                //datachenagebindingsorceをソートして日付降順
                dataExchangeBindingSource2.Sort = "MonthGroup";
                dataExchange_feeBindingSource1.Sort = "MonthGroup"; //test

                //バインディングソースをフィルターかけて船名かつデータピッカーで選んだ日付をstringに変換
                dataExchangeBindingSource2.Filter = string.Format("Shipname like '{0:s}'", comboBox1.Text);

                dataExchange_feeBindingSource1.Filter = string.Format("Shipname like '{0:s}'", comboBox1.Text);

            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("日付がありません");
            }
            catch (EvaluateException)
            {
                MessageBox.Show("日付がありません");
            }

        }


        private void button6_Click(object sender, EventArgs e)
        {
            dataExchangeBindingSource2.RemoveFilter();
            dataExchange_feeBindingSource1.RemoveFilter();
        }



        private void button8_Click(object sender, EventArgs e)
        {

            try
            {
                this.dataExchange_CommentBindingSource1.RemoveCurrent();
                this.dataExchange_CommentBindingSource1.EndEdit();
                this.dataExchange_CommentTableAdapter.Update(this.aZUREDBDataSet1.DataExchange_Comment);
                MessageBox.Show("Deleted");
            }

            catch (InvalidOperationException)
            {
                MessageBox.Show("NotSelectedCell");
            }

        }


        private void button9_Click(object sender, EventArgs e)
        {
           
            // TODO: このコード行はデータを 'aZUREDBDataSet.DataExchange' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataExchangeTableAdapter.Fill(this.aZUREDBDataSet.DataExchange);
            // TODO: このコード行はデータを 'aZUREDBDataSet.DataExchange_fee' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataExchange_feeTableAdapter.Fill(this.aZUREDBDataSet.DataExchange_fee);
            // TODO: このコード行はデータを 'aZUREDBDataSet1.DataExchange_Comment' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
          

        }



        private void button10_Click(object sender, EventArgs e)
        {
            dataExchange_CommentBindingSource1.MoveNext();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dataExchange_CommentBindingSource1.MovePrevious();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {

                dataExchangeBindingSource2.RemoveCurrent();
                this.dataExchangeBindingSource2.EndEdit();
                this.dataExchangeTableAdapter.Update(this.aZUREDBDataSet.DataExchange);
                MessageBox.Show("deleted");
            }

            catch (InvalidOperationException)
            {
                MessageBox.Show("Notdeletedselect");
            }
        }


        public void button13_Click(object sender, EventArgs e)
        {
            this.dataExchange_CommentTableAdapter.Fill(this.aZUREDBDataSet1.DataExchange_Comment);
        }


        public void DgvRefresh()
        {
            this.dataExchange_CommentDataGridView.Refresh();
            this.dataExchange_CommentTableAdapter.Fill(this.aZUREDBDataSet1.DataExchange_Comment);
            this.dataExchange_feeTableAdapter.Fill(this.aZUREDBDataSet.DataExchange_fee);
            // ↓これはこのメソッドが機能したことを確認するため
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.dataExchange_feeBindingSourc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);
            //割と重要Form2を呼んでかつメソッドに対してform1のcombobox,textboxを代入してform2が起動時にロードできるようにしている


            Form2 frm2 = new Form2(this);

            //変数１回介さないと空白が入るので面倒
            frm2.month = DateTime.Parse(textBox1.Text);
            frm2.pay = DateTime.Parse(textBox1.Text);
            frm2.shipname = comboBox1.Text;
            frm2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(this);

            this.Validate();
            this.dataExchange_CommentBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);
            this.dataExchange_CommentTableAdapter.Update(this.aZUREDBDataSet1.DataExchange_Comment);

            dataExchange_CommentDataGridView.Refresh();
            this.dataExchange_CommentTableAdapter.Fill(this.aZUREDBDataSet1.DataExchange_Comment);
            frm3.name = textBox2.Text;
            frm3.date = timeNow.Text;
            frm3.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            SetDisplaytime();
        }

        private void SetDisplaytime ()
        {
            //DateTime d = DateTime.Now;

            // timeNow.Text = string.Format("{0:00}:{1:00}:{2:00}", d.Hour, d.Minute, d.Second);

            timeNow.Text = DateTime.Now.ToString("G");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataExchange_CommentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=temmblobadmin;AccountKey=+7YLZ8+YK6td1m55K0AopQBpA/Pp+0z4iBMPind6HI87jhxF9DBe+wb11BbOyZhg+DWCqtitg/iWGexBWDaUdA==");

            ////////////////// ここまでは各Storageサービス共通 //////////////////////////////////

            //blob
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            //container
            CloudBlobContainer container = blobClient.GetContainerReference("temmfile");


            OpenFileDialog ofd = new OpenFileDialog();

            //複数のファイルを選択できるようにする
            ofd.Multiselect = true;


            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイル名をすべて表示する
                foreach (string fn in ofd.FileNames)
                {
                    var fileStream = System.IO.File.OpenRead(fn);
                    var filenamefn = System.IO.Path.GetFileName(fn);
                    CloudBlockBlob blockBlob_upload = container.GetBlockBlobReference(filenamefn);
                    blockBlob_upload.UploadFromStream(fileStream);
                }
            }

            else
            {

            }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "すべてのファイル(*.*) | *.* ";
            sfd.FileName = listBox1.SelectedItem.ToString();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.Stream stream;
                stream = sfd.OpenFile();
                var filenamesn = System.IO.Path.GetFileName(listBox1.SelectedItem.ToString());
                CloudBlockBlob blockBlob_download = bakupcontainer.GetBlockBlobReference(filenamesn);
                blockBlob_download.DownloadToFile(stream.ToString(), System.IO.FileMode.Create);

            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=temmblobadmin;AccountKey=+7YLZ8+YK6td1m55K0AopQBpA/Pp+0z4iBMPind6HI87jhxF9DBe+wb11BbOyZhg+DWCqtitg/iWGexBWDaUdA==");

            CloudBlobClient blobClientWithSAS = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer container = blobClientWithSAS.GetContainerReference("temmfile");

            //Get a reference to a blob within the container.
            CloudBlockBlob blob = container.GetBlockBlobReference(listBox1.SelectedItem.ToString());

            SharedAccessBlobPolicy sasConstraints = new SharedAccessBlobPolicy();
            sasConstraints.SharedAccessStartTime = DateTimeOffset.UtcNow.AddMinutes(-5);
            sasConstraints.SharedAccessExpiryTime = DateTimeOffset.UtcNow.AddHours(24);
            sasConstraints.Permissions = SharedAccessBlobPermissions.Read | SharedAccessBlobPermissions.Write;

            //Generate the shared access signature on the blob, setting the constraints directly on the signature.
            string sasBlobToken = blob.GetSharedAccessSignature(sasConstraints);


            Process.Start(blob.Uri + sasBlobToken);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=temmblobadmin;AccountKey=+7YLZ8+YK6td1m55K0AopQBpA/Pp+0z4iBMPind6HI87jhxF9DBe+wb11BbOyZhg+DWCqtitg/iWGexBWDaUdA==");
            //blob
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            //container
            CloudBlobContainer container = blobClient.GetContainerReference("temmfile");

            var listitem = listBox1.SelectedItem;

            // var blobs = container.GetBlockBlobReference(listitem.ToString());

            CloudBlockBlob blockBlob_delete = container.GetBlockBlobReference(listitem.ToString());

            DialogResult result = MessageBox.Show("削除しますか？", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            //何が選択されたか調べる

            if (result == DialogResult.Yes)
            {
                blockBlob_delete.Delete();


                var list = container.ListBlobs(useFlatBlobListing: true);
                var listOfFileNames = new List<string>();



                var blobs = container.ListBlobs().OfType<CloudBlockBlob>().ToList();


                foreach (var blob in blobs)
                {
                    var blobFileName = blob.Uri.Segments.Last();

                    listOfFileNames.Add(blobFileName);

                }

                listBox1.DataSource = listOfFileNames;
            }

            else if (result == DialogResult.No)
            {


            }
        }
    }
}
