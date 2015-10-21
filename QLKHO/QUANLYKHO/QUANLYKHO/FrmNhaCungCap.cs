using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;
using Propertiess;


namespace QUANLYKHO
{
    public partial class FrmNhaCungCap : Form
    {
        public FrmNhaCungCap()
        {
            InitializeComponent();
        }

        private void BtThem_Click(object sender, EventArgs e)
        {
            int MaNCC = DAL.DALNhaCungCap.Matudong();
            string tenNCC = txtTenNCC.Text;
            string Diachi = txtDiaChi.Text;
            string email = txtEmail.Text;
            string Sodienthoai = txtSoDT.Text;
            string IDtaikhoan = txtTaiKhoan.Text;
            DateTime ngaymoTK = Convert.ToDateTime(dateTimePicker1.Text);
            string chuTK = txtChuTK.Text;
            string chitietkhac = txtChitietkhac.Text;
            BUSNhaCungCap ncc = new BUSNhaCungCap();
            ncc.ThemNCC(MaNCC, tenNCC, Diachi, email, Sodienthoai, IDtaikhoan, ngaymoTK, chuTK, chitietkhac);           
            List<Propertiess.NhaCungCapProperties> dsncc = ncc.dayDSNCC();
            dataGridViewNCC.DataSource = dsncc;

        }

        private void FrmNhaCungCap_Load(object sender, EventArgs e)
        {
            BUSNhaCungCap ncc=new BUSNhaCungCap();
            List<Propertiess.NhaCungCapProperties> dsncc = ncc.dayDSNCC();
            dataGridViewNCC.DataSource = dsncc;
        }

        private void dataGridViewNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewNCC.Rows[e.RowIndex];
                txtTenNCC.Text = row.Cells[0].Value.ToString();
            }
            DAL.DALNhaCungCap.layNCCtheoten(txtTenNCC.Text);
            BUSNhaCungCap bNCC = new BUSNhaCungCap();
            var NCC = bNCC.layNCCtheoten(txtTenNCC.Text);
            if (NCC == null)
            {
                MessageBox.Show("Không tồn tại nhà cung cấp");
            }
            else
            {
                txtDiaChi.Text = NCC.DiaChi;
                txtEmail.Text = NCC.Email;
                txtSoDT.Text = NCC.SoDienThoai;
                txtTaiKhoan.Text = NCC.IDTaiKhoan;
                txtChuTK.Text = NCC.TenChuTK;
                dateTimePicker1.Text = Convert.ToString(NCC.NgayMoTK);
                txtChitietkhac.Text = NCC.ChiTietKhac;
            }
        }    
    }
}
