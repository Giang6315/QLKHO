using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Linq;
using QLKHO1.BussinessLogicLayer;
using QLKHO1.DataAccessLayer;
using System.Security.Cryptography;
namespace QLKHO1.PresentationLayer
{
    public partial class FrmPhanQuyen : Form
    {
        public FrmPhanQuyen()
        {
            InitializeComponent();
        }
        CMaHoaVaGiaiMaMatKhau MH = new CMaHoaVaGiaiMaMatKhau();
        #region Kiem Tra Mat Khau
        static bool LaKiTu(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
        }

        static bool LaSo(char c)
        {
            return c >= '0' && c <= '9';
        }
        static bool LaKiHieu(char c)
        {
            return c > 32 && c < 127 && !LaSo(c) && !LaKiTu(c);
        }

        static bool KiemTraPassword(string password)
        {
            return
               password.Any(c => LaKiTu(c)) &&
               password.Any(c => LaSo(c)) &&
               password.Any(c => LaKiHieu(c));
        }
        #endregion
        private void HienThiThongTinChiTiet(int index)
        {
            try
            {

                txtTenDangNhap.Text = dgvQuanLyNguoiDung.Rows[index].Cells["TENDANGNHAP"].Value.ToString();
                if ((bool)(dgvQuanLyNguoiDung.Rows[index].Cells["COLQUYENTHEM"].Value) == true)
                {
                    checkEditThem.Checked = true;
                }
                else
                {
                    checkEditThem.Checked = false;
                }
                if ((bool)(dgvQuanLyNguoiDung.Rows[index].Cells["COLQUYENXOA"].Value) == true)
                {
                    checkEditXoa.Checked = true;
                }
                else
                {
                    checkEditXoa.Checked = false;
                }
                if ((bool)(dgvQuanLyNguoiDung.Rows[index].Cells["COLQUYENSUA"].Value) == true)
                {
                    checkEditSua.Checked = true;
                }
                else
                {
                    checkEditSua.Checked = false;
                }
                if ((bool)(dgvQuanLyNguoiDung.Rows[index].Cells["COLQUYENADMIN"].Value) == true)
                {

                    checkEditAdmin.Checked = true;
                    checkEditThem.Enabled = false;
                    checkEditSua.Enabled = false;
                    checkEditXoa.Enabled = false;
                    checkEditThem.Checked = false;
                    checkEditSua.Checked = false;
                    checkEditXoa.Checked = false;
                }
                else
                    checkEditAdmin.Checked = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }
        int QuyenAdmin, QuyenThem, QuyenXoa, QuyenSua;
        public void LoadDanhSachNguoiDung()
        {
            DataTable dt = new DataTable();
            dt = CPHANQUYEN.LAYDSNGUOIDUNG();
            string MatKhauAdmin = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["TENDANGNHAP"].ToString() == FrmMain.TenDangNhap)
                {
                    MatKhauAdmin = dt.Rows[i]["MATKHAU"].ToString();
                    break;
                }
            }
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                dt.Rows[j]["MATKHAU"] = CMaHoaVaGiaiMaMatKhau.EncryptString(dt.Rows[j]["MATKHAU"].ToString());
            }
            dgvQuanLyNguoiDung.DataSource = dt;
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int index = 0;
            if (checkEditAdmin.Checked == true)
                QuyenAdmin = 1;
            else
                QuyenAdmin = 0;
            if (checkEditThem.Checked == true)
                QuyenThem = 1;
            else
                QuyenThem = 0;
            if (checkEditXoa.Checked == true)
                QuyenXoa = 1;
            else
                QuyenXoa = 0;
            if (checkEditSua.Checked == true)
                QuyenSua = 1;
            else
                QuyenSua = 0;

            string matkhau = txtMatKhau.Text;
            if (matkhau.Length < 8)
                XtraMessageBox.Show("Mật khẩu phải có ít nhất 8 kí tự!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "")
                    XtraMessageBox.Show("Tên đăng nhập và mật khẩu không được rỗng!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    if (KiemTraPassword(txtMatKhau.Text) == true)
                    {
                        try
                        {
                            index = dgvQuanLyNguoiDung.CurrentRow.Index;
                            CPHANQUYEN.NguoiDung_Sua(txtTenDangNhap.Text,CMaHoaVaGiaiMaMatKhau.EncryptString(txtMatKhau.Text), QuyenAdmin, QuyenThem, QuyenXoa, QuyenSua);
                            txtTenDangNhap.ResetText();
                            txtMatKhau.ResetText();
                            LoadDanhSachNguoiDung();
                            dgvQuanLyNguoiDung.CurrentCell = dgvQuanLyNguoiDung.Rows[index].Cells[0];

                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show("Lỗi " + ex.Message);
                        }
                    }
                    else
                        XtraMessageBox.Show("Mật khẩu phải có kí tự, số và kí tự đặc biệt!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        private void checkEditAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditAdmin.Checked == true)
            {
                checkEditThem.Enabled = false; checkEditThem.Checked = false;
                checkEditSua.Enabled = false; checkEditSua.Checked = false;
                checkEditXoa.Enabled = false; checkEditXoa.Checked = false;
            }
            else
            {
                checkEditThem.Enabled = true;
                checkEditSua.Enabled = true;
                checkEditXoa.Enabled = true;

            }
        }

    
        private void btnSoanLai_Click(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
        }
        private void FrmPhanQuyen_Load(object sender, EventArgs e)
        {
            LoadDanhSachNguoiDung();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
             if (checkEditAdmin.Checked == true)
                QuyenAdmin = 1;
            else
                QuyenAdmin = 0;
            if (checkEditThem.Checked == true)
                QuyenThem = 1;
            else
                QuyenThem = 0;
            if (checkEditXoa.Checked == true)
                QuyenXoa = 1;
            else
                QuyenXoa = 0;
            if (checkEditSua.Checked == true)
                QuyenSua = 1;
            else
                QuyenSua = 0;
            string matkhau = txtMatKhau.Text;

            if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "")
                XtraMessageBox.Show("Tên đăng nhập hoặc mật khẩu không được rỗng!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                if (matkhau.Length < 8)
                    XtraMessageBox.Show("Mật khẩu phải có ít nhất 8 kí tự!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    if (KiemTraPassword(txtMatKhau.Text) == true)
                    {
                        try
                        {
                            //MA HOA TXT_TENDANGNHAP ROI THEM
                            CPHANQUYEN.NguoiDung_Them(txtTenDangNhap.Text, CMaHoaVaGiaiMaMatKhau.EncryptString(txtMatKhau.Text), QuyenAdmin, QuyenThem, QuyenXoa, QuyenSua);
                            txtTenDangNhap.ResetText();
                            txtMatKhau.ResetText();
                            LoadDanhSachNguoiDung();
                            dgvQuanLyNguoiDung.CurrentCell = dgvQuanLyNguoiDung.Rows[dgvQuanLyNguoiDung.Rows.Count - 1].Cells[0];
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show("Lỗi: " + ex.Message, "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    else
                        XtraMessageBox.Show("Mật khẩu phải có kí tự, số và kí tự đặc biệt!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                CPHANQUYEN.NguoiDung_Xoa(txtTenDangNhap.Text);
                txtTenDangNhap.ResetText();
                txtMatKhau.ResetText();
                LoadDanhSachNguoiDung();


            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dgvQuanLyNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HienThiThongTinChiTiet(dgvQuanLyNguoiDung.CurrentRow.Index);
        }

    }
}