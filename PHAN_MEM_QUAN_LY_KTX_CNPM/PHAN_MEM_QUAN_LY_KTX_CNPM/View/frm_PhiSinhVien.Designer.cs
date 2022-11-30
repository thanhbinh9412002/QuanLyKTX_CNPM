
namespace PHAN_MEM_QUAN_LY_KTX_CNPM
{
    partial class frm_PhiSinhVien
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
            this.dgvPhiSinhVien = new System.Windows.Forms.DataGridView();
            this.lbPhi = new System.Windows.Forms.Label();
            this.btnThanhToanAll = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhiSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhiSinhVien
            // 
            this.dgvPhiSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhiSinhVien.Location = new System.Drawing.Point(173, 120);
            this.dgvPhiSinhVien.Name = "dgvPhiSinhVien";
            this.dgvPhiSinhVien.RowHeadersWidth = 51;
            this.dgvPhiSinhVien.RowTemplate.Height = 24;
            this.dgvPhiSinhVien.Size = new System.Drawing.Size(722, 440);
            this.dgvPhiSinhVien.TabIndex = 0;
            // 
            // lbPhi
            // 
            this.lbPhi.AutoSize = true;
            this.lbPhi.Location = new System.Drawing.Point(448, 73);
            this.lbPhi.Name = "lbPhi";
            this.lbPhi.Size = new System.Drawing.Size(46, 17);
            this.lbPhi.TabIndex = 1;
            this.lbPhi.Text = "label1";
            // 
            // btnThanhToanAll
            // 
            this.btnThanhToanAll.Location = new System.Drawing.Point(308, 609);
            this.btnThanhToanAll.Name = "btnThanhToanAll";
            this.btnThanhToanAll.Size = new System.Drawing.Size(143, 46);
            this.btnThanhToanAll.TabIndex = 2;
            this.btnThanhToanAll.Text = "Thanh toán tất cả";
            this.btnThanhToanAll.UseVisualStyleBackColor = true;
            this.btnThanhToanAll.Click += new System.EventHandler(this.btnThanhToanAll_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(552, 609);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(104, 46);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // frm_PhiSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 692);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnThanhToanAll);
            this.Controls.Add(this.lbPhi);
            this.Controls.Add(this.dgvPhiSinhVien);
            this.Name = "frm_PhiSinhVien";
            this.Text = "frm_PhiSinhVien";
            this.Load += new System.EventHandler(this.frm_PhiSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhiSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhiSinhVien;
        private System.Windows.Forms.Label lbPhi;
        private System.Windows.Forms.Button btnThanhToanAll;
        private System.Windows.Forms.Button btnThanhToan;
    }
}