using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrderingAndReservation
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            

        }

        private void Home_Hover(object sender, EventArgs e)
        {
            lblHome.BackColor = Color.Cyan;
            lblHome.ForeColor = Color.White;
            
        }

        private void Home_Leave(object sender, EventArgs e)
        {
            lblHome.BackColor = Color.Transparent;
            lblHome.ForeColor = Color.White;
        }

        private void Order_Hover(object sender, EventArgs e)
        {
            lblOrder.BackColor = Color.Cyan;
            lblOrder.ForeColor = Color.White;    
        }

        private void Order_Leave(object sender, EventArgs e)
        {
            lblOrder.BackColor = Color.Transparent;
            lblOrder.ForeColor = Color.White;
        }

        private void Last_Hover(object sender, EventArgs e)
        {
            lblLast.BackColor = Color.Cyan;
            lblLast.ForeColor = Color.White;
        }

        private void Last_Leave(object sender, EventArgs e)
        {
            lblLast.BackColor = Color.Transparent;
            lblLast.ForeColor = Color.White;
        }

        private void Sales_Hover(object sender, EventArgs e)
        {
            lblSales.BackColor = Color.Cyan;
            lblSales.ForeColor = Color.White;
        }

        private void Sales_Leave(object sender, EventArgs e)
        {
            lblSales.BackColor = Color.Transparent;
            lblSales.ForeColor = Color.White;
        }

        private void Logout_Hover(object sender, EventArgs e)
        {
            lblLogout.BackColor = Color.Cyan;
            lblLogout.ForeColor = Color.White;
        }

        private void Logout_Leave(object sender, EventArgs e)
        {
            
            lblLogout.BackColor = Color.Transparent;
            lblLogout.ForeColor = Color.White;
        }

        private void Info_Hover(object sender, EventArgs e)
        {
            lblInfo.BackColor = Color.Cyan;
            lblInfo.ForeColor = Color.White;
        }

        private void Info_Leave(object sender, EventArgs e)
        {
            lblInfo.BackColor = Color.Transparent;
            lblInfo.ForeColor = Color.White;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Are you sure you want to log out?", "Loging out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dResult == DialogResult.Yes)
            {
                MessageBox.Show("Thank you.");
                Application.Exit();
            }
            else
            {
                
            }
            
        }

        private void lblOrder_Click(object sender, EventArgs e)
        {
            frmOrder or = new frmOrder();
            or.Show();
            this.Hide();
        }

        private void lblLast_Click(object sender, EventArgs e)
        {
            lastOrdered lo = new lastOrdered();
            lo.Show();
            this.Hide();
        }

        private void lblSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportSales rs = new ReportSales();
            rs.Show();
        }
    }
}
