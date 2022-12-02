
namespace PHAN_MEM_QUAN_LY_KTX_CNPM
{
    partial class frm_ChitietHoaDon
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
            this.dgvChitietHD = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitietHD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChitietHD
            // 
            this.dgvChitietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChitietHD.Location = new System.Drawing.Point(62, 57);
            this.dgvChitietHD.Name = "dgvChitietHD";
            this.dgvChitietHD.RowHeadersWidth = 51;
            this.dgvChitietHD.RowTemplate.Height = 24;
            this.dgvChitietHD.Size = new System.Drawing.Size(635, 168);
            this.dgvChitietHD.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Aquamarine;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(776, 39);
            this.label2.TabIndex = 31;
            this.label2.Text = "CHI TIẾT HÓA ĐƠN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_ChitietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 259);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvChitietHD);
            this.Name = "frm_ChitietHoaDon";
            this.Text = "frm_ChitietHoaDon";
            this.Load += new System.EventHandler(this.frm_ChitietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitietHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChitietHD;
        private System.Windows.Forms.Label label2;
    }
}