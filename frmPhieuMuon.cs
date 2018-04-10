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
namespace QLTV
{
    public partial class frmPhieuMuon : Form
    {
        string strConn = @"Data Source=DESKTOP-SPIMD63;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        SqlConnection conn = new SqlConnection(); // khoi tao mot doi tuong ket noi
        int chon;
        public frmPhieuMuon()
        {
            InitializeComponent();
            conn = new SqlConnection(strConn);
            conn.Open();
            DataLoadPhieuMuon();
            this.loadDBComboboxMaDocGia();
            btnLuu.Enabled = false;
            txtPhieuMuon.Enabled = false;
        }

    }
}
