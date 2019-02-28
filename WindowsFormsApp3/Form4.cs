using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form4 : Form
    {
        
        Form1 frm1 = new Form1();

        public string shipname;
        public DateTime month;
        public DateTime pay;
        private Form1 parentF1; //form1で呼び出す変数

        public Form4(Form1 parent)
        {
            InitializeComponent();
        }

        private void dataExchangeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataExchangeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'aZUREDBDataSet.DataExchange' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.dataExchangeTableAdapter.Fill(this.aZUREDBDataSet.DataExchange);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataExchangeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aZUREDBDataSet);

            MessageBox.Show("saved");
            this.Close();
            this.dataExchangeTableAdapter.Fill(this.aZUREDBDataSet.DataExchange);

        }
    }
    
}
