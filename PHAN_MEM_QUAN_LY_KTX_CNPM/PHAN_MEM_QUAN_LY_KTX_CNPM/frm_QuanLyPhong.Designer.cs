
namespace PHAN_MEM_QUAN_LY_KTX_CNPM
{
    partial class frm_QuanLyPhong
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hoadon_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.chitietphong_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.thietbi_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.quaylai_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_loadform = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1047, 32);
            this.label1.TabIndex = 85;
            this.label1.Text = "QUẢN LÍ PHÒNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.panel_loadform);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 561);
            this.panel1.TabIndex = 86;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Aquamarine;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hoadon_menu,
            this.chitietphong_menu,
            this.thietbi_menu,
            this.quaylai_menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1047, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hoadon_menu
            // 
            this.hoadon_menu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.hoadon_menu.ForeColor = System.Drawing.Color.Maroon;
            this.hoadon_menu.Name = "hoadon_menu";
            this.hoadon_menu.Size = new System.Drawing.Size(85, 25);
            this.hoadon_menu.Text = "Hóa đơn";
            this.hoadon_menu.Click += new System.EventHandler(this.hoadon_menu_Click);
            // 
            // chitietphong_menu
            // 
            this.chitietphong_menu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.chitietphong_menu.ForeColor = System.Drawing.Color.Maroon;
            this.chitietphong_menu.Name = "chitietphong_menu";
            this.chitietphong_menu.Size = new System.Drawing.Size(126, 25);
            this.chitietphong_menu.Text = "Chi tiết phòng";
            this.chitietphong_menu.Click += new System.EventHandler(this.chitietphong_menu_Click);
            // 
            // thietbi_menu
            // 
            this.thietbi_menu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.thietbi_menu.ForeColor = System.Drawing.Color.Maroon;
            this.thietbi_menu.Name = "thietbi_menu";
            this.thietbi_menu.Size = new System.Drawing.Size(77, 25);
            this.thietbi_menu.Text = "Thiết bị";
            this.thietbi_menu.Click += new System.EventHandler(this.thietbi_menu_Click);
            // 
            // quaylai_menu
            // 
            this.quaylai_menu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.quaylai_menu.ForeColor = System.Drawing.Color.Maroon;
            this.quaylai_menu.Name = "quaylai_menu";
            this.quaylai_menu.Size = new System.Drawing.Size(79, 25);
            this.quaylai_menu.Text = "Quay lại";
            this.quaylai_menu.Click += new System.EventHandler(this.quaylai_menu_Click);
            // 
            // panel_loadform
            // 
            this.panel_loadform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_loadform.Location = new System.Drawing.Point(0, 29);
            this.panel_loadform.Name = "panel_loadform";
            this.panel_loadform.Size = new System.Drawing.Size(1047, 532);
            this.panel_loadform.TabIndex = 1;
            // 
            // frm_QuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 593);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_QuanLyPhong";
            this.Text = "frm_QuanLyPhong";
            this.Load += new System.EventHandler(this.frm_QuanLyPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hoadon_menu;
        private System.Windows.Forms.ToolStripMenuItem chitietphong_menu;
        private System.Windows.Forms.ToolStripMenuItem thietbi_menu;
        private System.Windows.Forms.ToolStripMenuItem quaylai_menu;
        private System.Windows.Forms.Panel panel_loadform;
    }
}