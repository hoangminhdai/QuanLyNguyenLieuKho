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
    public partial class frmDanhMuc : Form
    {
        public frmDanhMuc()
        {
            InitializeComponent();
            frmNguyenLieu f = new frmNguyenLieu();
            f.MdiParent = this;
            f.Show();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNguyenLieu f = new frmNguyenLieu();
            f.MdiParent = this;
            f.Show();
        }


        private void đặtNguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuDatNL f = new frmPhieuDatNL();
            
            f.Show();
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

       
        
        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
           

        }
        DBcontext db = new DBcontext();
        public static int MaNV = -1;
       
       

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.labelNV.Text = null;
            this.danhMụcToolStripMenuItem.Enabled = true;
        }

        private void quảnLýHóaĐơnNhậpNguyêLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmHoaDonNhap().Show();
        }
    }
}
