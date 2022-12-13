namespace PHAN_MEM_QUAN_LY_KTX_CNPM
{
    partial class frm_ThongBao_NQL
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnGoi = new System.Windows.Forms.Button();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.dtpNgayDang = new System.Windows.Forms.DateTimePicker();
            this.gbTb = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NgayDang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvThongBao = new System.Windows.Forms.DataGridView();
            this.gbTb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongBao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiêu đề";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày đăng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nội dung";
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.Color.LightCoral;
            this.btnTao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTao.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.Image = global::PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.add_icon;
            this.btnTao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTao.Location = new System.Drawing.Point(815, 333);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(118, 49);
            this.btnTao.TabIndex = 9;
            this.btnTao.Text = "Tạo";
            this.btnTao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.LightCoral;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.remove_icon;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.Location = new System.Drawing.Point(815, 503);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(118, 49);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnGoi
            // 
            this.btnGoi.BackColor = System.Drawing.Color.LightCoral;
            this.btnGoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoi.Image = global::PHAN_MEM_QUAN_LY_KTX_CNPM.Properties.Resources.Send_icon;
            this.btnGoi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGoi.Location = new System.Drawing.Point(815, 413);
            this.btnGoi.Name = "btnGoi";
            this.btnGoi.Size = new System.Drawing.Size(118, 49);
            this.btnGoi.TabIndex = 11;
            this.btnGoi.Text = "Gửi";
            this.btnGoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGoi.UseVisualStyleBackColor = false;
            this.btnGoi.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTieuDe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTieuDe.Location = new System.Drawing.Point(155, 43);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(459, 26);
            this.txtTieuDe.TabIndex = 4;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNoiDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoiDung.Location = new System.Drawing.Point(155, 92);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(698, 93);
            this.txtNoiDung.TabIndex = 6;
            // 
            // dtpNgayDang
            // 
            this.dtpNgayDang.Enabled = false;
            this.dtpNgayDang.Location = new System.Drawing.Point(155, 206);
            this.dtpNgayDang.Name = "dtpNgayDang";
            this.dtpNgayDang.Size = new System.Drawing.Size(230, 26);
            this.dtpNgayDang.TabIndex = 7;
            // 
            // gbTb
            // 
            this.gbTb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbTb.Controls.Add(this.dtpNgayDang);
            this.gbTb.Controls.Add(this.txtNoiDung);
            this.gbTb.Controls.Add(this.txtTieuDe);
            this.gbTb.Controls.Add(this.label3);
            this.gbTb.Controls.Add(this.label2);
            this.gbTb.Controls.Add(this.label1);
            this.gbTb.Location = new System.Drawing.Point(53, 50);
            this.gbTb.Name = "gbTb";
            this.gbTb.Size = new System.Drawing.Size(928, 262);
            this.gbTb.TabIndex = 12;
            this.gbTb.TabStop = false;
            this.gbTb.Text = "Thông báo";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Lime;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1047, 32);
            this.label5.TabIndex = 54;
            this.label5.Text = "THÔNG BÁO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NgayDang
            // 
            this.NgayDang.DataPropertyName = "NgayDang";
            this.NgayDang.HeaderText = "Ngày Đăng";
            this.NgayDang.Name = "NgayDang";
            this.NgayDang.Width = 120;
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "NoiDung";
            this.NoiDung.HeaderText = "Nội Dung";
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.Width = 300;
            // 
            // TieuDe
            // 
            this.TieuDe.DataPropertyName = "TieuDe";
            this.TieuDe.HeaderText = "Tiêu đề ";
            this.TieuDe.Name = "TieuDe";
            this.TieuDe.Width = 150;
            // 
            // dgvThongBao
            // 
            this.dgvThongBao.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvThongBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongBao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TieuDe,
            this.NoiDung,
            this.NgayDang});
            this.dgvThongBao.Location = new System.Drawing.Point(98, 333);
            this.dgvThongBao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvThongBao.Name = "dgvThongBao";
            this.dgvThongBao.Size = new System.Drawing.Size(614, 219);
            this.dgvThongBao.TabIndex = 0;
            // 
            // frm_ThongBao_NQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1047, 593);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbTb);
            this.Controls.Add(this.btnGoi);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.dgvThongBao);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_ThongBao_NQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ThongBao";
            this.Load += new System.EventHandler(this.frm_ThongBao_Load);
            this.gbTb.ResumeLayout(false);
            this.gbTb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongBao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnGoi;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.DateTimePicker dtpNgayDang;
        private System.Windows.Forms.GroupBox gbTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn TieuDe;
        private System.Windows.Forms.DataGridView dgvThongBao;
    }
}