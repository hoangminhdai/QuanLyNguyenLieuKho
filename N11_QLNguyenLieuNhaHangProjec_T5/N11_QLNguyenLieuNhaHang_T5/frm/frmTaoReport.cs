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
    public partial class frmTaoReport : Form
    {
        public frmTaoReport()
        {
            InitializeComponent();
        }
        public frmTaoReport(int madh)
        {
            this.MaHD = madh;
            InitializeComponent();
        }
        int MaHD = -1;

        private void frmTaoReport_Load(object sender, EventArgs e)
        {
            this.hoaDonNhapTableAdapter.Fill(this.dataSetHoaDon.HoaDonNhap, MaHD);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
