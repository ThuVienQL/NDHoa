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
        public void DataLoadPhieuMuon()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from PhieuMuon ",conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPhieuMuon.DataSource = dt;

            
        }
        private void dgvNhanVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvPhieuMuon.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
        private void dgvPhieuMuon_Click(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0){
                txtPhieuMuon.Text = Convert.ToString(dgvPhieuMuon.CurrentRow.Cells["MaPM"].Value);
                cboDG.Text = Convert.ToString(dgvPhieuMuon.CurrentRow.Cells["MaDG"].Value);
                dtNgayMuon.Text = Convert.ToString(dgvPhieuMuon.CurrentRow.Cells["NgayMuon"].Value);
                dtNgayHen.Text = Convert.ToString(dgvPhieuMuon.CurrentRow.Cells["NgayHenTra"].Value);
            }
        }
        public void loadDBComboboxMaDocGia() {
            //conn.Open();
            SqlCommand cmd = new SqlCommand("select MaDG from PhieuMuon",conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cboDG.DataSource = ds.Tables[0];
            cboDG.ValueMember = "MaDG";
            
        }

 
    }
}
