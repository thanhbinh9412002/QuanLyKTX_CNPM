
namespace PHAN_MEM_QUAN_LY_KTX_CNPM
{
    partial class frm_YeuCau
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_sudung = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_traphong = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_suachua = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_giahan = new System.Windows.Forms.ToolStripMenuItem();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel_sudung.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1063, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "YÊU CẦU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_sudung);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 600);
            this.panel1.TabIndex = 24;
            // 
            // panel_sudung
            // 
            this.panel_sudung.Controls.Add(this.panel2);
            this.panel_sudung.Controls.Add(this.pictureBox1);
            this.panel_sudung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_sudung.Location = new System.Drawing.Point(0, 29);
            this.panel_sudung.Name = "panel_sudung";
            this.panel_sudung.Size = new System.Drawing.Size(1063, 571);
            this.panel_sudung.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Aquamarine;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.menu_traphong,
            this.menu_giahan,
            this.menu_suachua});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1063, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_traphong
            // 
            this.menu_traphong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_traphong.ForeColor = System.Drawing.Color.Maroon;
            this.menu_traphong.Name = "menu_traphong";
            this.menu_traphong.Size = new System.Drawing.Size(96, 25);
            this.menu_traphong.Text = "Trả phòng";
            this.menu_traphong.Click += new System.EventHandler(this.menu_traphong_Click);
            // 
            // menu_suachua
            // 
            this.menu_suachua.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_suachua.ForeColor = System.Drawing.Color.Maroon;
            this.menu_suachua.Name = "menu_suachua";
            this.menu_suachua.Size = new System.Drawing.Size(88, 25);
            this.menu_suachua.Text = "Sửa chữa";
            this.menu_suachua.Click += new System.EventHandler(this.menu_suachua_Click);
            // 
            // menu_giahan
            // 
            this.menu_giahan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_giahan.ForeColor = System.Drawing.Color.Maroon;
            this.menu_giahan.Name = "menu_giahan";
            this.menu_giahan.Size = new System.Drawing.Size(75, 25);
            this.menu_giahan.Text = "Gia hạn";
            this.menu_giahan.Click += new System.EventHandler(this.menu_giahan_Click);
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.trangChủToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(93, 25);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            this.trangChủToolStripMenuItem.Click += new System.EventHandler(this.trangChủToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources._2621170;
            this.pictureBox1.Location = new System.Drawing.Point(87, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(879, 486);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(87, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(879, 486);
            this.panel2.TabIndex = 3;
            // 
            // frm_YeuCau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1063, 632);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_YeuCau";
            this.Text = "Yêu cầu";
            this.Load += new System.EventHandler(this.frm_YeuCau_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_sudung.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_suachua;
        private System.Windows.Forms.ToolStripMenuItem menu_traphong;
        private System.Windows.Forms.ToolStripMenuItem menu_giahan;
        private System.Windows.Forms.Panel panel_sudung;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}