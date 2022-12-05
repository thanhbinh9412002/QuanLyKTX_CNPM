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
            this.dgvThongBao = new System.Windows.Forms.DataGridView();
            this.TieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGui = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.dtpNgayDang = new System.Windows.Forms.DateTimePicker();
            this.gbTb = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongBao)).BeginInit();
            this.gbTb.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThongBao
            // 
            this.dgvThongBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongBao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TieuDe,
            this.NoiDung,
            this.NgayDang});
            this.dgvThongBao.Location = new System.Drawing.Point(13, 207);
            this.dgvThongBao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvThongBao.Name = "dgvThongBao";
            this.dgvThongBao.Size = new System.Drawing.Size(614, 210);
            this.dgvThongBao.TabIndex = 0;
            // 
            // TieuDe
            // 
            this.TieuDe.DataPropertyName = "TieuDe";
            this.TieuDe.HeaderText = "Tiêu đề ";
            this.TieuDe.Name = "TieuDe";
            this.TieuDe.Width = 150;
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "NoiDung";
            this.NoiDung.HeaderText = "Nội Dung";
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.Width = 300;
            // 
            // NgayDang
            // 
            this.NgayDang.DataPropertyName = "NgayDang";
            this.NgayDang.HeaderText = "Ngày Đăng";
            this.NgayDang.Name = "NgayDang";
            this.NgayDang.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiêu đề";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày đăng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nội dung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "THÔNG BÁO";
            // 
            // btnGui
            // 
            this.btnGui.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGui.Location = new System.Drawing.Point(634, 194);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(118, 49);
            this.btnGui.TabIndex = 9;
            this.btnGui.Text = "Gửi";
            this.btnGui.UseVisualStyleBackColor = true;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(634, 364);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(118, 49);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(634, 274);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(118, 49);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Location = new System.Drawing.Point(116, 24);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(326, 26);
            this.txtTieuDe.TabIndex = 4;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(116, 64);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(441, 26);
            this.txtNoiDung.TabIndex = 6;
            // 
            // dtpNgayDang
            // 
            this.dtpNgayDang.Enabled = false;
            this.dtpNgayDang.Location = new System.Drawing.Point(116, 105);
            this.dtpNgayDang.Name = "dtpNgayDang";
            this.dtpNgayDang.Size = new System.Drawing.Size(230, 26);
            this.dtpNgayDang.TabIndex = 7;
            // 
            // gbTb
            // 
            this.gbTb.Controls.Add(this.dtpNgayDang);
            this.gbTb.Controls.Add(this.txtNoiDung);
            this.gbTb.Controls.Add(this.txtTieuDe);
            this.gbTb.Controls.Add(this.label3);
            this.gbTb.Controls.Add(this.label2);
            this.gbTb.Controls.Add(this.label1);
            this.gbTb.Location = new System.Drawing.Point(12, 48);
            this.gbTb.Name = "gbTb";
            this.gbTb.Size = new System.Drawing.Size(582, 138);
            this.gbTb.TabIndex = 12;
            this.gbTb.TabStop = false;
            this.gbTb.Text = "Thông báo";
            // 
            // frm_ThongBao_NQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 440);
            this.Controls.Add(this.gbTb);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvThongBao);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_ThongBao_NQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ThongBao";
            this.Load += new System.EventHandler(this.frm_ThongBao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongBao)).EndInit();
            this.gbTb.ResumeLayout(false);
            this.gbTb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.DateTimePicker dtpNgayDang;
        private System.Windows.Forms.GroupBox gbTb;
    }
}