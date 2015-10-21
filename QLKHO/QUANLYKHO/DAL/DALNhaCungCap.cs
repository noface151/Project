using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Propertiess;

namespace DAL
{
    public class DALNhaCungCap
    {
        public static bool AddNhaCungCap(int MaNCC,string TenNCC,string Diachi,string email,string Sodienthoai, string IDTaikhoan,DateTime Ngaymo,string chuTK,string CTkhac )
        {
            DBQLKhoEntities model = new DBQLKhoEntities();
            NhaCungCap NCC = new NhaCungCap();
            NCC.IDNhaCungCap = MaNCC;
            NCC.TenNhaCungCap = TenNCC;
            NCC.DiaChi = Diachi;
            NCC.Email = email;
            NCC.SoDienThoai = Sodienthoai;
            NCC.IDTaiKhoan = IDTaikhoan;
            NCC.NgayMoTK = Ngaymo;
            NCC.TenChuTK = chuTK;
            NCC.ChiTietKhac = CTkhac;
            try
            {
                model.NhaCungCap.Add(NCC);
                model.SaveChanges();
         
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static int Matudong()
        {
            int ma = 0;
            DBQLKhoEntities model=new DBQLKhoEntities();
            var count = (from p in model.NhaCungCap
                         select p).Count();
            ma = count+1;
            return ma;
        }
        public static List<Propertiess.NhaCungCapProperties> layDSNCC()
        {
            List<Propertiess.NhaCungCapProperties> dsNCC=new List<NhaCungCapProperties>();
            DBQLKhoEntities model = new DBQLKhoEntities();
            var all = from p in model.NhaCungCap
                      select p;
            foreach (var row in all)
            {
                Propertiess.NhaCungCapProperties NCC = new Propertiess.NhaCungCapProperties();
                NCC.TenNhaCungCap = row.TenNhaCungCap;
                dsNCC.Add(NCC);
            }
            return dsNCC;
        }
        public static NhaCungCap layNCCtheoten(string tenNCC)
        {
            DBQLKhoEntities model = new DBQLKhoEntities();
            var result = (from p in model.NhaCungCap
                          where p.TenNhaCungCap.Trim().Equals(tenNCC)
                          select p).FirstOrDefault();
            return result;
        }
    }
}
