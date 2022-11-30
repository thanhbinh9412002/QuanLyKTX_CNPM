
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitietHD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChitietHD
            // 
            this.dgvChitietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChitietHD.Location = new System.Drawing.Point(158, 89);
            this.dgvChitietHD.Name = "dgvChitietHD";
            this.dgvChitietHD.RowHeadersWidth = 51;
            this.dgvChitietHD.RowTemplate.Height = 24;
            this.dgvChitietHD.Size = new System.Drawing.Size(635, 377);
            this.dgvChitietHD.TabIndex = 0;
            // 
            // frm_ChitietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 533);
            this.Controls.Add(this.dgvChitietHD);
            this.Name = "frm_ChitietHoaDon";
            this.Text = "frm_ChitietHoaDon";
            this.Load += new System.EventHandler(this.frm_ChitietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitietHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChitietHD;
    }
}