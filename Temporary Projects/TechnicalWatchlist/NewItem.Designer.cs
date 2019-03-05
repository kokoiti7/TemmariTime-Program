namespace TechnicalWatchlist
{
    partial class NewItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label priolityLabel;
            System.Windows.Forms.Label kindLabel;
            System.Windows.Forms.Label machineryLabel;
            System.Windows.Forms.Label subjectLabel;
            System.Windows.Forms.Label dateComLabel;
            System.Windows.Forms.Label shipNameLabel1;
            this.aZUREDBDataSet = new TechnicalWatchlist.AZUREDBDataSet();
            this.watchlist_MasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.watchlist_MasterTableAdapter = new TechnicalWatchlist.AZUREDBDataSetTableAdapters.Watchlist_MasterTableAdapter();
            this.tableAdapterManager = new TechnicalWatchlist.AZUREDBDataSetTableAdapters.TableAdapterManager();
            this.ship_Master_TBTableAdapter = new TechnicalWatchlist.AZUREDBDataSetTableAdapters.Ship_Master_TBTableAdapter();
            this.listIDTextBox = new System.Windows.Forms.TextBox();
            this.priolityComboBox = new System.Windows.Forms.ComboBox();
            this.shipIDTextBox = new System.Windows.Forms.TextBox();
            this.kindComboBox = new System.Windows.Forms.ComboBox();
            this.machineryComboBox = new System.Windows.Forms.ComboBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.dateComDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SaveAndClose = new System.Windows.Forms.Button();
            this.shipNameComboBox = new System.Windows.Forms.ComboBox();
            this.shipMasterTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Cancel = new System.Windows.Forms.Button();
            priolityLabel = new System.Windows.Forms.Label();
            kindLabel = new System.Windows.Forms.Label();
            machineryLabel = new System.Windows.Forms.Label();
            subjectLabel = new System.Windows.Forms.Label();
            dateComLabel = new System.Windows.Forms.Label();
            shipNameLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchlist_MasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipMasterTBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // priolityLabel
            // 
            priolityLabel.AutoSize = true;
            priolityLabel.Location = new System.Drawing.Point(15, 76);
            priolityLabel.Name = "priolityLabel";
            priolityLabel.Size = new System.Drawing.Size(56, 17);
            priolityLabel.TabIndex = 3;
            priolityLabel.Text = "Priolity:";
            // 
            // kindLabel
            // 
            kindLabel.AutoSize = true;
            kindLabel.Location = new System.Drawing.Point(15, 109);
            kindLabel.Name = "kindLabel";
            kindLabel.Size = new System.Drawing.Size(42, 17);
            kindLabel.TabIndex = 9;
            kindLabel.Text = "Kind:";
            // 
            // machineryLabel
            // 
            machineryLabel.AutoSize = true;
            machineryLabel.Location = new System.Drawing.Point(15, 145);
            machineryLabel.Name = "machineryLabel";
            machineryLabel.Size = new System.Drawing.Size(79, 17);
            machineryLabel.TabIndex = 11;
            machineryLabel.Text = "Machinery:";
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.Location = new System.Drawing.Point(15, 183);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new System.Drawing.Size(62, 17);
            subjectLabel.TabIndex = 13;
            subjectLabel.Text = "Subject:";
            // 
            // dateComLabel
            // 
            dateComLabel.AutoSize = true;
            dateComLabel.Location = new System.Drawing.Point(15, 219);
            dateComLabel.Name = "dateComLabel";
            dateComLabel.Size = new System.Drawing.Size(78, 17);
            dateComLabel.TabIndex = 15;
            dateComLabel.Text = "Date Com:";
            // 
            // shipNameLabel1
            // 
            shipNameLabel1.AutoSize = true;
            shipNameLabel1.Location = new System.Drawing.Point(15, 41);
            shipNameLabel1.Name = "shipNameLabel1";
            shipNameLabel1.Size = new System.Drawing.Size(83, 17);
            shipNameLabel1.TabIndex = 18;
            shipNameLabel1.Text = "Ship Name:";
            // 
            // aZUREDBDataSet
            // 
            this.aZUREDBDataSet.DataSetName = "AZUREDBDataSet";
            this.aZUREDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Ship_Master_TBTableAdapter = this.ship_Master_TBTableAdapter;
            this.tableAdapterManager.UpdateOrder = TechnicalWatchlist.AZUREDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Watchlist_dwgTableAdapter = null;
            this.tableAdapterManager.Watchlist_FileTableAdapter = null;
            this.tableAdapterManager.Watchlist_MasterTableAdapter = this.watchlist_MasterTableAdapter;
            // 
            // ship_Master_TBTableAdapter
            // 
            this.ship_Master_TBTableAdapter.ClearBeforeFill = true;
            // 
            // listIDTextBox
            // 
            this.listIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.watchlist_MasterBindingSource, "ListID", true));
            this.listIDTextBox.Location = new System.Drawing.Point(244, 272);
            this.listIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listIDTextBox.Name = "listIDTextBox";
            this.listIDTextBox.Size = new System.Drawing.Size(43, 24);
            this.listIDTextBox.TabIndex = 2;
            // 
            // priolityComboBox
            // 
            this.priolityComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.watchlist_MasterBindingSource, "Priolity", true));
            this.priolityComboBox.FormattingEnabled = true;
            this.priolityComboBox.Items.AddRange(new object[] {
            "Top priority",
            "High",
            "Normal",
            "Low"});
            this.priolityComboBox.Location = new System.Drawing.Point(117, 71);
            this.priolityComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.priolityComboBox.Name = "priolityComboBox";
            this.priolityComboBox.Size = new System.Drawing.Size(165, 25);
            this.priolityComboBox.TabIndex = 2;
            // 
            // shipIDTextBox
            // 
            this.shipIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.watchlist_MasterBindingSource, "ShipID", true));
            this.shipIDTextBox.Location = new System.Drawing.Point(197, 271);
            this.shipIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.shipIDTextBox.Name = "shipIDTextBox";
            this.shipIDTextBox.Size = new System.Drawing.Size(87, 24);
            this.shipIDTextBox.TabIndex = 6;
            // 
            // kindComboBox
            // 
            this.kindComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.watchlist_MasterBindingSource, "Kind", true));
            this.kindComboBox.FormattingEnabled = true;
            this.kindComboBox.Items.AddRange(new object[] {
            "F103-5",
            "OtherTrouble",
            "Inspection"});
            this.kindComboBox.Location = new System.Drawing.Point(117, 104);
            this.kindComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kindComboBox.Name = "kindComboBox";
            this.kindComboBox.Size = new System.Drawing.Size(165, 25);
            this.kindComboBox.TabIndex = 10;
            // 
            // machineryComboBox
            // 
            this.machineryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.watchlist_MasterBindingSource, "Machinery", true));
            this.machineryComboBox.FormattingEnabled = true;
            this.machineryComboBox.Items.AddRange(new object[] {
            "M/E",
            "G/E",
            "A/B",
            "Aux Machines",
            "Heat Exchanger",
            "Piping System",
            "Instrument",
            "Navigation Equipment"});
            this.machineryComboBox.Location = new System.Drawing.Point(117, 141);
            this.machineryComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.machineryComboBox.Name = "machineryComboBox";
            this.machineryComboBox.Size = new System.Drawing.Size(266, 25);
            this.machineryComboBox.TabIndex = 12;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.watchlist_MasterBindingSource, "Subject", true));
            this.subjectTextBox.Location = new System.Drawing.Point(117, 178);
            this.subjectTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(266, 24);
            this.subjectTextBox.TabIndex = 14;
            // 
            // dateComDateTimePicker
            // 
            this.dateComDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.dateComDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.watchlist_MasterBindingSource, "DateCom", true));
            this.dateComDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateComDateTimePicker.Location = new System.Drawing.Point(117, 213);
            this.dateComDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateComDateTimePicker.Name = "dateComDateTimePicker";
            this.dateComDateTimePicker.Size = new System.Drawing.Size(165, 24);
            this.dateComDateTimePicker.TabIndex = 16;
            // 
            // SaveAndClose
            // 
            this.SaveAndClose.Location = new System.Drawing.Point(119, 271);
            this.SaveAndClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveAndClose.Name = "SaveAndClose";
            this.SaveAndClose.Size = new System.Drawing.Size(168, 34);
            this.SaveAndClose.TabIndex = 17;
            this.SaveAndClose.Text = "SaveAndClose";
            this.SaveAndClose.UseVisualStyleBackColor = true;
            this.SaveAndClose.Click += new System.EventHandler(this.SaveAndClose_Click);
            // 
            // shipNameComboBox
            // 
            this.shipNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.watchlist_MasterBindingSource, "ShipName", true));
            this.shipNameComboBox.DataSource = this.shipMasterTBBindingSource;
            this.shipNameComboBox.DisplayMember = "PresentName";
            this.shipNameComboBox.FormattingEnabled = true;
            this.shipNameComboBox.Location = new System.Drawing.Point(117, 38);
            this.shipNameComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.shipNameComboBox.Name = "shipNameComboBox";
            this.shipNameComboBox.Size = new System.Drawing.Size(266, 25);
            this.shipNameComboBox.TabIndex = 1;
            this.shipNameComboBox.ValueMember = "ID";
            this.shipNameComboBox.SelectedIndexChanged += new System.EventHandler(this.ShipNameComboBox_SelectedIndexChanged);
            this.shipNameComboBox.SelectionChangeCommitted += new System.EventHandler(this.ShipNameComboBox_SelectionChangeCommitted);
            // 
            // shipMasterTBBindingSource
            // 
            this.shipMasterTBBindingSource.DataMember = "Ship_Master_TB";
            this.shipMasterTBBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(119, 313);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(168, 34);
            this.Cancel.TabIndex = 20;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // NewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 381);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(shipNameLabel1);
            this.Controls.Add(this.shipNameComboBox);
            this.Controls.Add(this.SaveAndClose);
            this.Controls.Add(this.listIDTextBox);
            this.Controls.Add(priolityLabel);
            this.Controls.Add(this.priolityComboBox);
            this.Controls.Add(this.shipIDTextBox);
            this.Controls.Add(kindLabel);
            this.Controls.Add(this.kindComboBox);
            this.Controls.Add(machineryLabel);
            this.Controls.Add(this.machineryComboBox);
            this.Controls.Add(subjectLabel);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(dateComLabel);
            this.Controls.Add(this.dateComDateTimePicker);
            this.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewItem";
            this.Text = "NewItem";
            this.Load += new System.EventHandler(this.NewItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchlist_MasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipMasterTBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AZUREDBDataSet aZUREDBDataSet;
        private System.Windows.Forms.BindingSource watchlist_MasterBindingSource;
        private AZUREDBDataSetTableAdapters.Watchlist_MasterTableAdapter watchlist_MasterTableAdapter;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox listIDTextBox;
        private System.Windows.Forms.ComboBox priolityComboBox;
        private System.Windows.Forms.TextBox shipIDTextBox;
        private System.Windows.Forms.ComboBox kindComboBox;
        private System.Windows.Forms.ComboBox machineryComboBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.DateTimePicker dateComDateTimePicker;
        private System.Windows.Forms.Button SaveAndClose;
        private AZUREDBDataSetTableAdapters.Ship_Master_TBTableAdapter ship_Master_TBTableAdapter;
        private System.Windows.Forms.ComboBox shipNameComboBox;
        private System.Windows.Forms.BindingSource shipMasterTBBindingSource;
        private System.Windows.Forms.Button Cancel;
    }
}