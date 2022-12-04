using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHAN_MEM_QUAN_LY_KTX_CNPM.BUS;

namespace PHAN_MEM_QUAN_LY_KTX_CNPM
{
    public partial class frm_Yeucau_Admin : Form
    {
        private string user;
        private string role;
        public int thongbao = 1;
        public int sukien = 0;
        public int id;
        public int giahan = 0;
        public int traphong = 0;
        public int suachua = 0;
        public DateTime ngaybatdau;
        public DateTime ngayketthuc;


        public frm_Yeucau_Admin(string user = "", string role = "")
        {
            InitializeComponent();
            this.user = user;
            this.role = role;
        }

        private void tatthongbao_menu_Click(object sender, EventArgs e)
        {
            thongbao = 0;
        }

        private void nhanthongbao_menu_Click(object sender, EventArgs e)
        {
            thongbao = 1;
        }

        private void giahano_menu_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void frm_Yeucau_Admin_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            dateTimePicker_batdau.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            dateTimePicker_ketthuc.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ngaybatdau = dateTimePicker_batdau.Value;
            ngayketthuc = dateTimePicker_ketthuc.Value;

        }

        private void suachua_menu_Click(object sender, EventArgs e)
        {
            suachua = 1;
            giahan = 0;
            traphong = 0;
            loaddata_suachua();
        }

        private void giahan_menu_Click(object sender, EventArgs e)
        {
            giahan = 1;
            traphong = 0;
            suachua = 0;
            loaddata_giahan();
        }

        private void trphong_menu_Click(object sender, EventArgs e)
        {
            traphong = 1;
            giahan = 0;
            suachua = 0;
            loaddata_traphong();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                id = int.Parse(Convert.ToString(dataGridView1.CurrentRow.Cells["Id"].Value));
                sukien = 1;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            YeuCau_BUS ycBUS = new YeuCau_BUS();
            if(sukien == 1)
            {
                if(giahan == 1)
                {
                    if (ycBUS.XoaYeuCauGiaHan(id) > 0)
                    {
                        if (MessageBox.Show("Xóa yêu cầu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            loaddata_giahan();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dx có lỗi xảy ra, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }    
                }
                else if(traphong == 1)
                {
                    if (ycBUS.XoaYeuCauTraPhong(id) > 0)
                    {
                        if (MessageBox.Show("Xóa yêu cầu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            loaddata_traphong();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dx có lỗi xảy ra, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }   
                else if(suachua == 1)
                {
                    if (ycBUS.XoaYeuCauSuaChua(id) > 0)
                    {
                        if (MessageBox.Show("Xóa yêu cầu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            loaddata_suachua();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dx có lỗi xảy ra, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }    
            }   
            else
            {
                MessageBox.Show("Bạn chưa chọn yêu cầu cần xóa. Mời chọn yêu cầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            
        }
        private void loaddata_suachua()
        {
            var ycBUS = new YeuCau_BUS();
            DataTable dt = ycBUS.DanhSachYeuCauSuaChua();
            this.dataGridView1.DataSource = dt;
        }
        private void loaddata_giahan()
        {
            var ycBUS = new YeuCau_BUS();
            DataTable dt = ycBUS.DanhSachYeuCauGiaHan();
            this.dataGridView1.DataSource = dt;
        }
        private void loaddata_traphong()
        {
            var ycBUS = new YeuCau_BUS();
            DataTable dt = ycBUS.DanhSachYeuCauTraPhong();
            this.dataGridView1.DataSource = dt;
        }
    }
}
