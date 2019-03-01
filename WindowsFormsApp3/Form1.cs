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
using System.IO;
using System.Xml.Linq;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        CloudBlobContainer bakupcontainer;
        public string filenamelist;
        string seletree;
        string firstnode;

        public Form1()
        {
            InitializeComponent();

            CloudStorageAccount storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=temmblobadmin;AccountKey=+7YLZ8+YK6td1m55K0AopQBpA/Pp+0z4iBMPind6HI87jhxF9DBe+wb11BbOyZhg+DWCqtitg/iWGexBWDaUdA==");

            ////////////////// ここまでは各Storageサービス共通 //////////////////////////////////

            //blob
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            //container
            CloudBlobContainer container = blobClient.GetContainerReference("temmfile");

            CloudBlockBlob blockBlob = container.GetBlockBlobReference("temmfile");

            TreeNode tn = treeView.Nodes.Add("temmfile");

            foreach (IListBlobItem item in container.ListBlobs(null, false))
            {
                if (item.GetType() == typeof(CloudBlockBlob))
                {
                    CloudBlockBlob blob = (CloudBlockBlob)item;

                    tn.Nodes.Add(blob.Name);

                }


            }

           

            tn.ExpandAll();
            TreeNode objTopNode = treeView.TopNode;
            // 先頭ノードを選択状態に変更する
            treeView.SelectedNode = objTopNode;

            firstnode = tn.FirstNode.ToString();

            firstnode = firstnode.Remove(0,10);




        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //tablefill
            Tablefill();

            //フィルターかけてdisplaynameがPresentNameのものをコンボボックス３に表示させる
            shipMasterTBBindingSource.Filter = "OwnerGroup = 1004";
            comboBox3.DataSource = shipMasterTBBindingSource;
            comboBox3.DisplayMember = "PresentName";
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;


            //Textboxにロード時あらかじめ月の初めを表示させかつその月の１日目である
            DateTime dtToday = DateTime.Today;

            DateTime dateTimeFirstDay = new DateTime(dtToday.Year, dtToday.Month, 1);

            string firstday = dateTimeFirstDay.ToString();

            string firstdayrem = firstday.Remove(10, 8);

            textBox1.Text = firstdayrem;

            //Sorting
            Sorting();

            //Timer
            SetDisplaytime();

            //strageaccount
            Strageaccount();

            //listupdate
            Listupdate();

            // ツリービューの先頭ノードを取得する
            TreeNode objTopNode = treeView.TopNode;
            // 先頭ノードを選択状態に変更する
            treeView.SelectedNode = objTopNode;




        }



    

        private String getFileSize(long fileSize)
        {
            String ret = fileSize + " バイト";
            if (fileSize > (1024f * 1024f * 1024f))
            {
                ret = Math.Round((fileSize / 1024f / 1024f / 1024f), 2).ToString() + " GB";
            }
            else if (fileSize > (1024f * 1024f))
            {
                ret = Math.Round((fileSize / 1024f / 1024f), 2).ToString() + " MB";
            }
            else if (fileSize > 1024f)
            {
                ret = Math.Round((fileSize / 1024f)).ToString() + " KB";
            }

            return ret;
        }

        public void Tablefill()
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
        }

        public void Strageaccount()
        {
            //accuntnameがtemmblobadminでキーが～っていうのを宣言

            CloudStorageAccount storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=temmblobadmin;AccountKey=+7YLZ8+YK6td1m55K0AopQBpA/Pp+0z4iBMPind6HI87jhxF9DBe+wb11BbOyZhg+DWCqtitg/iWGexBWDaUdA==");

            ////////////////// ここまでは各Storageサービス共通 //////////////////////////////////

            //blob
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            //container
            CloudBlobContainer container = blobClient.GetContainerReference("temmfile");

            bakupcontainer = container;
        }

        private void Sorting()
        {

            try
            {

                dataExchangeBindingSource2.Filter = string.Format("Shipname like '{0:s}'", comboBox3.Text) + "AND MonthGroup = '" + textBox1.Text + "'";

                dataExchange_feeBindingSource1.Filter = string.Format("Shipname like '{0:s}'", comboBox3.Text) + "AND MonthGroup = '" + textBox1.Text + "'";

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

        public void DgvRefresh()
        {
            this.dataExchange_CommentDataGridView.Refresh();
            this.dataExchange_CommentTableAdapter.Fill(this.aZUREDBDataSet1.DataExchange_Comment);
            this.dataExchange_feeTableAdapter.Fill(this.aZUREDBDataSet.DataExchange_fee);
            // ↓これはこのメソッドが機能したことを確認するため

        }

        private void SetDisplaytime()
        {
            //DateTime d = DateTime.Now;

            // timeNow.Text = string.Format("{0:00}:{1:00}:{2:00}", d.Hour, d.Minute, d.Second);

            timeNow.Text = DateTime.Now.ToString("G");

        }

        private void Listupdate()
        {

            CloudStorageAccount storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=temmblobadmin;AccountKey=+7YLZ8+YK6td1m55K0AopQBpA/Pp+0z4iBMPind6HI87jhxF9DBe+wb11BbOyZhg+DWCqtitg/iWGexBWDaUdA==");

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

           


        }

        public static string GetBlobSasUri(CloudBlobContainer container)
        {
            //nullは入らないから空白
            CloudBlockBlob blob = container.GetBlockBlobReference(" ");


            SharedAccessBlobPolicy sasConstraints = new SharedAccessBlobPolicy();

            sasConstraints.SharedAccessStartTime = DateTimeOffset.UtcNow.AddMinutes(-5);
            sasConstraints.SharedAccessExpiryTime = DateTimeOffset.UtcNow.AddHours(24);
            sasConstraints.Permissions = SharedAccessBlobPermissions.Read | SharedAccessBlobPermissions.Write;

            //Generate the shared access signature on the blob, setting the constraints directly on the signature.
            string sasBlobToken = blob.GetSharedAccessSignature(sasConstraints);

            //Return the URI string for the container, including the SAS token.
            return blob.Uri + sasBlobToken;

        }


        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            SetDisplaytime();
        }

        private void NextMonth_Click(object sender, EventArgs e)
        {
            //textboxをDatetimeに変換してdatetime型の変数にADDして年月、月の初めを設定している
            DateTime dt = System.DateTime.Parse(textBox1.Text);
            //月の初めから+35させるそうすれば確実に次の月だから
            DateTime dtadd = dt.AddDays(+35);
            DateTime dtadd2 = new DateTime(dtadd.Year, dtadd.Month, 1);

            //秒を消してる
            string dtrem = dtadd2.ToString().Remove(10, 8);


            textBox1.Text = dtrem;

            //Sorting
            Sorting();

        }

        private void BackMonth_Click(object sender, EventArgs e)
        {
            //textboxをDatetimeに変換してdatetime型の変数にADDして年月、月の初めを設定している
            DateTime dt = System.DateTime.Parse(textBox1.Text);
            //月初めからー３
            DateTime dtadd = dt.AddDays(-3);
            DateTime dtadd2 = new DateTime(dtadd.Year, dtadd.Month, 1);

            //秒を消してる
            string dtrem = dtadd2.ToString().Remove(10, 8);
            textBox1.Text = dtrem;

            //Sorting
            Sorting();
        }

        private void SelectedRemove_Click(object sender, EventArgs e)
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

        private void NewAddItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.dataExchange_feeBindingSourc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);
            //割と重要Form2を呼んでかつメソッドに対してform1のcombobox,textboxを代入してform2が起動時にロードできるようにしている

            Form2 frm2 = new Form2(this);

            //変数１回介さないと空白が入るので面倒
            frm2.month = DateTime.Parse(textBox1.Text);
            frm2.pay = DateTime.Parse(textBox1.Text);
            frm2.shipname = comboBox3.Text;
            frm2.Show();
        }

        private void GrandTotal_Click(object sender, EventArgs e)
        {
            decimal v1 = 0;
            decimal v2 = 0;


            for (int i = 0; i < dataExchange_feeDataGridView.Rows.Count; i++)
            {

                try
                {
                    //forでまわしてデシマルのv1,v2に対してグリッドロウのi番目つまり行をみていっている
                    v1 = (decimal)dataExchange_feeDataGridView[4, i].Value;
                    v2 = (decimal)dataExchange_feeDataGridView[5, i].Value;

                    //feeのほうのグリッドビュアーの列(v1 + v2).ToString()1番目にv1v2を足してtotal

                    dataExchange_feeDataGridView[6, i].Value = v1 + v2;
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("nullです");
                }

                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("index範囲外です");
                }

            }

        }

        private void AllRecord_Click(object sender, EventArgs e)
        {
            dataExchangeBindingSource2.RemoveFilter();
            dataExchange_feeBindingSource1.RemoveFilter();
        }

        private void RemoveComment_Click(object sender, EventArgs e)
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

        private void AddComment_Click(object sender, EventArgs e)
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

        private void NewAddsItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);


            Form4 frm4 = new Form4(this);


            frm4.Show();

        }

        private void SelectedRemoves_Click(object sender, EventArgs e)
        {
            try
            {

                dataExchangeBindingSource2.RemoveCurrent();
                this.dataExchangeBindingSource2.EndEdit();
                this.dataExchangeTableAdapter.Update(this.aZUREDBDataSet.DataExchange);
                MessageBox.Show("deleted");
                this.dataExchange_CommentTableAdapter.Fill(this.aZUREDBDataSet1.DataExchange_Comment);
            }

            catch (InvalidOperationException)
            {
                MessageBox.Show("Notdeletedselect");
            }
        }



        private void Download_Click(object sender, EventArgs e)
        {


            try
            {
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Filter = "すべてのファイル(*.*) | *.* ";
                sfd.FileName = firstnode;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    System.IO.Stream stream;
                    stream = sfd.OpenFile();

                    var seletree = System.IO.Path.GetFileName(firstnode);
                    CloudBlockBlob blockBlob_download = bakupcontainer.GetBlockBlobReference(seletree);
                    blockBlob_download.DownloadToFile(stream.ToString(), System.IO.FileMode.Create);

                }

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("選んでください");
            }

          
        }

        private void Delete_Click(object sender, EventArgs e)
        {
          
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=temmblobadmin;AccountKey=+7YLZ8+YK6td1m55K0AopQBpA/Pp+0z4iBMPind6HI87jhxF9DBe+wb11BbOyZhg+DWCqtitg/iWGexBWDaUdA==");
            //blob
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            //container
            CloudBlobContainer container = blobClient.GetContainerReference("temmfile");

            var listitem = seletree;

            // var blobs = container.GetBlockBlobReference(listitem.ToString());

            CloudBlockBlob blockBlob_delete = container.GetBlockBlobReference(firstnode);

            DialogResult result = MessageBox.Show("削除しますか？", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            //何が選択されたか調べる

            try
            {

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

                   
                }

                else if (result == DialogResult.No)
                {


                }



            }

            catch (ArgumentNullException)
            {
                Listupdate();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("選んでください");
            }

        }

        private void Upload_Click(object sender, EventArgs e)
        {
            seletree = treeView.SelectedNode.ToString();
            seletree = seletree.Remove(0, 10);

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

        private void TreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

          

            CloudStorageAccount storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=temmblobadmin;AccountKey=+7YLZ8+YK6td1m55K0AopQBpA/Pp+0z4iBMPind6HI87jhxF9DBe+wb11BbOyZhg+DWCqtitg/iWGexBWDaUdA==");

            CloudBlobClient blobClientWithSAS = storageAccount.CreateCloudBlobClient();

            CloudBlobContainer container = blobClientWithSAS.GetContainerReference("temmfile");

            //Get a reference to a blob within the container.
            CloudBlockBlob blob = container.GetBlockBlobReference(firstnode);

            SharedAccessBlobPolicy sasConstraints = new SharedAccessBlobPolicy();
            sasConstraints.SharedAccessStartTime = DateTimeOffset.UtcNow.AddMinutes(-5);
            sasConstraints.SharedAccessExpiryTime = DateTimeOffset.UtcNow.AddHours(24);
            sasConstraints.Permissions = SharedAccessBlobPermissions.Read | SharedAccessBlobPermissions.Write;

            //Generate the shared access signature on the blob, setting the constraints directly on the signature.
            string sasBlobToken = blob.GetSharedAccessSignature(sasConstraints);


            Process.Start(blob.Uri + sasBlobToken);
        }


    }
}
