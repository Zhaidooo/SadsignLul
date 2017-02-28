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
    public partial class ReportSales : Form
    {
        private static MySqlConnection connection;
        private static MySqlCommand cmd;
        private static MySqlDataReader _dr;
        private static MySqlDataAdapter adap;
        private static DataTable ds;
        private static MySqlDataReader dr;

        private int checkerMonthly,checkerYearly;
        public ReportSales()
        {
            InitializeComponent();
            string myConnectionString = "Server=localhost;Database=ordering;Uid=root;Pwd=;";
            connection = new MySqlConnection(myConnectionString);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkerMonthly != 1)
            {
                chart1.BringToFront();
                try
                {
                    checkerMonthly = 1;
                    connection.Open();
                    cmd = new MySqlCommand("select * from MonthlySale;", connection);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        //var timetime = Convert.ToDateTime(dr["Monthly"]).ToString("MMMM");
                        this.chart1.Series["Bottle Water 350mL"].Points.AddXY(dr.GetString("Monthly"),
                            dr.GetDecimal("sc350"));
                        this.chart1.Series["Bottle Water 500mL"].Points.AddXY(dr.GetString("Monthly"),
                            dr.GetDecimal("sc500"));
                        this.chart1.Series["Bottle Water 1L"].Points.AddXY(dr.GetString("Monthly"),
                            dr.GetDecimal("sc1"));
                        this.chart1.Series["Water Container Square"].Points.AddXY(dr.GetString("Monthly"),
                            dr.GetDecimal("scs"));
                        this.chart1.Series["Water Container Circle"].Points.AddXY(dr.GetString("Monthly"),
                            dr.GetDecimal("scc"));
                        this.chart1.Series["Refilled Water"].Points.AddXY(dr.GetString("Monthly"),
                            dr.GetDecimal("scr"));
                    }
                    connection.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }
            }
            else
            {
                chart1.BringToFront();
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void ReportSales_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Hide();
        }

        private void btnYearly_Click(object sender, EventArgs e)
        {
            if (checkerYearly != 2)
            {
                chart2.BringToFront();
                try
                {
                    checkerYearly = 2;
                    connection.Open();
                    cmd =
                        new MySqlCommand("select YEAR(Date) as Yearly,SUM(tSale350) as sc350,SUM(tSales500) as sc500," +
                                         "SUM(tSales1) as sc1,SUM(tSalesR) as scr, SUM(tsalesC) as scc,SUM(tSalesS) " +
                                         "as scs,SUM(Quantity) as totalQ,SUM(Price) as totalP from totalsalesreport" +
                                         " group by YEAR(Date) order by 1,2;", connection);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        //var timetime = Convert.ToDateTime(dr["Monthly"]).ToString("MMMM");
                        this.chart2.Series["Bottle Water 350mL"].Points.AddXY(dr.GetString("Yearly"),
                            dr.GetDecimal("sc350"));
                        this.chart2.Series["Bottle Water 500mL"].Points.AddXY(dr.GetString("Yearly"),
                            dr.GetDecimal("sc500"));
                        this.chart2.Series["Bottle Water 1L"].Points.AddXY(dr.GetString("Yearly"),
                            dr.GetDecimal("sc1"));
                        this.chart2.Series["Water Container Square"].Points.AddXY(dr.GetString("Yearly"),
                            dr.GetDecimal("scs"));
                        this.chart2.Series["Water Container Circle"].Points.AddXY(dr.GetString("Yearly"),
                            dr.GetDecimal("scc"));
                        this.chart2.Series["Refilled Water"].Points.AddXY(dr.GetString("Yearly"),
                            dr.GetDecimal("scr"));
                    }
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }
            }
            else
            {
                chart2.BringToFront();
            }
        }
    }
}
