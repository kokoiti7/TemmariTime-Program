using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnicalWatchlist
{
    public partial class NewItem : Form
    {
        Form1 frm1 = new Form1();
        public string shipname;
        public int namelen =0;
        public string names;
        DateTime now;

        public NewItem()
        {
            InitializeComponent();
           
        }

        private void Watchlist_MasterBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.watchlist_MasterBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

        }

        private void NewItem_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.Ship_Master_TB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.ship_Master_TBTableAdapter.Fill(this.aZUREDBDataSet.Ship_Master_TB);
            // TODO: このコード行はデータを 'aZUREDBDataSet.Watchlist_Master' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.watchlist_MasterTableAdapter.Fill(this.aZUREDBDataSet.Watchlist_Master);
            this.watchlist_MasterBindingSource.AddNew();
            shipNameComboBox.Text = shipname;
            dateComDateTimePicker.Text = DateTime.Today.ToString();
            shipIDTextBox.Text = shipNameComboBox.SelectedValue.ToString();
        }

        private void SaveAndClose_Click(object sender, EventArgs e)
        {
  
            bitspareCheckBox.Checked = false;
            bitspareTextBox.Text = "false";

            if (priolityComboBox.Text.Length == 0 || kindComboBox.Text.Length == 0|| machineryComboBox.Text.Length == 0 || subjectTextBox.Text.Length == 0 )
            {
                MessageBox.Show("文字列を入力してください");
                return;
            }


            remarkTextBox.Text=names + " " + DateTime.Now.ToString("G");


            this.Validate();
            this.watchlist_MasterBindingSource.EndEdit();
            this.watchlist_MasterTableAdapter.Update(this.aZUREDBDataSet.Watchlist_Master);
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);
            this.DialogResult = DialogResult.OK;
            this.Close();
          
        }

        private void ShipNameComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            shipIDTextBox.Text = shipNameComboBox.SelectedValue.ToString();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
