namespace PHAN_MEM_QUAN_LY_KTX_CNPM
{
    partial class frm_ThongBao_SV
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
            this.label4 = new System.Windows.Forms.Label();
            this.TieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongBao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongBao
            // 
            this.dgvThongBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongBao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TieuDe,
            this.NoiDung,
            this.NgayDang});
            this.dgvThongBao.Location = new System.Drawing.Point(131, 103);
            this.dgvThongBao.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dgvThongBao.Name = "dgvThongBao";
            this.dgvThongBao.Size = new System.Drawing.Size(811, 397);
            this.dgvThongBao.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(434, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "THÔNG BÁO";
            // 
            // TieuDe
            // 
            this.TieuDe.DataPropertyName = "TieuDe";
            this.TieuDe.HeaderText = "Tiêu đề ";
            this.TieuDe.Name = "TieuDe";
            this.TieuDe.Width = 200;
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "NoiDung";
            this.NoiDung.HeaderText = "Nội Dung";
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.Width = 450;
            // 
            // NgayDang
            // 
            this.NgayDang.DataPropertyName = "NgayDang";
            this.NgayDang.HeaderText = "Ngày Đăng";
            this.NgayDang.Name = "NgayDang";
            this.NgayDang.Width = 120;
            // 
            // frm_ThongBao_SV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 643);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvThongBao);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_ThongBao_SV";
            this.Text = "frmThongBao_SV";
            this.Load += new System.EventHandler(this.frm_ThongBao_SV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongBao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongBao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDang;
    }
}