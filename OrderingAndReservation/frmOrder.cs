using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace OrderingAndReservation
{
    public partial class frmOrder : Form
    {
        private MySqlConnection connection;
        private MySqlCommand cmd;
        

        public double totalValue,totalQuantity;
        public double count350, count500, count1, countCircle, countSquare, countRefill;

        public string allItem, finalItem, b350, b500, b1;

        public frmOrder()
        {
            InitializeComponent();
            string myConnectionString = "Server=localhost;Database=ordering;Uid=root;Pwd=;";
            connection = new MySqlConnection(myConnectionString);
           
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {

        }

   

        private void btnCheck_Click(object sender, EventArgs e)
        {
           

            try
            {

                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = "insert into itemInfo(Price,Quantity,bw350,bw500,bw1,refill,wcSqaure,wcCircle) values ('" + Convert.ToString(totalValue) +
                                  "','" + Convert.ToString(totalQuantity) + "','" + count350 + "','" + count500 + "','" + count1 + "','" + countRefill + "','" + countSquare + "','" + countCircle + "')";
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Total Value: " + Convert.ToString(totalValue) + "\nTotal Quantity: " + Convert.ToString(totalQuantity));
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (count350 == 0)
            {
                MessageBox.Show("Zero Input", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                
            }
            else
            {
                
                count350--;
                lblc350.Text = Convert.ToString(count350);
                
                totalQuantity--;
                totalValue -= 10;
                lblTotal.Text = "Total: Php" + Convert.ToString(totalValue);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (count500 == 0)
            {
                MessageBox.Show("Zero Input", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                
            }
            else
            {
                
                count500--;
                lblc500.Text = Convert.ToString(count500);
             
                totalQuantity--;
                totalValue -= 15;
                lblTotal.Text = "Total: Php" + Convert.ToString(totalValue);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (count1 == 0)
            {
                MessageBox.Show("Zero Input", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                
            }
            else
            {
                
                count1--;
                lblc1.Text = Convert.ToString(count1);
               
                totalQuantity--;
                totalValue -= 18;
                lblTotal.Text = "Total: Php" + Convert.ToString(totalValue);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (countCircle == 0)
            {
                MessageBox.Show("Zero Input", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                
            }
            else
            {
            
                countCircle--;
                lblcCircle.Text = Convert.ToString(countCircle);
             
                totalQuantity--;
                totalValue -= 120;
                lblTotal.Text = "Total: Php" + Convert.ToString(totalValue);
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (countSquare == 0)
            {
                MessageBox.Show("Zero Input", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
               
            }
            else
            {
         
                countSquare--;
                lblcSquare.Text = Convert.ToString(countSquare);
               
                totalQuantity--;
                totalValue -= 160;
                lblTotal.Text = "Total: Php" + Convert.ToString(totalValue);
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (countRefill == 0)
            {
                MessageBox.Show("Zero Input", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
             
            }
            else
            {
            
                countRefill--;
                lblcRefill.Text = Convert.ToString(countRefill);
           
                totalQuantity--;
                totalValue -= 30;
                lblTotal.Text = "Total: Php" + Convert.ToString(totalValue);
            }
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btn350_Click_1(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            totalValue += 10.00;
            lblTotal.Text = "Total: Php" + Convert.ToString(totalValue);
            count350++;
            lblc350.Text = Convert.ToString(count350);
            totalQuantity += 1;
        }

        private void btn500_Click_1(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            totalValue += 15.00;
            lblTotal.Text = "Total: Php" + Convert.ToString(totalValue);
            count500++;
            lblc500.Text = Convert.ToString(count500);
            totalQuantity += 1;
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            totalValue += 18.00;
            lblTotal.Text = "Total: Php" + Convert.ToString(totalValue);
            count1++;
            lblc1.Text = Convert.ToString(count1);
            totalQuantity += 1;

        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            pictureBox8.Visible = true;
            totalValue += 120.00;
            lblTotal.Text = "Total: Php" + Convert.ToString(totalValue);
            countCircle++;
            lblcCircle.Text = Convert.ToString(countCircle);
            totalQuantity += 1;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            pictureBox10.Visible = true;
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
            pictureBox11.Visible = true;
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
