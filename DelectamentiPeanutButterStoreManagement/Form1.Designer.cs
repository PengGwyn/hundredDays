namespace DelectamentiPeanutButterStoreManagement
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Hello");
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.connectBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.branchName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CurrentMonthSale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YearlySales = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderPerMonth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.branchManager = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(145)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 448);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(145)))), ((int)(((byte)(71)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(75)))), ((int)(((byte)(22)))));
            this.label1.Location = new System.Drawing.Point(113, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(674, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peanut Butter\'s Point Of Sale";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(171)))), ((int)(((byte)(99)))));
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.connectBtn);
            this.panel2.Location = new System.Drawing.Point(22, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(751, 302);
            this.panel2.TabIndex = 2;
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(326, 124);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(107, 48);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "Connect to Database";
            this.connectBtn.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(171)))), ((int)(((byte)(99)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.branchName,
            this.CurrentMonthSale,
            this.YearlySales,
            this.orderPerMonth,
            this.branchManager});
            this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(41)))), ((int)(((byte)(0)))));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            listViewItem1.IndentCount = 1;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(11, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(728, 272);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.OpenSelectedBranch);
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 50;
            // 
            // branchName
            // 
            this.branchName.Text = "Branch";
            this.branchName.Width = 98;
            // 
            // CurrentMonthSale
            // 
            this.CurrentMonthSale.DisplayIndex = 3;
            this.CurrentMonthSale.Text = "Monthly Sales";
            this.CurrentMonthSale.Width = 126;
            // 
            // YearlySales
            // 
            this.YearlySales.DisplayIndex = 4;
            this.YearlySales.Text = "Yearly Sales";
            this.YearlySales.Width = 123;
            // 
            // orderPerMonth
            // 
            this.orderPerMonth.DisplayIndex = 5;
            this.orderPerMonth.Text = "Monthly Order";
            this.orderPerMonth.Width = 175;
            // 
            // branchManager
            // 
            this.branchManager.DisplayIndex = 2;
            this.branchManager.Text = "Manager";
            this.branchManager.Width = 151;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DelectamentiPeanutButterStoreManagement.Properties.Resources.circle_PeanutButterNiMamaLogo;
            this.pictureBox1.Location = new System.Drawing.Point(21, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Peanut Butter Sales Management";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader branchName;
        private System.Windows.Forms.ColumnHeader CurrentMonthSale;
        private System.Windows.Forms.ColumnHeader YearlySales;
        private System.Windows.Forms.ColumnHeader orderPerMonth;
        private System.Windows.Forms.ColumnHeader branchManager;
    }
}

