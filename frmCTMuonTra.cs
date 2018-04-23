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
using QuanLyThuVien;

namespace QLTV
{
    public partial class frmCTMuonTra : Form
    {
        string strConn = @"Data Source=DESKTOP-SPIMD63;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        SqlConnection conn = new SqlConnection();
        int chon;
        public frmCTMuonTra()
        {
            InitializeComponent();
            conn = new SqlConnection(strConn);
            conn.Open();
            //LoadCTMuonTra();
            //DataLoadPhieuMuon();
            DataLoadPhieuMuon2();
            btnLuu.Enabled = false;
            loadDBCombobox();
            loadDBComboboxMaDocGia();
            txtPhieuMuon.Enabled = false;
            txtMaPM.Enabled = false;
        }
        
    }
}
