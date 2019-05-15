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
    public partial class frmPhieuDatNL : Form
    {
        public frmPhieuDatNL()
        {
            InitializeComponent();
        }
        DBcontext db = new DBcontext();
        List<NguyenLieu> lst = new List<NguyenLieu>();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        
        int MaPD=-1;
        int MaHD = -1;

        int CurrID = -1;
        void LoadHDN()
        {
            dt2.Columns.Add("Mã NL", typeof(int));
            dt2.Columns.Add("Tên nguyên liệu", typeof(string));
            dt2.Columns.Add("Đơn giá", typeof(int));
            
            dt2.Columns.Add("số lượng thực nhập", typeof(string));
              
            dt2.Columns.Add("đơn vị", typeof(string));
            dataGridView_HoaDonNhap.DataSource = dt2;
            comboBox_HDNguyenLieu.DataSource = (from x in db.NguyenLieux
                                                where x.LoaiTuoiKho == false
                                                select new
                                                {
                                                    MaNL = x.MaNL,
                                                    TenNL = x.TenNL
                                                }).ToList();
            comboBox_HDNguyenLieu.DisplayMember = "TenNL";
            comboBox_HDNguyenLieu.ValueMember = "MaNL";
            comboBox_HDDonVi.DataSource = (from x in db.NguyenLieux
                                           select new
                                           {
                                               TenDonVi = x.TenDonVi
                                           }).ToList();
            comboBox_HDDonVi.DisplayMember = "TenDonVi";
        }
        private void frmPhieuDatNL_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Mã NL", typeof(int));
            dt.Columns.Add("Tên nguyên liệu", typeof(string));
            dt.Columns.Add("Đơn giá", typeof(int));
            dt.Columns.Add("Số lượng dự kiến", typeof(string));
            dt.Columns.Add("đơn vị", typeof(string));
            dataGridView1.DataSource = dt;
           
            comboBoxNCC.DataSource = (from x in db.NhaCungCaps
                                      select new
                                      {
                                          MaNCC = x.MaNCC,
                                          TenNCC = x.TenNCC
                                      }).ToList();
            comboBoxNCC.DisplayMember = "TenNCC";
            comboBoxNCC.ValueMember = "MaNCC";
            comboBoxNguyenLieu.DataSource = (from x in db.NguyenLieux where x.LoaiTuoiKho == false
                                             select new
                                             {
                                                 MaNL = x.MaNL,
                                                 TenNL = x.TenNL
                                             }).ToList();
            comboBoxNguyenLieu.DisplayMember = "TenNL";
            comboBoxNguyenLieu.ValueMember = "MaNL";
           
            comboBoxDonVi.DataSource= (from x in db.NguyenLieux
                                       select new
                                       {
                                           TenDonVi=x.TenDonVi
                                       }).ToList();
            comboBoxDonVi.DisplayMember = "TenDonVi";
           
            comboBoxNhanVien.DataSource= (from x in db.NhanViens
                                          select new
                                          {
                                              HoTen=x.HoTen,
                                              MaNV=x.MaNV
                                          }).ToList();
            comboBoxNhanVien.DisplayMember = "HoTen";
            comboBoxNhanVien.ValueMember = "MaNV";
            

        }
        void loadNguyenLieu(DataGridView dgv)
        {
            dt.Rows.Clear();
            dt.AcceptChanges();
            foreach (NguyenLieu nl in lst)
            {
                dt.Rows.Add(nl.MaNL, nl.TenNL,  nl.GiaTien, nl.SoLuong, nl.TenDonVi);
                
            }
            dgv.DataSource = dt;
        }
        void loadNguyenLieuHDN(DataGridView dgv)
        {
            dt2.Rows.Clear();
            dt2.AcceptChanges();
            foreach (NguyenLieu nl in lst)
            {
                dt2.Rows.Add(nl.MaNL, nl.TenNL, nl.GiaTien, nl.SoLuong, nl.TenDonVi);

            }
            dgv.DataSource = dt2;
        }








        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_TaoPhieuDat_Click(object sender, EventArgs e)
        {
            int manv = (int)comboBoxNhanVien.SelectedValue;
            int mancc = (int)comboBoxNCC.SelectedValue;
            try
            {
                db.Database.ExecuteSqlCommand("exec pc_ThemPhieuDatNL {0},{1}", manv, mancc);
                MessageBox.Show("Tạo phiếu đặt thành công mời bạn chọn nguyên liệu!");
                panelPhieuDat.Enabled = false;
                panel_PhieuDat.Enabled = true;

            }
            catch
            {
                MessageBox.Show("Thực hiện thao tác không thành công!");
            }
            
        }

     
      

        private void bt_Them_Click_1(object sender, EventArgs e)
        {

            NguyenLieu nl = new NguyenLieu();
            nl.MaNL = (int)comboBoxNguyenLieu.SelectedValue;
            nl.TenNL = comboBoxNguyenLieu.Text;
            nl.LoaiTuoiKho = false;
            nl.SoLuong = Convert.ToDouble(numericSoLuong.Value);
            nl.GiaTien = Convert.ToInt32(numeriGiaTien.Value);
            nl.TenDonVi = comboBoxDonVi.Text;
            if (lst.Exists(x => x.MaNL == nl.MaNL))
            {
                MessageBox.Show("Bạn đã thêm sản phẩm này rồi, vui lòng chọn sản phẩm khác!");
            }
            else
            {
                lst.Add(nl);
            }

            loadNguyenLieu(dataGridView1);
        }

        private void bt_Sua_Click_1(object sender, EventArgs e)
        {
            try
            {
                CurrID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                foreach (var nl in lst)
                {
                    if (nl.MaNL == CurrID)
                    {
                        nl.MaNL = (int)comboBoxNguyenLieu.SelectedValue;
                        nl.TenNL = comboBoxNguyenLieu.Text;
                        nl.LoaiTuoiKho = false;
                        nl.SoLuong = Convert.ToDouble(numericSoLuong.Value);
                        nl.GiaTien = Convert.ToInt32(numeriGiaTien.Value);
                        nl.TenDonVi = comboBoxDonVi.Text;
                        MessageBox.Show("Sửa Thành Công!");
                        break;
                    }
                }
                loadNguyenLieu(dataGridView1);
            }
            catch
            {

            }
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                CurrID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                lst.Remove(lst.Find(x => x.MaNL == CurrID));
                loadNguyenLieu(dataGridView1);
            }
            catch
            {

            }
        }

        private void bt_TaoHoaDonNhap_Click(object sender, EventArgs e)
        {
            MaPD = db.PhieuDatNLs.ToList().Last().MaPDNL;
            
            LoadHDN();
            loadNguyenLieuHDN(dataGridView_HoaDonNhap);

            try
            {
                foreach (var nl in lst)
                {
                    db.Database.ExecuteSqlCommand("exec pc_ThemChiTietPDNL {0},{1},{2}", MaPD, nl.MaNL, nl.SoLuong);

                }
                db.Database.ExecuteSqlCommand("exec pc_ThemHoaDonNhapNL {0},{1}", MaPD,(int)comboBoxNhanVien.SelectedValue);
                MessageBox.Show("Thực hiện thao tác thành công!");
                panel_HDN.Visible = true;
                panel_PhieuDat.Enabled = false;
                


            }
            catch
            {
                MessageBox.Show("Thực hiện thao tác không thành công!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            NguyenLieu nl = lst.Find(x => x.MaNL == CurrID);
            comboBoxNguyenLieu.SelectedValue = CurrID;
            numeriGiaTien.Value = nl.GiaTien.Value;
            numericSoLuong.Value = (int)nl.SoLuong;
        }

        private void dataGridView_HoaDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrID = int.Parse(dataGridView_HoaDonNhap.CurrentRow.Cells[0].Value.ToString());
            NguyenLieu nl = lst.Find(x => x.MaNL == CurrID);
            comboBox_HDNguyenLieu.SelectedValue = CurrID;
            numeric_HDGiaTien.Value = nl.GiaTien.Value;
            numeric_HDSoLuong.Value = (int)nl.SoLuong;
        }

        private void button_HDThem_Click(object sender, EventArgs e)
        {
            NguyenLieu nl = new NguyenLieu();
            nl.MaNL = (int)comboBox_HDNguyenLieu.SelectedValue;
            nl.TenNL = comboBox_HDNguyenLieu.Text;
            nl.LoaiTuoiKho = false;
            nl.SoLuong = Convert.ToDouble(numeric_HDSoLuong.Value);
            nl.GiaTien = Convert.ToInt32(numeric_HDGiaTien.Value);
            nl.TenDonVi = comboBox_HDDonVi.Text;
            if (lst.Exists(x => x.MaNL == nl.MaNL))
            {
                MessageBox.Show("Bạn đã thêm sản phẩm này rồi, vui lòng chọn sản phẩm khác!");
            }
            else
            {
                lst.Add(nl);
            }

            loadNguyenLieuHDN(dataGridView_HoaDonNhap);
        }

        private void button_HDSua_Click(object sender, EventArgs e)
        {
            try
            {
                CurrID = int.Parse(dataGridView_HoaDonNhap.CurrentRow.Cells[0].Value.ToString());
                foreach (var nl in lst)
                {
                    if (nl.MaNL == CurrID)
                    {
                        nl.MaNL = (int)comboBox_HDNguyenLieu.SelectedValue;
                        nl.TenNL = comboBox_HDNguyenLieu.Text;
                        nl.LoaiTuoiKho = false;
                        nl.SoLuong = Convert.ToDouble(numeric_HDSoLuong.Value);
                        nl.GiaTien = Convert.ToInt32(numeric_HDGiaTien.Value);
                        nl.TenDonVi = comboBox_HDDonVi.Text;
                        MessageBox.Show("Sửa Thành Công!");
                        break;
                    }
                }
                loadNguyenLieuHDN(dataGridView_HoaDonNhap);
            }
            catch
            {

            }
        }

        private void button_HDXoa_Click(object sender, EventArgs e)
        {
            try
            {
                CurrID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                lst.Remove(lst.Find(x => x.MaNL == CurrID));
                loadNguyenLieuHDN(dataGridView_HoaDonNhap);
            }
            catch
            {

            }
        }

        private void bt_InHoaDon_Click(object sender, EventArgs e)
        {
            MaHD = db.HoaDonNhapNLs.ToList().Last().MaHDN;
            try
            {
                foreach (var nl in lst)
                {
                    db.Database.ExecuteSqlCommand("exec pc_ThemChiTietHDN {0},{1},{2},{3}", MaHD, nl.MaNL,nl.GiaTien, nl.SoLuong);
                }
                //MessageBox.Show("Thực hiện thao tác thành công!");
                panel_HDN.Enabled = false;

                new frmTaoReport(MaHD).Show();

            }
            catch
            {
                MessageBox.Show("Thực hiện thao tác không thành công!");
            }

        }
    }  
}

