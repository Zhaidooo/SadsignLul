namespace OrderingAndReservation
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Controls.Add(this.lblLogout);
            this.panel1.Controls.Add(this.lblSales);
            this.panel1.Controls.Add(this.lblLast);
            this.panel1.Controls.Add(this.lblOrder);
            this.panel1.Controls.Add(this.lblHome);
            this.panel1.Location = new System.Drawing.Point(38, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 485);
            this.panel1.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblInfo.Location = new System.Drawing.Point(-2, 210);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(238, 42);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Info";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblInfo.MouseLeave += new System.EventHandler(this.Info_Leave);
            this.lblInfo.MouseHover += new System.EventHandler(this.Info_Hover);
            // 
            // lblLogout
            // 
            this.lblLogout.BackColor = System.Drawing.Color.Transparent;
            this.lblLogout.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLogout.Location = new System.Drawing.Point(-2, 168);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(238, 42);
            this.lblLogout.TabIndex = 4;
            this.lblLogout.Text = "Logout";
            this.lblLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            this.lblLogout.MouseLeave += new System.EventHandler(this.Logout_Leave);
            this.lblLogout.MouseHover += new System.EventHandler(this.Logout_Hover);
            // 
            // lblSales
            // 
            this.lblSales.BackColor = System.Drawing.Color.Transparent;
            this.lblSales.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSales.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSales.Location = new System.Drawing.Point(-2, 126);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(238, 42);
            this.lblSales.TabIndex = 3;
            this.lblSales.Text = "Sales";
            this.lblSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSales.Click += new System.EventHandler(this.lblSales_Click);
            this.lblSales.MouseLeave += new System.EventHandler(this.Sales_Leave);
            this.lblSales.MouseHover += new System.EventHandler(this.Sales_Hover);
            // 
            // lblLast
            // 
            this.lblLast.BackColor = System.Drawing.Color.Transparent;
            this.lblLast.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLast.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLast.Location = new System.Drawing.Point(-2, 84);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(238, 42);
            this.lblLast.TabIndex = 2;
            this.lblLast.Text = "Last Ordered";
            this.lblLast.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLast.Click += new System.EventHandler(this.lblLast_Click);
            this.lblLast.MouseLeave += new System.EventHandler(this.Last_Leave);
            this.lblLast.MouseHover += new System.EventHandler(this.Last_Hover);
            // 
            // lblOrder
            // 
            this.lblOrder.BackColor = System.Drawing.Color.Transparent;
            this.lblOrder.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblOrder.Location = new System.Drawing.Point(-2, 42);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(238, 42);
            this.lblOrder.TabIndex = 1;
            this.lblOrder.Text = "Order Now";
            this.lblOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOrder.Click += new System.EventHandler(this.lblOrder_Click);
            this.lblOrder.MouseLeave += new System.EventHandler(this.Order_Leave);
            this.lblOrder.MouseHover += new System.EventHandler(this.Order_Hover);
            // 
            // lblHome
            // 
            this.lblHome.BackColor = System.Drawing.Color.Transparent;
            this.lblHome.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHome.Location = new System.Drawing.Point(-2, 0);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(238, 42);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Home";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHome.MouseLeave += new System.EventHandler(this.Home_Leave);
            this.lblHome.MouseHover += new System.EventHandler(this.Home_Hover);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(282, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 593);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(598, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 84);
            this.label3.TabIndex = 2;
            this.label3.Text = "0907-4852-132\r\n0915-2412-662";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(13, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 117);
            this.label2.TabIndex = 1;
            this.label2.Text = "51 Countryside Ave.,\r\nCountryside Village\r\nPasig City";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(41, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 102);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(44, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "MENU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1212, 671);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CountrySide Water Station";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}