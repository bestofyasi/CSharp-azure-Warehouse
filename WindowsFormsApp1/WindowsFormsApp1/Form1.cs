using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DBAccess dba = new DBAccess();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
        public void FillGrid()
        {
            DataSet ds = dba.getAllItems();
            dataGridView1.DataSource = ds.Tables["itpItems"].DefaultView;
        }

        private void btnInstert_Click(object sender, EventArgs e)
        {
            dba.addItems((txtName.Text).ToString(),Convert.ToInt32(txtQty.Text));
            FillGrid();

        }
    }
}
