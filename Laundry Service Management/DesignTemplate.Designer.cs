namespace Laundry_Service_Management
{
    partial class DesignTemplate
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
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Dashboard");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Staff Management");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("View Customers");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Service");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Booking");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("History payment");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.mainContentPnl = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Location = new System.Drawing.Point(2, 97);
            this.treeView1.Name = "treeView1";
            treeNode16.Name = "Dashboard";
            treeNode16.Text = "Dashboard";
            treeNode17.Name = "Staff Management";
            treeNode17.Text = "Staff Management";
            treeNode18.Name = "View Customers";
            treeNode18.Text = "View Customers";
            treeNode19.Name = "Service";
            treeNode19.Text = "Service";
            treeNode21.Name = "Booking";
            treeNode21.Text = "Booking";
            treeNode20.Name = "History payment";
            treeNode20.Text = "History payment";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode21,
            treeNode20});
            this.treeView1.Size = new System.Drawing.Size(221, 745);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // mainContentPnl
            // 
            this.mainContentPnl.BackColor = System.Drawing.Color.White;
            this.mainContentPnl.Location = new System.Drawing.Point(218, 97);
            this.mainContentPnl.Name = "mainContentPnl";
            this.mainContentPnl.Size = new System.Drawing.Size(1162, 748);
            this.mainContentPnl.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::Laundry_Service_Management.Properties.Resources.Screenshot_2026_06_05_160612_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1392, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // DesignTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1392, 843);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.mainContentPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DesignTemplate";
            this.Text = "Smart Wash Laundry Management System";
            this.Load += new System.EventHandler(this.DesignTemplate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel mainContentPnl;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}