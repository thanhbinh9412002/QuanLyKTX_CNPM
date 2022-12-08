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
            this.TieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
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
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Aquamarine;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1198, 64);
            this.label5.TabIndex = 55;
            this.label5.Text = "THÔNG BÁO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_ThongBao_SV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1198, 643);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvThongBao);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_ThongBao_SV";
            this.Text = "frmThongBao_SV";
            this.Load += new System.EventHandler(this.frm_ThongBao_SV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongBao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDang;
        private System.Windows.Forms.Label label5;
    }
}