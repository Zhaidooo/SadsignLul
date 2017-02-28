using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OrderingAndReservation
{
    public partial class lastOrdered : Form
    {
        private MySqlConnection connection;
        private MySqlCommand cmd;
        private MySqlDataReader _dr;
        private MySqlDataAdapter adap;
        private DataTable ds;
        public lastOrdered()
        {
            InitializeComponent();
            string myConnectionString = "Server=localhost;Database=ordering;Uid=root;Pwd=;";
            connection = new MySqlConnection(myConnectionString);
        }

        private void lastOrdered_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = "select * from lastOrdered";
                adap = new MySqlDataAdapter(cmd);
                ds = new DataTable();
                adap.Fill(ds);

                dataGridView1.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
            dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Descending);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Hide();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(ds);
            dv.RowFilter = string.Format("Name LIKE '%{0}%'", txtName.Text);
            dataGridView1.DataSource = dv;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           //.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", Name, txtName.Text);
        }
    }
}
