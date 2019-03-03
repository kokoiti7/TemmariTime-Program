namespace TechnicalWatchlist
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label remark2Label;
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxShipname = new System.Windows.Forms.ComboBox();
            this.buttonShowAllship = new System.Windows.Forms.Button();
            this.aZUREDBDataSet = new TechnicalWatchlist.AZUREDBDataSet();
            this.ship_Master_TBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ship_Master_TBTableAdapter = new TechnicalWatchlist.AZUREDBDataSetTableAdapters.Ship_Master_TBTableAdapter();
            this.tableAdapterManager = new TechnicalWatchlist.AZUREDBDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timeNow = new System.Windows.Forms.Label();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.watchlist_MasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.watchlist_MasterTableAdapter = new TechnicalWatchlist.AZUREDBDataSetTableAdapters.Watchlist_MasterTableAdapter();
            this.watchlist_dwgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.watchlist_dwgTableAdapter = new TechnicalWatchlist.AZUREDBDataSetTableAdapters.Watchlist_dwgTableAdapter();
            this.watchlist_FileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.watchlist_FileTableAdapter = new TechnicalWatchlist.AZUREDBDataSetTableAdapters.Watchlist_FileTableAdapter();
            this.watchlist_FileBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.watchlist_dwgBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.watchlist_MasterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.watchlist_MasterDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.watchlist_dwgBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.watchlist_FileBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.watchlist_FileListBox = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.filenameTextBox1 = new System.Windows.Forms.TextBox();
            this.remark2TextBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.BTNuploadwithdialog = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.watchlist_dwgListBox = new System.Windows.Forms.ListBox();
            remark2Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship_Master_TBBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watchlist_MasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchlist_dwgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchlist_FileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchlist_FileBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchlist_dwgBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchlist_MasterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchlist_MasterDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchlist_dwgBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchlist_FileBindingSource2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // remark2Label
            // 
            remark2Label.AutoSize = true;
            remark2Label.ForeColor = System.Drawing.Color.Green;
            remark2Label.Location = new System.Drawing.Point(13, 3);
            remark2Label.Name = "remark2Label";
            remark2Label.Size = new System.Drawing.Size(62, 17);
            remark2Label.TabIndex = 8;
            remark2Label.Text = "Progress";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(10, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trouble and defect watchlist";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxShipname
            // 
            this.comboBoxShipname.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxShipname.FormattingEnabled = true;
            this.comboBoxShipname.Location = new System.Drawing.Point(12, 51);
            this.comboBoxShipname.Name = "comboBoxShipname";
            this.comboBoxShipname.Size = new System.Drawing.Size(222, 28);
            this.comboBoxShipname.TabIndex = 1;
            this.comboBoxShipname.Tag = "";
            // 
            // buttonShowAllship
            // 
            this.buttonShowAllship.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonShowAllship.Location = new System.Drawing.Point(240, 48);
            this.buttonShowAllship.Name = "buttonShowAllship";
            this.buttonShowAllship.Size = new System.Drawing.Size(111, 33);
            this.buttonShowAllship.TabIndex = 2;
            this.buttonShowAllship.Text = "ALL SHIP";
            this.buttonShowAllship.UseVisualStyleBackColor = true;
            this.buttonShowAllship.Click += new System.EventHandler(this.buttonShowAllship_Click);
            // 
            // aZUREDBDataSet
            // 
            this.aZUREDBDataSet.DataSetName = "AZUREDBDataSet";
            this.aZUREDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ship_Master_TBBindingSource
            // 
            this.ship_Master_TBBindingSource.DataMember = "Ship_Master_TB";
            this.ship_Master_TBBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // ship_Master_TBTableAdapter
            // 
            this.ship_Master_TBTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Ship_Master_TBTableAdapter = this.ship_Master_TBTableAdapter;
            this.tableAdapterManager.UpdateOrder = TechnicalWatchlist.AZUREDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Watchlist_dwgTableAdapter = null;
            this.tableAdapterManager.Watchlist_FileTableAdapter = null;
            this.tableAdapterManager.Watchlist_MasterTableAdapter = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.timeNow);
            this.panel1.Controls.Add(this.txtboxUsername);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonShowAllship);
            this.panel1.Controls.Add(this.comboBoxShipname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 101);
            this.panel1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(581, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 32);
            this.button3.TabIndex = 8;
            this.button3.Text = "Save ALL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = global::TechnicalWatchlist.Properties.Resources.th1KOZZPLO;
            this.button2.Location = new System.Drawing.Point(957, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 36);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add new item to the list";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timeNow
            // 
            this.timeNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeNow.AutoSize = true;
            this.timeNow.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.timeNow.Location = new System.Drawing.Point(933, 3);
            this.timeNow.Name = "timeNow";
            this.timeNow.Size = new System.Drawing.Size(41, 15);
            this.timeNow.TabIndex = 5;
            this.timeNow.Text = "label3";
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtboxUsername.Location = new System.Drawing.Point(502, 11);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(180, 27);
            this.txtboxUsername.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(446, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "User : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // watchlist_MasterBindingSource
            // 
            this.watchlist_MasterBindingSource.DataMember = "Watchlist_Master";
            this.watchlist_MasterBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // watchlist_MasterTableAdapter
            // 
            this.watchlist_MasterTableAdapter.ClearBeforeFill = true;
            // 
            // watchlist_dwgBindingSource
            // 
            this.watchlist_dwgBindingSource.DataMember = "FK_Watchlist_dwg_Watchlist_Master";
            this.watchlist_dwgBindingSource.DataSource = this.watchlist_MasterBindingSource;
            // 
            // watchlist_dwgTableAdapter
            // 
            this.watchlist_dwgTableAdapter.ClearBeforeFill = true;
            // 
            // watchlist_FileBindingSource
            // 
            this.watchlist_FileBindingSource.DataMember = "FK_Watchlist_File_Watchlist_Master";
            this.watchlist_FileBindingSource.DataSource = this.watchlist_MasterBindingSource;
            // 
            // watchlist_FileTableAdapter
            // 
            this.watchlist_FileTableAdapter.ClearBeforeFill = true;
            // 
            // watchlist_FileBindingSource1
            // 
            this.watchlist_FileBindingSource1.DataMember = "FK_Watchlist_File_Watchlist_Master";
            this.watchlist_FileBindingSource1.DataSource = this.watchlist_MasterBindingSource;
            // 
            // watchlist_dwgBindingSource1
            // 
            this.watchlist_dwgBindingSource1.DataMember = "FK_Watchlist_dwg_Watchlist_Master";
            this.watchlist_dwgBindingSource1.DataSource = this.watchlist_MasterBindingSource;
            // 
            // watchlist_MasterBindingSource1
            // 
            this.watchlist_MasterBindingSource1.DataMember = "Watchlist_Master";
            this.watchlist_MasterBindingSource1.DataSource = this.aZUREDBDataSet;
            // 
            // watchlist_MasterDataGridView
            // 
            this.watchlist_MasterDataGridView.AutoGenerateColumns = false;
            this.watchlist_MasterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.watchlist_MasterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.watchlist_MasterDataGridView.DataSource = this.watchlist_MasterBindingSource1;
            this.watchlist_MasterDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watchlist_MasterDataGridView.Location = new System.Drawing.Point(0, 101);
            this.watchlist_MasterDataGridView.Name = "watchlist_MasterDataGridView";
            this.watchlist_MasterDataGridView.RowHeadersWidth = 20;
            this.watchlist_MasterDataGridView.RowTemplate.Height = 21;
            this.watchlist_MasterDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.watchlist_MasterDataGridView.Size = new System.Drawing.Size(1084, 518);
            this.watchlist_MasterDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ListID";
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 51;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Priolity";
            this.dataGridViewTextBoxColumn2.HeaderText = "Priolity";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 75;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ShipID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ShipID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ShipName";
            this.dataGridViewTextBoxColumn4.HeaderText = "ShipName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 98;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Kind";
            this.dataGridViewTextBoxColumn5.HeaderText = "Kind";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 61;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Machinery";
            this.dataGridViewTextBoxColumn6.HeaderText = "Machinery";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 98;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Subject";
            this.dataGridViewTextBoxColumn7.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 81;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DateCom";
            this.dataGridViewTextBoxColumn8.HeaderText = "DateCom";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 93;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DateComp";
            this.dataGridViewTextBoxColumn9.HeaderText = "DateComp";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.Width = 101;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "DateClosed";
            this.dataGridViewTextBoxColumn10.HeaderText = "DateClosed";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 106;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Remark";
            this.dataGridViewTextBoxColumn11.HeaderText = "Remark";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // watchlist_dwgBindingSource2
            // 
            this.watchlist_dwgBindingSource2.DataMember = "FK_Watchlist_dwg_Watchlist_Master";
            this.watchlist_dwgBindingSource2.DataSource = this.watchlist_MasterBindingSource1;
            // 
            // watchlist_FileBindingSource2
            // 
            this.watchlist_FileBindingSource2.DataMember = "FK_Watchlist_File_Watchlist_Master";
            this.watchlist_FileBindingSource2.DataSource = this.watchlist_MasterBindingSource1;
            // 
            // watchlist_FileListBox
            // 
            this.watchlist_FileListBox.AllowDrop = true;
            this.watchlist_FileListBox.DataSource = this.watchlist_FileBindingSource2;
            this.watchlist_FileListBox.DisplayMember = "Filename";
            this.watchlist_FileListBox.FormattingEnabled = true;
            this.watchlist_FileListBox.ItemHeight = 17;
            this.watchlist_FileListBox.Location = new System.Drawing.Point(542, 22);
            this.watchlist_FileListBox.Name = "watchlist_FileListBox";
            this.watchlist_FileListBox.Size = new System.Drawing.Size(351, 157);
            this.watchlist_FileListBox.TabIndex = 3;
            this.watchlist_FileListBox.ValueMember = "Filename";
            this.watchlist_FileListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.watchlist_FileListBox_DragDrop);
            this.watchlist_FileListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.watchlist_FileListBox_DragEnter);
            this.watchlist_FileListBox.DoubleClick += new System.EventHandler(this.watchlist_FileListBox_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.filenameTextBox1);
            this.panel2.Controls.Add(remark2Label);
            this.panel2.Controls.Add(this.remark2TextBox);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.BTNuploadwithdialog);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.watchlist_FileListBox);
            this.panel2.Controls.Add(this.watchlist_dwgListBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 365);
            this.panel2.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(899, 201);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 30);
            this.button5.TabIndex = 27;
            this.button5.Text = "Upload with file dialog";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // filenameTextBox1
            // 
            this.filenameTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.filenameTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filenameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.watchlist_FileBindingSource2, "Filename", true));
            this.filenameTextBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.filenameTextBox1.Location = new System.Drawing.Point(784, 179);
            this.filenameTextBox1.Name = "filenameTextBox1";
            this.filenameTextBox1.Size = new System.Drawing.Size(28, 17);
            this.filenameTextBox1.TabIndex = 26;
            this.filenameTextBox1.TabStop = false;
            // 
            // remark2TextBox
            // 
            this.remark2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.watchlist_MasterBindingSource1, "Remark2", true));
            this.remark2TextBox.Location = new System.Drawing.Point(12, 23);
            this.remark2TextBox.Multiline = true;
            this.remark2TextBox.Name = "remark2TextBox";
            this.remark2TextBox.Size = new System.Drawing.Size(524, 284);
            this.remark2TextBox.TabIndex = 9;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(899, 59);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 30);
            this.button6.TabIndex = 8;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // BTNuploadwithdialog
            // 
            this.BTNuploadwithdialog.Location = new System.Drawing.Point(899, 23);
            this.BTNuploadwithdialog.Name = "BTNuploadwithdialog";
            this.BTNuploadwithdialog.Size = new System.Drawing.Size(180, 30);
            this.BTNuploadwithdialog.TabIndex = 7;
            this.BTNuploadwithdialog.Text = "Upload with file dialog";
            this.BTNuploadwithdialog.UseVisualStyleBackColor = true;
            this.BTNuploadwithdialog.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(899, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 30);
            this.button4.TabIndex = 6;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(542, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Work Drawing / Documents";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(538, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(415, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Files/Message (Double click to open / Drug and Drop to Upload)";
            // 
            // watchlist_dwgListBox
            // 
            this.watchlist_dwgListBox.DataSource = this.watchlist_dwgBindingSource2;
            this.watchlist_dwgListBox.DisplayMember = "Dwgfilename";
            this.watchlist_dwgListBox.FormattingEnabled = true;
            this.watchlist_dwgListBox.ItemHeight = 17;
            this.watchlist_dwgListBox.Location = new System.Drawing.Point(542, 201);
            this.watchlist_dwgListBox.Name = "watchlist_dwgListBox";
            this.watchlist_dwgListBox.Size = new System.Drawing.Size(351, 106);
            this.watchlist_dwgListBox.TabIndex = 3;
            this.watchlist_dwgListBox.ValueMember = "DrawingID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1084, 619);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.watchlist_MasterDataGridView);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = " watchlist";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship_Master_TBBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watchlist_MasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchlist_dwgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchlist_FileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchlist_FileBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchlist_dwgBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchlist_MasterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchlist_MasterDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchlist_dwgBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchlist_FileBindingSource2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxShipname;
        private System.Windows.Forms.Button buttonShowAllship;
        private AZUREDBDataSet aZUREDBDataSet;
        private System.Windows.Forms.BindingSource ship_Master_TBBindingSource;
        private AZUREDBDataSetTableAdapters.Ship_Master_TBTableAdapter ship_Master_TBTableAdapter;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource watchlist_MasterBindingSource;
        private AZUREDBDataSetTableAdapters.Watchlist_MasterTableAdapter watchlist_MasterTableAdapter;
        private System.Windows.Forms.BindingSource watchlist_dwgBindingSource;
        private AZUREDBDataSetTableAdapters.Watchlist_dwgTableAdapter watchlist_dwgTableAdapter;
        private System.Windows.Forms.BindingSource watchlist_FileBindingSource;
        private AZUREDBDataSetTableAdapters.Watchlist_FileTableAdapter watchlist_FileTableAdapter;
        private System.Windows.Forms.BindingSource watchlist_FileBindingSource1;
        private System.Windows.Forms.BindingSource watchlist_dwgBindingSource1;
        private System.Windows.Forms.BindingSource watchlist_MasterBindingSource1;
        private System.Windows.Forms.DataGridView watchlist_MasterDataGridView;
        private System.Windows.Forms.BindingSource watchlist_dwgBindingSource2;
        private System.Windows.Forms.BindingSource watchlist_FileBindingSource2;
        private System.Windows.Forms.ListBox watchlist_FileListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeNow;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button BTNuploadwithdialog;
        private System.Windows.Forms.TextBox remark2TextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.TextBox filenameTextBox1;
        private System.Windows.Forms.ListBox watchlist_dwgListBox;
        private System.Windows.Forms.Button button5;
    }
}

