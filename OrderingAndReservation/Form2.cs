using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OrderingAndReservation
{
    public partial class FrmInfo : Form
    {
        private OleDbConnection conn = new OleDbConnection();
        private OleDbCommand comm = new OleDbCommand();
        private OleDbDataReader _dr;

        public string TotalQ;
        public string TotalP;
        public FrmInfo()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Paully\Documents\Ordering.accdb;
Persist Security Info=False;";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddress.Clear();
            txtContact.Clear();
            txtName.Clear();
            txtOrder.Clear();
            
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {
            
            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "select * from Price";
               
                _dr = comm.ExecuteReader();
                while (_dr != null && _dr.Read())
                {
                    txtOrder.Text = (_dr["ID"].ToString());
                    txtPrice.Text = (_dr["Price"].ToString());
                    txtQuantity.Text = (_dr["Quantity"].ToString());
                    
                }
                conn.Close();

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex);
            }
            TotalQ = txtOrder.Text;
            TotalP = txtOrder.Text;
            txtDate.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            /* 
             try
             {
                 conn.Open();
                 comm.Connection = conn;
                 comm.CommandText = "insert into Info(IDPrice,Name,Address,Contact,Price,Quantity,Date) values ('" + 
                     Convert.ToString(txtOrder.Text) + "','" + Convert.ToString(txtName.Text) + "','" + 
                     Convert.ToString(txtAddress.Text) + "','" + Convert.ToString(txtContact.Text) + "','" + 
                     Convert.ToString(txtPrice.Text) + "','" + Convert.ToString(txtQuantity.Text) + "''" + 
                     Convert.ToString(txtDate.Text) + "')";
 
                 comm.ExecuteNonQuery();
                 conn.Close();
 
                
             }
             catch (Exception ex)
             {
                 MessageBox.Show(@"Error: " + ex);
             }*/
            try
            {
                conn.Open();
                comm.Connection = conn;
                string id1 = Convert.ToString(txtOrder.Text);
                string name = Convert.ToString(txtName.Text);
                string address = Convert.ToString(txtAddress.Text);
                string contact = Convert.ToString(txtContact.Text);
                string price = TotalP;
                string quantity = TotalQ;
                string date = DateTime.Now.ToString("M/d/yyyy");

                comm.CommandText = "insert into Info(IDPrice,Name,Address,Contact,Price2,Quantity2) values('"+id1+"','"+name+"','"+address+ "','"+contact+"','"+price+"','"+quantity+"')";

                
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }

        }

    }
    
}
