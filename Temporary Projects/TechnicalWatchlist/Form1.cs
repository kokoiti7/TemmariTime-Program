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
        string cell;

        public Form1()
        {
            InitializeComponent();
           

        }

        private void Ship_Master_TBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.Watchlist_File' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.watchlist_dwgBindingSource2TableAdapter.Fill(this.aZUREDBDataSet1.Watchlist_File);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Watchlist_dwg' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.watchlist_dwgTableAdapter.Fill(this.aZUREDBDataSet1.Watchlist_dwg);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Watchlist_Master' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.watchlist_MasterTableAdapter.Fill(this.aZUREDBDataSet1.Watchlist_Master);

            this.ship_Master_TBTableAdapter.Fill(this.aZUREDBDataSet1.Ship_Master_TB);


            watchlist_MasterDataGridView.Sort(watchlist_MasterDataGridView.Columns[0], ListSortDirection.Descending);

            watchlist_MasterBindingSource1.RemoveFilter();
          
            //Username
            txtboxUsername.Text = Properties.Settings.Default.UserName;

           
            watchlist_MasterBindingSource1.Filter = string.Format("DateClosed > '2000/01/01'");


            //ship_Master_TBBindingSource.Filter = "OwnerGroup = 1004";
            comboBoxShipname.DataSource = ship_Master_TBBindingSource;
            comboBoxShipname.DisplayMember = "PresentName";
            comboBoxShipname.ValueMember = "ID";
            comboBoxShipname.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxShipname.SelectedIndex = Properties.Settings.Default.ComboShip;

            watchlist_FileBindingSource2.Sort = "ShipID 100001";

            //Timer
            SetDisplaytime();


        }

        private void SetDisplaytime()
        {

            timenow.Text = DateTime.Now.ToString("G");

        }

        private void Usernamecheck()
        {

            int len = txtboxUsername.Text.Length;

            if (len < 1)

                //ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
                MessageBox.Show("Enter user name");

           
            //ファイル以外は受け付けない


        }

        private void ButtonShowAllship_Click(object sender, EventArgs e)
        {
            

                watchlist_MasterBindingSource1.Filter = string.Format("DateClosed > '2000/01/01'");



        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            SetDisplaytime();
        }

        private void Watchlist_FileListBox_DoubleClick(object sender, EventArgs e)
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

        private void Watchlist_FileListBox_DragEnter(object sender, DragEventArgs e)
        {
            //コントロール内にドラッグされたとき実行される
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                //ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
                e.Effect = DragDropEffects.All;
            else
                //ファイル以外は受け付けない
                e.Effect = DragDropEffects.None;
        }

        private void Watchlist_FileListBox_DragDrop(object sender, DragEventArgs e)
        {
            //0305ここをいじる

            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (fileName.Length <= 0)
            {
                return;
            }

            string filenamefn = System.IO.Path.GetFileName(fileName[0]);
           

            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Properties.Settings.Default.accesskey);
            CloudBlobClient blobClientWithSAS = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer container = blobClientWithSAS.GetContainerReference(Properties.Settings.Default.Container);


            string datestring = DateTime.Now.ToString("yyyyMMddHHmmss");

            string filenameblob = string.Format(datestring + filenamefn);


            MessageBox.Show(filenameblob);

            var fileStream = System.IO.File.OpenRead(fileName[0]);

            watchlist_FileBindingSource2.AddNew();

            filenameTextBox1.Text = filenameblob;



            CloudBlockBlob blockBlob_upload = container.GetBlockBlobReference(filenameblob);
            blockBlob_upload.UploadFromStream(fileStream);

            // save 
            this.Validate();
            this.watchlist_FileBindingSource2.EndEdit();
            this.watchlist_dwgBindingSource2TableAdapter.Update(this.aZUREDBDataSet1.Watchlist_File);



        }

        private void Watchlist_dwgListBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileName1 =(string[])e.Data.GetData(DataFormats.FileDrop, false);

            string filename2 = System.IO.Path.GetFileName(fileName1[0]);
        }

        private void Watchlist_dwgListBox_DragEnter(object sender, DragEventArgs e)
        {
            //コントロール内にドラッグされたとき実行される
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                //ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
                e.Effect = DragDropEffects.Copy;
            else
                //ファイル以外は受け付けない
                e.Effect = DragDropEffects.None;
        }

        private void Watchlist_dwgListBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Properties.Settings.Default.accesskey);

                CloudBlobClient blobClientWithSAS = storageAccount.CreateCloudBlobClient();

                CloudBlobContainer container = blobClientWithSAS.GetContainerReference(Properties.Settings.Default.Container);

                //Get a reference to a blob within the container.


                // MessageBox.Show(watchlist_FileListBox.SelectedValue.ToString());

                CloudBlockBlob blob = container.GetBlockBlobReference(watchlist_dwgListBox.SelectedValue.ToString());

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

        private void SaveAll_Click(object sender, EventArgs e)
        {
            SaveAllData();
        }

        private void SaveAllData()
        {
            Usernamecheck();



            try
            {
                //remark
                watchlist_MasterDataGridView.CurrentCell = watchlist_MasterDataGridView[10, watchlist_MasterDataGridView.CurrentCell.RowIndex];
                watchlist_MasterDataGridView.CurrentCell.Value = txtboxUsername.Text + " " + timenow.Text;
                this.Validate();
                this.watchlist_MasterBindingSource1.EndEdit();
                this.watchlist_MasterTableAdapter.Update(this.aZUREDBDataSet1.Watchlist_Master);

                this.Validate();
                this.watchlist_FileBindingSource2.EndEdit();
                this.watchlist_dwgBindingSource2TableAdapter.Update(this.aZUREDBDataSet1.Watchlist_File);

              



                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }

        public void Filltable()
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.Watchlist_File' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.watchlist_dwgBindingSource2TableAdapter.Fill(this.aZUREDBDataSet1.Watchlist_File);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Watchlist_dwg' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.watchlist_dwgTableAdapter.Fill(this.aZUREDBDataSet1.Watchlist_dwg);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Watchlist_Master' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.watchlist_MasterTableAdapter.Fill(this.aZUREDBDataSet1.Watchlist_Master);

            this.ship_Master_TBTableAdapter.Fill(this.aZUREDBDataSet1.Ship_Master_TB);
        }

        private void UploadWithFileDialog_Click(object sender, EventArgs e)
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

                    string datestring =  DateTime.Now.ToString("yyyyMMddHHmmss");
                    string filenameblob = string.Format(datestring+ filenamefn);
                  //  MessageBox.Show(filenameblob);
                    
                    watchlist_FileBindingSource2.AddNew();

                      filenameTextBox1.Text = filenameblob;
                    

                
                    CloudBlockBlob blockBlob_upload = container.GetBlockBlobReference(filenameblob);
                    blockBlob_upload.UploadFromStream(fileStream);

                    // save 
                    this.Validate();
                    this.watchlist_FileBindingSource2.EndEdit();
                    this.watchlist_dwgBindingSource2TableAdapter.Update(this.aZUREDBDataSet1.Watchlist_File);

                }
            }

            else
            {

            }
        }

        private void UploadWithFiledialog2_Click(object sender, EventArgs e)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Properties.Settings.Default.accesskey);
            CloudBlobClient blobClientWithSAS = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer container = blobClientWithSAS.GetContainerReference(Properties.Settings.Default.Container);



            OpenFileDialog ofd = new OpenFileDialog();

            //複数のファイルを選択できるようにするXX
            ofd.Multiselect = false;


            try
            {


                //ダイアログを表示する
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //OKボタンがクリックされたとき、選択されたファイル名をすべて表示する
                    foreach (string fn in ofd.FileNames)
                    {


                        var fileStream = System.IO.File.OpenRead(fn);
                        var filenamefn = System.IO.Path.GetFileName(fn);

                        string datestring = DateTime.Now.ToString("yyyyMMddHHmmss");
                        string filenameblob = string.Format(datestring + filenamefn);
                        //  MessageBox.Show(filenameblob);

                        watchlist_dwgBindingSource2.AddNew();

                        FileNameTextBox2.Text = filenameblob;



                        CloudBlockBlob blockBlob_upload = container.GetBlockBlobReference(filenameblob);
                        blockBlob_upload.UploadFromStream(fileStream);

                        // save 
                        this.Validate();
                        this.watchlist_dwgBindingSource2.EndEdit();
                        this.watchlist_dwgTableAdapter.Update(this.aZUREDBDataSet1.Watchlist_dwg);

                    }
                }

                else
                {

                }
            }
            catch (NoNullAllowedException)
            {
               
            }
            catch (ArgumentNullException)
            {

            }
        }

        private void Delete_Click_1(object sender, EventArgs e)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Properties.Settings.Default.accesskey);

            CloudBlobClient blobClientWithSAS = storageAccount.CreateCloudBlobClient();

            CloudBlobContainer container = blobClientWithSAS.GetContainerReference(Properties.Settings.Default.Container);


            CloudBlockBlob blockBlob_delete = container.GetBlockBlobReference(watchlist_FileListBox.SelectedValue.ToString());

            int sel = watchlist_FileListBox.SelectedIndex;

            MessageBox.Show(watchlist_FileListBox.SelectedValue.ToString());

            DialogResult result = MessageBox.Show("Are you sure ? " + '\n' + "Delete " + watchlist_FileListBox.SelectedValue.ToString(), "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            //何が選択されたか調べる

            try
            {

                if (result == DialogResult.Yes)
                {
                    blockBlob_delete.Delete();

                    watchlist_FileBindingSource2.RemoveCurrent();

                    this.Validate();
                    this.watchlist_FileBindingSource2.EndEdit();
                    this.watchlist_dwgBindingSource2TableAdapter.Update(this.aZUREDBDataSet1.Watchlist_File);

                }

                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Error");

                }

            }
            catch (StorageException)
            {
                MessageBox.Show("Please select item.");
            }
        }

        private void Delete2_Click(object sender, EventArgs e)
        {

            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Properties.Settings.Default.accesskey);

            CloudBlobClient blobClientWithSAS = storageAccount.CreateCloudBlobClient();

            CloudBlobContainer container = blobClientWithSAS.GetContainerReference(Properties.Settings.Default.Container);

            CloudBlockBlob blockBlob_delete = container.GetBlockBlobReference(watchlist_dwgListBox.SelectedValue.ToString());

            MessageBox.Show(watchlist_dwgListBox.SelectedValue.ToString());


            DialogResult result = MessageBox.Show("Are you sure ? " + '\n' + "Delete " + watchlist_dwgListBox.SelectedValue.ToString(), "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            //何が選択されたか調べる

            try
            {

                if (result == DialogResult.Yes)
                {

                    blockBlob_delete.Delete();
                    watchlist_dwgBindingSource2.RemoveCurrent();

                    this.Validate();
                    this.watchlist_dwgBindingSource2.EndEdit();
                    this.watchlist_dwgTableAdapter.Update(this.aZUREDBDataSet1.Watchlist_dwg);



                }

                else if (result == DialogResult.No)
                {
                    MessageBox.Show("no");

                }

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select item.");
            }
        }

        private void ComboBoxShipname_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
            //重要ANDで書かないとシップネームとDateclosedでフィルターかけることができない
            watchlist_MasterBindingSource1.Filter = string.Format("DateClosed > '2000/01/01'" +  "AND Shipname like '{0:s}'", comboBoxShipname.Text);


            Properties.Settings.Default.ComboShip = comboBoxShipname.SelectedIndex;
            Properties.Settings.Default.Save();

        }

        private void TxtboxUsername_Leave(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserName = txtboxUsername.Text;
            Properties.Settings.Default.Save();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            //11はリマーク
            Filltable();

        }

        private void FileNameTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNewItemToTheList_Click(object sender, EventArgs e)
        {
            NewItem frm2 = new NewItem();


            frm2.shipname = comboBoxShipname.Text;
            frm2.ShowDialog();
            Filltable();

        }

        private void DateVisible_CheckedChanged(object sender, EventArgs e)
        {

               
                watchlist_MasterBindingSource1.Filter = string.Format("DateClosed > '2000/01/01'");


                watchlist_MasterBindingSource1.RemoveFilter();
     
        }

        private void comboBoxShipname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
