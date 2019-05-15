using N11_QLNguyenLieuNhaHang_T5.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N11_QLNguyenLieuNhaHang_T5.frm
{
    public partial class frmNguyenLieu : Form
    {
        public frmNguyenLieu()
        {
            InitializeComponent();
        }
        private NguyenLieu NguyenLieuDaChon(int ID)
        {
            return new NguyenLieu()
            {
                MaNL = ID,
                TenNL = tb_TenNL.Text,
                LoaiTuoiKho = false,
                GiaTien = Convert.ToInt32(numeriGiaTien.Value),
                SoLuong = Convert.ToDouble(numericSoLuong.Value),
                TenDonVi = tb_DonVi.Text
               
            };
        }
        void loaddulieu()
        {
            using (DBcontext db = new DBcontext())
            {
                dataGridViewNguyenLieu.DataSource = (from x in db.NguyenLieux
                                                     where x.LoaiTuoiKho == false
                                                     select new
                                                     {
                                                         MaNL = x.MaNL,
                                                         TenNL = x.TenNL,
                                                         DonGia = x.GiaTien,
                                                         SoLuong = x.SoLuong,
                                                         DonVi = x.TenDonVi
                                                     }).ToList();
            }

                
        }
        private void frmNguyenLieu_Load(object sender, EventArgs e)
        {
            loaddulieu();
        }

        private void dataGridViewNguyenLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (DBcontext db = new DBcontext())
            {
                int id = (int)this.dataGridViewNguyenLieu.CurrentRow.Cells[0].Value;
                NguyenLieu nl = db.NguyenLieux.SingleOrDefault(x => x.MaNL.Equals(id));
                tb_TenNL.Text = nl.TenNL;
                numeriGiaTien.Value = nl.GiaTien.Value;
                numericSoLuong.Value = (int)nl.SoLuong;
                tb_DonVi.Text = nl.TenDonVi.ToString();
            }
          

        }

        private void dataGridViewNguyenLieu_KeyUp(object sender, KeyEventArgs e)
        {
         
            using (DBcontext db = new DBcontext())
            {
                int id = (int)this.dataGridViewNguyenLieu.CurrentRow.Cells[0].Value;
                NguyenLieu nl = db.NguyenLieux.SingleOrDefault(x => x.MaNL == id);
                tb_TenNL.Text = nl.TenNL;
                numeriGiaTien.Value = nl.GiaTien.Value;
                numericSoLuong.Value = (int)nl.SoLuong;
                tb_DonVi.Text = nl.TenDonVi.ToString();
            }

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            using (DBcontext db = new DBcontext())
            {
                var lst = db.NguyenLieux.ToList();
                foreach (NguyenLieu ln in lst)
                {
                    if(ln.TenNL ==tb_TenNL.Text.ToString())
                    {
                        MessageBox.Show("Đã có nguyên liệu này mời thêm nguyên liệu khác");
                        return;
                    }
                }
                int id = (int)this.dataGridViewNguyenLieu.CurrentRow.Cells[0].Value;
                db.NguyenLieux.Add(NguyenLieuDaChon(id));
                db.SaveChanges();
                MessageBox.Show("Thêm thành công");
                loaddulieu();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            using (DBcontext db = new DBcontext())
            {
                int id = (int)this.dataGridViewNguyenLieu.CurrentRow.Cells[0].Value;

                if (db.NguyenLieux.Find(id) == null)
                {
                    MessageBox.Show("Có lỗi xảy ra khi xóa đối tượng này." + Environment.NewLine
                            + "Vui lòng cập nhật lại hoặc chọn một đối tượng khác.");
                    return;
                }

                var toBeUpdated = db.NguyenLieux.Single(nl => nl.MaNL == id);

                toBeUpdated.TenNL = tb_TenNL.Text;
              
                toBeUpdated.GiaTien = Convert.ToInt32(numeriGiaTien.Value);
                toBeUpdated.SoLuong = Convert.ToDouble(numericSoLuong.Value);
                toBeUpdated.TenDonVi = tb_DonVi.Text;
                db.SaveChanges();
                MessageBox.Show("Cập nhật thành công!");
                loaddulieu();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            using (DBcontext db = new DBcontext())
            {
                int id = (int)this.dataGridViewNguyenLieu.CurrentRow.Cells[0].Value;

                if (db.NguyenLieux.Find(id) == null)
                {
                    MessageBox.Show("Có lỗi xảy ra khi xóa đối tượng này." + Environment.NewLine
                            + "Vui lòng cập nhật lại hoặc chọn một đối tượng khác.");
                    return;
                }

                if(MessageBox.Show("Bạn có muốn xóa đối tượng này?","xóa",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    try
                    {
                        db.Database.ExecuteSqlCommand("exec pc_XoaNguyenLieu {0}", id);
                        MessageBox.Show("Xóa thành công!");
                        loaddulieu();
                    }catch
                    {
                        MessageBox.Show("Khổng thể xóa vì đối tượng đăng được sử dụng tại nơi khác");
                    }
                    
                }
                
            }
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string cmd = string.Format("select MaNL as N'Mã Nguyên liệu',TenNL as N'Tên Nguyên Liệu' ," +
                "GiaTien as N'Giá Tiền' ,SoLuong as N'Số Lượng' ,TenDonVi as N'Đơn vi'" +
                " from NguyenLieu where LoaiTuoiKho='0' and TenNL like N'%{0}%'", tb_TimKiem.Text);
            SqlConnection con = new SqlConnection("server=DESKTOP-M0UUI69\\SQLEXPRESS;database=N11_QLNguyenLieuNhaHang_T5;Integrated Security=SSPI");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewNguyenLieu.DataSource = dt;
            con.Close();
        }

        private void tb_TimKiem_Click(object sender, EventArgs e)
        {
            tb_TimKiem.Text = null;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            using (DBcontext db = new DBcontext())
            {
                
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
