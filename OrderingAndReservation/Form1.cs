using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OrderingAndReservation
{
    public partial class frmLogin : Form
    {
        private OleDbConnection conn = new OleDbConnection();
        private OleDbCommand comm = new OleDbCommand();
        private OleDbDataReader dr;

        public frmLogin()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Paully\Documents\Login.accdb;
Persist Security Info=False;";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "select *  from username where Username='"+txtLogin.Text+"' and Password='"+txtPassword.Text+"'";
                
                dr = comm.ExecuteReader();

                int count = 0;
                while (dr.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    MessageBox.Show("Username and Password is Correct","Log in",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    frmMain fm = new frmMain();
                    fm.Show();
                    this.Hide();
  
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username and Password is Correct","Log in",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Incorrect Username and Password","Log in",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you!", "Closing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }


        
    }
}
