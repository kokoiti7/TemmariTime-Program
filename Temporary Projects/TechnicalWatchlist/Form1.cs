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

namespace TechnicalWatchlist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
    
        }

        private void ship_Master_TBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.Watchlist_File' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.watchlist_FileTableAdapter.Fill(this.aZUREDBDataSet.Watchlist_File);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Watchlist_dwg' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.watchlist_dwgTableAdapter.Fill(this.aZUREDBDataSet.Watchlist_dwg);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Watchlist_Master' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.watchlist_MasterTableAdapter.Fill(this.aZUREDBDataSet.Watchlist_Master);

            this.ship_Master_TBTableAdapter.Fill(this.aZUREDBDataSet.Ship_Master_TB);


            //Username
            txtboxUsername.Text = Properties.Settings.Default.UserName;

            //ship_Master_TBBindingSource.Filter = "OwnerGroup = 1004";
            comboBoxShipname.DataSource = ship_Master_TBBindingSource;
            comboBoxShipname.DisplayMember = "PresentName";
            comboBoxShipname.ValueMember = "ID";
            comboBoxShipname.DropDownStyle = ComboBoxStyle.DropDownList;


            //Timer
            SetDisplaytime();


        }

        private void SetDisplaytime()
        {
           
            timeNow.Text = DateTime.Now.ToString("G");

        }

        private void Usernamecheck()
        {

            int len = txtboxUsername.Text.Length;

            if (len < 1)

                //ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
                MessageBox.Show("Enter user name");

            else

                MessageBox.Show("OK");
            //ファイル以外は受け付けない


        }





        private void buttonShowAllship_Click(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetDisplaytime();
        }

        private void watchlist_FileListBox_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Properties.Settings.Default.accesskey);

                CloudBlobClient blobClientWithSAS = storageAccount.CreateCloudBlobClient();

                CloudBlobContainer container = blobClientWithSAS.GetContainerReference(Properties.Settings.Default.Container);

                //Get a reference to a blob within the container.


                // MessageBox.Show(watchlist_FileListBox.SelectedValue.ToString());

                CloudBlockBlob blob = container.GetBlockBlobReference(watchlist_FileListBox.SelectedValue.ToString());

                SharedAccessBlobPolicy sasConstraints = new SharedAccessBlobPolicy();
                sasConstraints.SharedAccessStartTime = DateTimeOffset.UtcNow.AddMinutes(-5);
                sasConstraints.SharedAccessExpiryTime = DateTimeOffset.UtcNow.AddHours(24);
                sasConstraints.Permissions = SharedAccessBlobPermissions.Read | SharedAccessBlobPermissions.Write;

                //Generate the shared access signature on the blob, setting the constraints directly on the signature.
                string sasBlobToken = blob.GetSharedAccessSignature(sasConstraints);

                 //  MessageBox.Show(blob.Uri.ToString());


                Process.Start(blob.Uri + sasBlobToken);
            }

            catch
            {

                MessageBox.Show("Select file");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Usernamecheck();



            try
            {
                this.Validate();
                this.watchlist_MasterBindingSource1.EndEdit();
                this.watchlist_MasterTableAdapter.Update(this.aZUREDBDataSet.Watchlist_Master);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }



        }

        private void watchlist_FileListBox_DragEnter(object sender, DragEventArgs e)
        {
            //コントロール内にドラッグされたとき実行される
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                //ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
                e.Effect = DragDropEffects.Copy;
            else
                //ファイル以外は受け付けない
                e.Effect = DragDropEffects.None;
        }

        private void watchlist_FileListBox_DragDrop(object sender, DragEventArgs e)
        {
            
            string[] fileName =
                (string[])e.Data.GetData(DataFormats.FileDrop, false);

            string filename2 = System.IO.Path.GetFileName(fileName[0]) ;


           


        }

        private void button5_Click(object sender, EventArgs e)
        {

            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Properties.Settings.Default.accesskey);
            CloudBlobClient blobClientWithSAS = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer container = blobClientWithSAS.GetContainerReference(Properties.Settings.Default.Container);



            OpenFileDialog ofd = new OpenFileDialog();

            //複数のファイルを選択できるようにするXX
            ofd.Multiselect = false;



            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイル名をすべて表示する
                foreach (string fn in ofd.FileNames)
                {


                    var fileStream = System.IO.File.OpenRead(fn);
                    var filenamefn = System.IO.Path.GetFileName(fn);

                    watchlist_FileBindingSource2.AddNew();

                    filenameTextBox1.Text = filenamefn.ToString();


                    CloudBlockBlob blockBlob_upload = container.GetBlockBlobReference(filenamefn);
                    blockBlob_upload.UploadFromStream(fileStream);

                    // save 
                    this.Validate();
                    this.watchlist_FileBindingSource2.EndEdit();
                    this.watchlist_FileTableAdapter.Update(this.aZUREDBDataSet.Watchlist_File);

                }
            }

            else
            {

            }







        }
    }
}
