namespace WindowsFormsApp3
{
    partial class Form4
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label amountUSDLabel;
            System.Windows.Forms.Label amountJPYLabel;
            System.Windows.Forms.Label exchangerateLabel;
            System.Windows.Forms.Label grandTotalUSDLabel;
            System.Windows.Forms.Label paymentDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.aZUREDBDataSet = new WindowsFormsApp3.AZUREDBDataSet();
            this.dataExchangeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataExchangeTableAdapter = new WindowsFormsApp3.AZUREDBDataSetTableAdapters.DataExchangeTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.AZUREDBDataSetTableAdapters.TableAdapterManager();
            this.dataExchangeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataExchangeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.amountUSDTextBox = new System.Windows.Forms.TextBox();
            this.amountJPYTextBox = new System.Windows.Forms.TextBox();
            this.exchangerateTextBox = new System.Windows.Forms.TextBox();
            this.grandTotalUSDTextBox = new System.Windows.Forms.TextBox();
            this.paymentDateTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            descriptionLabel = new System.Windows.Forms.Label();
            amountUSDLabel = new System.Windows.Forms.Label();
            amountJPYLabel = new System.Windows.Forms.Label();
            exchangerateLabel = new System.Windows.Forms.Label();
            grandTotalUSDLabel = new System.Windows.Forms.Label();
            paymentDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchangeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchangeBindingNavigator)).BeginInit();
            this.dataExchangeBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(45, 73);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(78, 18);
            descriptionLabel.TabIndex = 9;
            descriptionLabel.Text = "Description:";
            // 
            // amountUSDLabel
            // 
            amountUSDLabel.AutoSize = true;
            amountUSDLabel.Location = new System.Drawing.Point(45, 111);
            amountUSDLabel.Name = "amountUSDLabel";
            amountUSDLabel.Size = new System.Drawing.Size(89, 18);
            amountUSDLabel.TabIndex = 11;
            amountUSDLabel.Text = "Amount USD:";
            // 
            // amountJPYLabel
            // 
            amountJPYLabel.AutoSize = true;
            amountJPYLabel.Location = new System.Drawing.Point(45, 149);
            amountJPYLabel.Name = "amountJPYLabel";
            amountJPYLabel.Size = new System.Drawing.Size(82, 18);
            amountJPYLabel.TabIndex = 13;
            amountJPYLabel.Text = "Amount JPY:";
            // 
            // exchangerateLabel
            // 
            exchangerateLabel.AutoSize = true;
            exchangerateLabel.Location = new System.Drawing.Point(45, 186);
            exchangerateLabel.Name = "exchangerateLabel";
            exchangerateLabel.Size = new System.Drawing.Size(92, 18);
            exchangerateLabel.TabIndex = 15;
            exchangerateLabel.Text = "exchangerate:";
            // 
            // grandTotalUSDLabel
            // 
            grandTotalUSDLabel.AutoSize = true;
            grandTotalUSDLabel.Location = new System.Drawing.Point(45, 223);
            grandTotalUSDLabel.Name = "grandTotalUSDLabel";
            grandTotalUSDLabel.Size = new System.Drawing.Size(111, 18);
            grandTotalUSDLabel.TabIndex = 17;
            grandTotalUSDLabel.Text = "Grand Total USD:";
            // 
            // paymentDateLabel
            // 
            paymentDateLabel.AutoSize = true;
            paymentDateLabel.Location = new System.Drawing.Point(45, 261);
            paymentDateLabel.Name = "paymentDateLabel";
            paymentDateLabel.Size = new System.Drawing.Size(97, 18);
            paymentDateLabel.TabIndex = 19;
            paymentDateLabel.Text = "Payment Date:";
            // 
            // aZUREDBDataSet
            // 
            this.aZUREDBDataSet.DataSetName = "AZUREDBDataSet";
            this.aZUREDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataExchangeBindingSource
            // 
            this.dataExchangeBindingSource.DataMember = "DataExchange";
            this.dataExchangeBindingSource.DataSource = this.aZUREDBDataSet;
            // 
            // dataExchangeTableAdapter
            // 
            this.dataExchangeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DataExchange_feeTableAdapter = null;
            this.tableAdapterManager.DataExchangeTableAdapter = this.dataExchangeTableAdapter;
            this.tableAdapterManager.Ship_Master_TBTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3.AZUREDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataExchangeBindingNavigator
            // 
            this.dataExchangeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dataExchangeBindingNavigator.BindingSource = this.dataExchangeBindingSource;
            this.dataExchangeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dataExchangeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dataExchangeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.dataExchangeBindingNavigatorSaveItem});
            this.dataExchangeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dataExchangeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dataExchangeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dataExchangeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dataExchangeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dataExchangeBindingNavigator.Name = "dataExchangeBindingNavigator";
            this.dataExchangeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dataExchangeBindingNavigator.Size = new System.Drawing.Size(453, 25);
            this.dataExchangeBindingNavigator.TabIndex = 0;
            this.dataExchangeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新規追加";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目の総数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "削除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "最初に移動";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "前に戻る";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 25);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "現在の場所";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "次に移動";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "最後に移動";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dataExchangeBindingNavigatorSaveItem
            // 
            this.dataExchangeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dataExchangeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dataExchangeBindingNavigatorSaveItem.Image")));
            this.dataExchangeBindingNavigatorSaveItem.Name = "dataExchangeBindingNavigatorSaveItem";
            this.dataExchangeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dataExchangeBindingNavigatorSaveItem.Text = "データの保存";
            this.dataExchangeBindingNavigatorSaveItem.Click += new System.EventHandler(this.dataExchangeBindingNavigatorSaveItem_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchangeBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(164, 69);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(233, 25);
            this.descriptionTextBox.TabIndex = 10;
            // 
            // amountUSDTextBox
            // 
            this.amountUSDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchangeBindingSource, "AmountUSD", true));
            this.amountUSDTextBox.Location = new System.Drawing.Point(164, 107);
            this.amountUSDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.amountUSDTextBox.Name = "amountUSDTextBox";
            this.amountUSDTextBox.Size = new System.Drawing.Size(233, 25);
            this.amountUSDTextBox.TabIndex = 12;
            // 
            // amountJPYTextBox
            // 
            this.amountJPYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchangeBindingSource, "AmountJPY", true));
            this.amountJPYTextBox.Location = new System.Drawing.Point(164, 144);
            this.amountJPYTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.amountJPYTextBox.Name = "amountJPYTextBox";
            this.amountJPYTextBox.Size = new System.Drawing.Size(233, 25);
            this.amountJPYTextBox.TabIndex = 14;
            // 
            // exchangerateTextBox
            // 
            this.exchangerateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchangeBindingSource, "exchangerate", true));
            this.exchangerateTextBox.Location = new System.Drawing.Point(164, 181);
            this.exchangerateTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exchangerateTextBox.Name = "exchangerateTextBox";
            this.exchangerateTextBox.Size = new System.Drawing.Size(233, 25);
            this.exchangerateTextBox.TabIndex = 16;
            // 
            // grandTotalUSDTextBox
            // 
            this.grandTotalUSDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchangeBindingSource, "GrandTotalUSD", true));
            this.grandTotalUSDTextBox.Location = new System.Drawing.Point(164, 219);
            this.grandTotalUSDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grandTotalUSDTextBox.Name = "grandTotalUSDTextBox";
            this.grandTotalUSDTextBox.Size = new System.Drawing.Size(233, 25);
            this.grandTotalUSDTextBox.TabIndex = 18;
            // 
            // paymentDateTextBox
            // 
            this.paymentDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataExchangeBindingSource, "PaymentDate", true));
            this.paymentDateTextBox.Location = new System.Drawing.Point(164, 257);
            this.paymentDateTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.paymentDateTextBox.Name = "paymentDateTextBox";
            this.paymentDateTextBox.Size = new System.Drawing.Size(233, 25);
            this.paymentDateTextBox.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 321);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 82);
            this.button1.TabIndex = 21;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 516);
            this.Controls.Add(this.button1);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(amountUSDLabel);
            this.Controls.Add(this.amountUSDTextBox);
            this.Controls.Add(amountJPYLabel);
            this.Controls.Add(this.amountJPYTextBox);
            this.Controls.Add(exchangerateLabel);
            this.Controls.Add(this.exchangerateTextBox);
            this.Controls.Add(grandTotalUSDLabel);
            this.Controls.Add(this.grandTotalUSDTextBox);
            this.Controls.Add(paymentDateLabel);
            this.Controls.Add(this.paymentDateTextBox);
            this.Controls.Add(this.dataExchangeBindingNavigator);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aZUREDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchangeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExchangeBindingNavigator)).EndInit();
            this.dataExchangeBindingNavigator.ResumeLayout(false);
            this.dataExchangeBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AZUREDBDataSet aZUREDBDataSet;
        private System.Windows.Forms.BindingSource dataExchangeBindingSource;
        private AZUREDBDataSetTableAdapters.DataExchangeTableAdapter dataExchangeTableAdapter;
        private AZUREDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dataExchangeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton dataExchangeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox amountUSDTextBox;
        private System.Windows.Forms.TextBox amountJPYTextBox;
        private System.Windows.Forms.TextBox exchangerateTextBox;
        private System.Windows.Forms.TextBox grandTotalUSDTextBox;
        private System.Windows.Forms.TextBox paymentDateTextBox;
        private System.Windows.Forms.Button button1;
    }
}