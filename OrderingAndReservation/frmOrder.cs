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
    public partial class frmOrder : Form
    {
        private OleDbConnection conn = new OleDbConnection();
        private OleDbCommand comm = new OleDbCommand();
        

        public double totalValue,totalQuantity;
        public double count350, count500, count1, countCircle, countSquare, countRefill;

        public string allItem, finalItem, b350, b500, b1;

        public frmOrder()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Paully\Documents\Ordering.accdb;
Persist Security Info=False;";
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {

        }

   

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "insert into Price(Price,Quantity) values ('"+Convert.ToString(totalValue)+"','"+Convert.ToString(totalQuantity)+"')";

                comm.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Total Value: " + Convert.ToString(totalValue) +"\nTotal Quantity: " + Convert.ToString(totalQuantity));
                FrmInfo info = new FrmInfo();
                info.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }


            
            
              
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            gbxBottled.Visible = true;
            gbxContainer.Visible = false;
            gbxRefill.Visible = false;
        }

        private void bwHover(object sender, EventArgs e)
        {
            lblBw.ForeColor = Color.Black;
            lblBw.BackColor = Color.Cyan;
        }

        private void bwLeave(object sender, EventArgs e)
        {
            lblBw.ForeColor = Color.White;
            lblBw.BackColor = Color.Transparent;
        }

        private void wcHover(object sender, EventArgs e)
        {
            lblWc.ForeColor = Color.Black;
            lblWc.BackColor = Color.Cyan;
        }

        private void wcLeave(object sender, EventArgs e)
        {
            lblWc.ForeColor = Color.White;
            lblWc.BackColor = Color.Transparent;
        }

        private void reHover(object sender, EventArgs e)
        {
            lblRe.ForeColor = Color.Black;
            lblRe.BackColor = Color.Cyan;
        }

        private void reLeave(object sender, EventArgs e)
        {
            lblRe.ForeColor = Color.White;
            lblRe.BackColor = Color.Transparent;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblWc_Click(object sender, EventArgs e)
        {
            gbxContainer.Visible = true;
            gbxBottled.Visible = false;
            gbxRefill.Visible = false;
        }

        private void btn350_Click_1(object sender, EventArgs e)
        {
            totalValue += 10.00;
            lblTotal.Text = "Total: Php" + Convert.ToString(totalValue);
            count350++;
            lblc350.Text = Convert.ToString(count350);
            totalQuantity += 1;
        }

        private void btn500_Click_1(object sender, EventArgs e)
        {
            totalValue += 15.00;
            lblTotal.Text = "Total: Php" + Convert.ToString(totalValue);
            count500++;
            lblc500.Text = Convert.ToString(count500);
            totalQuantity += 1;
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            totalValue += 18.00;
            lblTotal.Text = "Total: Php" + Convert.ToString(totalValue);
            count1++;
            lblc1.Text = Convert.ToString(count1);
            totalQuantity += 1;

        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            totalValue += 120.00;
            lblTotal.Text = "Total: Php" + Convert.ToString(totalValue);
            countCircle++;
            lblcCircle.Text = Convert.ToString(countCircle);
            totalQuantity += 1;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            totalValue += 160.00;
            lblTotal.Text = "Total: Php" + Convert.ToString(totalValue);
            countSquare++;
            lblcSquare.Text = Convert.ToString(countSquare);
            totalQuantity += 1;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            frmMain fm = new frmMain();
            fm.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            totalValue += 30.00;
            lblTotal.Text = "Total: Php" + Convert.ToString(totalValue);
            countRefill++;
            lblcRefill.Text = Convert.ToString(countRefill);
            totalQuantity += 1;
        }

        private void lblRe_Click(object sender, EventArgs e)
        {
            gbxRefill.Visible = true;
            gbxBottled.Visible = false;
            gbxContainer.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblc1.Text = "0";
            lblc350.Text = "0";
            lblc500.Text = "0";
            lblcSquare.Text = "0";
            lblcCircle.Text = "0";
            lblcRefill.Text = "0";
            lblTotal.Text = "Total: Php0.00";
            totalValue = 0;
        }

        
    }
}
