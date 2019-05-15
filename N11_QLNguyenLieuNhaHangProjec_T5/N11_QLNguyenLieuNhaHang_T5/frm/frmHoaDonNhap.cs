using N11_QLNguyenLieuNhaHang_T5.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N11_QLNguyenLieuNhaHang_T5.frm
{
    public partial class frmHoaDonNhap : Form
    {
        public frmHoaDonNhap()
        {
            InitializeComponent();
        }
        DBcontext db = new DBcontext();
        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
          
                comboBox_MaHoaDon.DataSource = (from x in db.HoaDonNhapNLs select new { MaHDN = x.MaHDN }).ToList();
                comboBox_MaHoaDon.ValueMember = "MaHDN";
                comboBox_MaHoaDon.DisplayMember = "MaHDN";
            comboBox_NguyenLieu.DataSource = (from x in db.NguyenLieux select new { MaNL = x.MaNL }).ToList();
            comboBox_NguyenLieu.ValueMember = "MaNL";
            comboBox_NguyenLieu.DisplayMember = "MaNL";
            comboBox_NguyenLieu.SelectedValue = 1;
         
            
            
            LoadDuLieu((int)comboBox_MaHoaDon.SelectedValue);
        }
        void LoadDuLieu(int a)
        {
           
                dataGridViewHoaDon.DataSource = (from x in db.ChiTietHDNs
                                                 join u in db.NguyenLieux on x.MaNL equals u.MaNL
                                                 where x.MaHD == a
                                                 select new
                                                 {
                                                     MaNL = u.MaNL,
                                                     TenNL = u.TenNL,
                                                     DonGia = x.GiaTien,
                                                     SoLuongThucNhap = x.SoLuong,
                                                     DonVi = u.TenDonVi,
                                                     ThanhTien=x.GiaTien*x.SoLuong
                                                 }).ToList();

            
        }

        private void dataGridViewHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox_MaHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button_CapNhat_Click(object sender, EventArgs e)
        {
            LoadDuLieu((int)comboBox_MaHoaDon.SelectedValue);
        }

        private void dataGridViewHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (DBcontext db = new DBcontext())
            {
                int id = (int)this.dataGridViewHoaDon.CurrentRow.Cells[0].Value;
                
               comboBox_NguyenLieu.SelectedValue= dataGridViewHoaDon.CurrentRow.Cells[0].Value;               
                numeriGiaTien.Value =(int) dataGridViewHoaDon.CurrentRow.Cells[2].Value;
                numericSoLuong.Value = int.Parse(dataGridViewHoaDon.CurrentRow.Cells[3].Value.ToString());
            }
        }

       

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                db.Database.ExecuteSqlCommand("exec pc_SuaChiTietHDN {0},{1},{2},{3}",
               (int)comboBox_MaHoaDon.SelectedValue,
               comboBox_NguyenLieu.SelectedValue,
               numeriGiaTien.Value, (float)numericSoLuong.Value);
                MessageBox.Show("Thao Tác Thành Công");
                LoadDuLieu((int)comboBox_MaHoaDon.SelectedValue);
            }
            catch
            {
                MessageBox.Show("Không thể sửa chú ý mã sản phẩm!");
            }
           
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa đối tượng này?", "xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    db.Database.ExecuteSqlCommand("exec pc_XoaChiTietHDN {0},{1},{2},{3}",
                    (int)comboBox_MaHoaDon.SelectedValue,
                    comboBox_NguyenLieu.SelectedValue,
                    numeriGiaTien.Value, (float)numericSoLuong.Value);
                    MessageBox.Show("Thao Tác Thành Công");
                    LoadDuLieu((int)comboBox_MaHoaDon.SelectedValue);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa!");
                }
            }
            
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa đối tượng này?", "xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    db.Database.ExecuteSqlCommand("exec pc_XoaHoaDonNhapNL {0},{1},{2},{3}",
                    (int)comboBox_MaHoaDon.SelectedValue,
                    comboBox_NguyenLieu.SelectedValue,
                    numeriGiaTien.Value, (float)numericSoLuong.Value);
                    MessageBox.Show("Thao Tác Thành Công");
                    LoadDuLieu((int)comboBox_MaHoaDon.SelectedValue);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa!");
                }
            }
           
        }

        private void button_XuatHDN_Click(object sender, EventArgs e)
        {
            frmTaoReport f=new frmTaoReport((int)comboBox_MaHoaDon.SelectedValue);
            f.Show();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmPhieuDatNL().Show();
        }
    }
}
