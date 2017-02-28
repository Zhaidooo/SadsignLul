using System;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace OrderingAndReservation
{
    public partial class FrmInfo : Form
    {
        private MySqlConnection connection;
        private MySqlCommand cmd;
        private MySqlDataReader _dr;

        public string TotalQ;
        public string TotalP;
        public FrmInfo()
        {
            InitializeComponent();
            string myConnectionString = "Server=localhost;Database=ordering;Uid=root;Pwd=;";
            connection = new MySqlConnection(myConnectionString);
            
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
            
            /*try
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
            }*/

            try
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = "select * from itemInfo";

                _dr = cmd.ExecuteReader();
                while (_dr != null && _dr.Read())
                {
                    txtOrder.Text = (_dr["ID"].ToString());
                    txtPrice.Text = (_dr["Price"].ToString());
                    txtQuantity.Text = (_dr["Quantity"].ToString());

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            TotalQ = txtOrder.Text;
            TotalP = txtOrder.Text;
            txtDate.Text = DateTime.Now.ToString();
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
                connection.Open();
                cmd = connection.CreateCommand();
                string id1 = Convert.ToString(txtOrder.Text);
                string name = Convert.ToString(txtName.Text);
                string address = Convert.ToString(txtAddress.Text);
                string contact = Convert.ToString(txtContact.Text);
                string price = TotalP;
                string quantity = TotalQ;
                

                cmd.CommandText = "insert into customerInfo(Name,Address,contact) values('"+name+"','"+address+ "','"+contact+"')";

                
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
            MessageBox.Show("Completed.");
            frmMain fm = new frmMain();
            fm.Show();
            this.Hide();
        }

        private void txtBack_Click(object sender, EventArgs e)
        {
            frmOrder fo = new frmOrder();
            fo.Show();
            this.Hide();
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void Contact_Keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);

        }
    }
    
}
