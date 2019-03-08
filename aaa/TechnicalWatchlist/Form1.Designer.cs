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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxShipname = new System.Windows.Forms.ComboBox();
            this.buttonShowAllship = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.label6 = new System.Windows.Forms.Label();
            this.Group = new System.Windows.Forms.GroupBox();
            this.ALLButton3 = new System.Windows.Forms.RadioButton();
            this.InProgressButton = new System.Windows.Forms.RadioButton();
            this.ClosedButton = new System.Windows.Forms.RadioButton();
            this.timenow = new System.Windows.Forms.Label();
            this.SaveAll = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.AddNewItemToTheList = new System.Windows.Forms.Button();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.watchlist_FileListBox = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reportfilenameTextBox = new System.Windows.Forms.TextBox();
            this.Delete3 = new System.Windows.Forms.Button();
            this.UploadWithFileDialog3 = new System.Windows.Forms.Button();
            this.watchlist_F103ListBox = new System.Windows.Forms.ListBox();
            this.FileNameTextBox2 = new System.Windows.Forms.TextBox();
            this.UploadWithFiledialog2 = new System.Windows.Forms.Button();
            this.filenameTextBox1 = new System.Windows.Forms.TextBox();
            this.remark2TextBox = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.UploadWithFileDialog = new System.Windows.Forms.Button();
            this.Delete2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.watchlist_dwgListBox = new System.Windows.Forms.ListBox();
            this.watchlist_MasterDataGridView = new System.Windows.Forms.DataGridView();
            this.reportfilenameListBox = new System.Windows.Forms.ListBox();
            remark2Label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.Group.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watchlist_MasterDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // remark2Label
            // 
            remark2Label.AutoSize = true;
            remark2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            remark2Label.Location = new System.Drawing.Point(3, 8);
            remark2Label.Name = "remark2Label";
            remark2Label.Size = new System.Drawing.Size(62, 17);
            remark2Label.TabIndex = 8;
            remark2Label.Text = "Progress";
            // 
            // comboBoxShipname
            // 
            this.comboBoxShipname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.comboBoxShipname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxShipname.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxShipname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxShipname.FormattingEnabled = true;
            this.comboBoxShipname.Location = new System.Drawing.Point(3, 65);
            this.comboBoxShipname.Name = "comboBoxShipname";
            this.comboBoxShipname.Size = new System.Drawing.Size(210, 28);
            this.comboBoxShipname.TabIndex = 1;
            this.comboBoxShipname.Tag = "";
            this.comboBoxShipname.ValueMember = "ID";
            this.comboBoxShipname.SelectedIndexChanged += new System.EventHandler(this.ComboBoxShipname_SelectedIndexChanged);
            this.comboBoxShipname.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxShipname_SelectionChangeCommitted);
            // 
            // buttonShowAllship
            // 
            this.buttonShowAllship.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.buttonShowAllship.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonShowAllship.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonShowAllship.Location = new System.Drawing.Point(219, 63);
            this.buttonShowAllship.Name = "buttonShowAllship";
            this.buttonShowAllship.Size = new System.Drawing.Size(123, 35);
            this.buttonShowAllship.TabIndex = 2;
            this.buttonShowAllship.Text = "ALL SHIP";
            this.buttonShowAllship.UseVisualStyleBackColor = false;
            this.buttonShowAllship.Click += new System.EventHandler(this.ButtonShowAllship_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bindingNavigator1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Group);
            this.panel1.Controls.Add(this.timenow);
            this.panel1.Controls.Add(this.SaveAll);
            this.panel1.Controls.Add(this.Refresh);
            this.panel1.Controls.Add(this.AddNewItemToTheList);
            this.panel1.Controls.Add(this.txtboxUsername);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonShowAllship);
            this.panel1.Controls.Add(this.comboBoxShipname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1318, 101);
            this.panel1.TabIndex = 3;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorSeparator2,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(1111, 70);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(134, 25);
            this.bindingNavigator1.TabIndex = 17;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.ActiveLinkColor = System.Drawing.Color.Black;
            this.bindingNavigatorCountItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.bindingNavigatorCountItem.LinkColor = System.Drawing.SystemColors.ControlText;
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目の総数";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 25);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "現在の場所";
            this.bindingNavigatorPositionItem.Click += new System.EventHandler(this.BindingNavigatorPositionItem_Click);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(1010, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "LowCount : ";
            // 
            // Group
            // 
            this.Group.Controls.Add(this.ALLButton3);
            this.Group.Controls.Add(this.InProgressButton);
            this.Group.Controls.Add(this.ClosedButton);
            this.Group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Group.Location = new System.Drawing.Point(3, 3);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(339, 60);
            this.Group.TabIndex = 14;
            this.Group.TabStop = false;
            this.Group.Text = "SelectionGroup";
            // 
            // ALLButton3
            // 
            this.ALLButton3.AutoSize = true;
            this.ALLButton3.Location = new System.Drawing.Point(189, 24);
            this.ALLButton3.Name = "ALLButton3";
            this.ALLButton3.Size = new System.Drawing.Size(49, 21);
            this.ALLButton3.TabIndex = 14;
            this.ALLButton3.TabStop = true;
            this.ALLButton3.Text = "ALL";
            this.ALLButton3.UseVisualStyleBackColor = true;
            // 
            // InProgressButton
            // 
            this.InProgressButton.AutoSize = true;
            this.InProgressButton.Checked = true;
            this.InProgressButton.Location = new System.Drawing.Point(16, 24);
            this.InProgressButton.Name = "InProgressButton";
            this.InProgressButton.Size = new System.Drawing.Size(93, 21);
            this.InProgressButton.TabIndex = 12;
            this.InProgressButton.TabStop = true;
            this.InProgressButton.Text = "InProgress";
            this.InProgressButton.UseVisualStyleBackColor = true;
            // 
            // ClosedButton
            // 
            this.ClosedButton.AutoSize = true;
            this.ClosedButton.Location = new System.Drawing.Point(115, 24);
            this.ClosedButton.Name = "ClosedButton";
            this.ClosedButton.Size = new System.Drawing.Size(68, 21);
            this.ClosedButton.TabIndex = 13;
            this.ClosedButton.Text = "Closed";
            this.ClosedButton.UseVisualStyleBackColor = true;
            // 
            // timenow
            // 
            this.timenow.AutoSize = true;
            this.timenow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.timenow.Location = new System.Drawing.Point(1015, 9);
            this.timenow.Name = "timenow";
            this.timenow.Size = new System.Drawing.Size(63, 17);
            this.timenow.TabIndex = 9;
            this.timenow.Text = "timenow";
            // 
            // SaveAll
            // 
            this.SaveAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.SaveAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SaveAll.Location = new System.Drawing.Point(685, 9);
            this.SaveAll.Name = "SaveAll";
            this.SaveAll.Size = new System.Drawing.Size(147, 89);
            this.SaveAll.TabIndex = 8;
            this.SaveAll.Text = "SaveAll";
            this.SaveAll.UseVisualStyleBackColor = false;
            this.SaveAll.Click += new System.EventHandler(this.SaveAll_Click);
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Refresh.Location = new System.Drawing.Point(532, 9);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(147, 89);
            this.Refresh.TabIndex = 7;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // AddNewItemToTheList
            // 
            this.AddNewItemToTheList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.AddNewItemToTheList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddNewItemToTheList.Location = new System.Drawing.Point(354, 9);
            this.AddNewItemToTheList.Name = "AddNewItemToTheList";
            this.AddNewItemToTheList.Size = new System.Drawing.Size(172, 89);
            this.AddNewItemToTheList.TabIndex = 6;
            this.AddNewItemToTheList.Text = "Add new item to the list";
            this.AddNewItemToTheList.UseVisualStyleBackColor = false;
            this.AddNewItemToTheList.Click += new System.EventHandler(this.AddNewItemToTheList_Click);
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtboxUsername.ForeColor = System.Drawing.Color.Blue;
            this.txtboxUsername.Location = new System.Drawing.Point(1111, 33);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(147, 27);
            this.txtboxUsername.TabIndex = 4;
            this.txtboxUsername.Leave += new System.EventHandler(this.TxtboxUsername_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(1046, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "User : ";
            // 
            // watchlist_FileListBox
            // 
            this.watchlist_FileListBox.AllowDrop = true;
            this.watchlist_FileListBox.FormattingEnabled = true;
            this.watchlist_FileListBox.ItemHeight = 17;
            this.watchlist_FileListBox.Location = new System.Drawing.Point(358, 31);
            this.watchlist_FileListBox.Name = "watchlist_FileListBox";
            this.watchlist_FileListBox.Size = new System.Drawing.Size(363, 225);
            this.watchlist_FileListBox.TabIndex = 3;
            this.watchlist_FileListBox.ValueMember = "Filename";
            this.watchlist_FileListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.Watchlist_FileListBox_DragDrop);
            this.watchlist_FileListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.Watchlist_FileListBox_DragEnter);
            this.watchlist_FileListBox.DoubleClick += new System.EventHandler(this.Watchlist_FileListBox_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportfilenameListBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.reportfilenameTextBox);
            this.panel2.Controls.Add(this.Delete3);
            this.panel2.Controls.Add(this.UploadWithFileDialog3);
            this.panel2.Controls.Add(this.watchlist_F103ListBox);
            this.panel2.Controls.Add(this.FileNameTextBox2);
            this.panel2.Controls.Add(this.UploadWithFiledialog2);
            this.panel2.Controls.Add(this.filenameTextBox1);
            this.panel2.Controls.Add(remark2Label);
            this.panel2.Controls.Add(this.remark2TextBox);
            this.panel2.Controls.Add(this.Delete);
            this.panel2.Controls.Add(this.UploadWithFileDialog);
            this.panel2.Controls.Add(this.Delete2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.watchlist_FileListBox);
            this.panel2.Controls.Add(this.watchlist_dwgListBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 712);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1318, 320);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(1074, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "(Drug and Drop to Upload)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(1015, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "F103-5";
            // 
            // reportfilenameTextBox
            // 
            this.reportfilenameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.reportfilenameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportfilenameTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reportfilenameTextBox.Location = new System.Drawing.Point(191, 282);
            this.reportfilenameTextBox.Name = "reportfilenameTextBox";
            this.reportfilenameTextBox.Size = new System.Drawing.Size(32, 17);
            this.reportfilenameTextBox.TabIndex = 34;
            // 
            // Delete3
            // 
            this.Delete3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.Delete3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Delete3.Location = new System.Drawing.Point(1169, 263);
            this.Delete3.Name = "Delete3";
            this.Delete3.Size = new System.Drawing.Size(112, 30);
            this.Delete3.TabIndex = 32;
            this.Delete3.Text = "Delete";
            this.Delete3.UseVisualStyleBackColor = false;
            this.Delete3.Click += new System.EventHandler(this.Delete3_Click);
            // 
            // UploadWithFileDialog3
            // 
            this.UploadWithFileDialog3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.UploadWithFileDialog3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UploadWithFileDialog3.Location = new System.Drawing.Point(1051, 263);
            this.UploadWithFileDialog3.Name = "UploadWithFileDialog3";
            this.UploadWithFileDialog3.Size = new System.Drawing.Size(112, 30);
            this.UploadWithFileDialog3.TabIndex = 31;
            this.UploadWithFileDialog3.Text = "Upload";
            this.UploadWithFileDialog3.UseVisualStyleBackColor = false;
            this.UploadWithFileDialog3.Click += new System.EventHandler(this.UploadWithFileDialog3_Click);
            // 
            // watchlist_F103ListBox
            // 
            this.watchlist_F103ListBox.AllowDrop = true;
            this.watchlist_F103ListBox.FormattingEnabled = true;
            this.watchlist_F103ListBox.ItemHeight = 17;
            this.watchlist_F103ListBox.Location = new System.Drawing.Point(1018, 133);
            this.watchlist_F103ListBox.Name = "watchlist_F103ListBox";
            this.watchlist_F103ListBox.Size = new System.Drawing.Size(263, 123);
            this.watchlist_F103ListBox.TabIndex = 30;
            this.watchlist_F103ListBox.ValueMember = "reportfilename";
            this.watchlist_F103ListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.Watchlist_F103ListBox_DragDrop);
            this.watchlist_F103ListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.Watchlist_F103ListBox_DragEnter);
            this.watchlist_F103ListBox.DoubleClick += new System.EventHandler(this.Watchlist_F103ListBox_DoubleClick);
            // 
            // FileNameTextBox2
            // 
            this.FileNameTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.FileNameTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileNameTextBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FileNameTextBox2.Location = new System.Drawing.Point(269, 262);
            this.FileNameTextBox2.Name = "FileNameTextBox2";
            this.FileNameTextBox2.Size = new System.Drawing.Size(10, 17);
            this.FileNameTextBox2.TabIndex = 29;
            this.FileNameTextBox2.TabStop = false;
            // 
            // UploadWithFiledialog2
            // 
            this.UploadWithFiledialog2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.UploadWithFiledialog2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UploadWithFiledialog2.Location = new System.Drawing.Point(782, 262);
            this.UploadWithFiledialog2.Name = "UploadWithFiledialog2";
            this.UploadWithFiledialog2.Size = new System.Drawing.Size(112, 30);
            this.UploadWithFiledialog2.TabIndex = 27;
            this.UploadWithFiledialog2.Text = "Upload";
            this.UploadWithFiledialog2.UseVisualStyleBackColor = false;
            this.UploadWithFiledialog2.Click += new System.EventHandler(this.UploadWithFiledialog2_Click);
            // 
            // filenameTextBox1
            // 
            this.filenameTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.filenameTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filenameTextBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.filenameTextBox1.Location = new System.Drawing.Point(101, 283);
            this.filenameTextBox1.Name = "filenameTextBox1";
            this.filenameTextBox1.Size = new System.Drawing.Size(47, 17);
            this.filenameTextBox1.TabIndex = 26;
            this.filenameTextBox1.TabStop = false;
            // 
            // remark2TextBox
            // 
            this.remark2TextBox.Location = new System.Drawing.Point(3, 31);
            this.remark2TextBox.Multiline = true;
            this.remark2TextBox.Name = "remark2TextBox";
            this.remark2TextBox.Size = new System.Drawing.Size(349, 225);
            this.remark2TextBox.TabIndex = 9;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Delete.Location = new System.Drawing.Point(610, 262);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(112, 30);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click_1);
            // 
            // UploadWithFileDialog
            // 
            this.UploadWithFileDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.UploadWithFileDialog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UploadWithFileDialog.Location = new System.Drawing.Point(492, 262);
            this.UploadWithFileDialog.Name = "UploadWithFileDialog";
            this.UploadWithFileDialog.Size = new System.Drawing.Size(112, 30);
            this.UploadWithFileDialog.TabIndex = 7;
            this.UploadWithFileDialog.Text = "Upload";
            this.UploadWithFileDialog.UseVisualStyleBackColor = false;
            this.UploadWithFileDialog.Click += new System.EventHandler(this.UploadWithFileDialog_Click);
            // 
            // Delete2
            // 
            this.Delete2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.Delete2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Delete2.Location = new System.Drawing.Point(900, 262);
            this.Delete2.Name = "Delete2";
            this.Delete2.Size = new System.Drawing.Size(112, 30);
            this.Delete2.TabIndex = 6;
            this.Delete2.Text = "Delete";
            this.Delete2.UseVisualStyleBackColor = false;
            this.Delete2.Click += new System.EventHandler(this.Delete2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(720, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Work Drawing / Documents";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(351, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Files/Message (Drug and Drop to Upload)";
            // 
            // watchlist_dwgListBox
            // 
            this.watchlist_dwgListBox.FormattingEnabled = true;
            this.watchlist_dwgListBox.ItemHeight = 17;
            this.watchlist_dwgListBox.Location = new System.Drawing.Point(726, 31);
            this.watchlist_dwgListBox.Name = "watchlist_dwgListBox";
            this.watchlist_dwgListBox.Size = new System.Drawing.Size(286, 225);
            this.watchlist_dwgListBox.TabIndex = 3;
            this.watchlist_dwgListBox.ValueMember = "Dwgfilename";
            this.watchlist_dwgListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.Watchlist_dwgListBox_DragDrop);
            this.watchlist_dwgListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.Watchlist_dwgListBox_DragEnter);
            this.watchlist_dwgListBox.DoubleClick += new System.EventHandler(this.Watchlist_dwgListBox_DoubleClick);
            // 
            // watchlist_MasterDataGridView
            // 
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            this.watchlist_MasterDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.watchlist_MasterDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.watchlist_MasterDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.watchlist_MasterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.watchlist_MasterDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watchlist_MasterDataGridView.EnableHeadersVisualStyles = false;
            this.watchlist_MasterDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.watchlist_MasterDataGridView.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.watchlist_MasterDataGridView.Location = new System.Drawing.Point(0, 101);
            this.watchlist_MasterDataGridView.Name = "watchlist_MasterDataGridView";
            this.watchlist_MasterDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.watchlist_MasterDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.watchlist_MasterDataGridView.RowHeadersWidth = 80;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.watchlist_MasterDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.watchlist_MasterDataGridView.RowTemplate.Height = 21;
            this.watchlist_MasterDataGridView.Size = new System.Drawing.Size(1318, 611);
            this.watchlist_MasterDataGridView.TabIndex = 4;
            // 
            // reportfilenameListBox
            // 
            this.reportfilenameListBox.FormattingEnabled = true;
            this.reportfilenameListBox.ItemHeight = 17;
            this.reportfilenameListBox.Location = new System.Drawing.Point(1028, 83);
            this.reportfilenameListBox.Name = "reportfilenameListBox";
            this.reportfilenameListBox.Size = new System.Drawing.Size(225, 89);
            this.reportfilenameListBox.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1318, 1032);
            this.Controls.Add(this.watchlist_MasterDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "TroubleAndDefectWatchList";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.Group.ResumeLayout(false);
            this.Group.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watchlist_MasterDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxShipname;
        private System.Windows.Forms.Button buttonShowAllship;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox watchlist_FileListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button SaveAll;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button AddNewItemToTheList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox remark2TextBox;
        private System.Windows.Forms.TextBox filenameTextBox1;
        private System.Windows.Forms.TextBox FileNameTextBox2;
        private System.Windows.Forms.GroupBox Group;
        private System.Windows.Forms.RadioButton InProgressButton;
        private System.Windows.Forms.RadioButton ClosedButton;
        private System.Windows.Forms.RadioButton ALLButton3;
        private System.Windows.Forms.ListBox watchlist_F103ListBox;
        private System.Windows.Forms.TextBox reportfilenameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Delete3;
        private System.Windows.Forms.Button UploadWithFileDialog3;
        private System.Windows.Forms.Button UploadWithFiledialog2;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button UploadWithFileDialog;
        private System.Windows.Forms.Button Delete2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        public System.Windows.Forms.TextBox txtboxUsername;
        public System.Windows.Forms.DataGridView watchlist_MasterDataGridView;
        public System.Windows.Forms.Label timenow;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ListBox watchlist_dwgListBox;
        private System.Windows.Forms.ListBox reportfilenameListBox;
    }
}

