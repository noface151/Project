using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUSNhaCungCap
    {
        public bool ThemNCC(int MaNCC, string TenNCC, string Diachi, string email, string Sodienthoai, string IDTaikhoan, DateTime Ngaymo, string chuTK, string CTkhac)
        {
            return DAL.DALNhaCungCap.AddNhaCungCap(MaNCC, TenNCC, Diachi, email, Sodienthoai, IDTaikhoan, Ngaymo, chuTK, CTkhac);
        }

        public List<Propertiess.NhaCungCapProperties> dayDSNCC()
        {
            return DAL.DALNhaCungCap.layDSNCC();
        }
        public NhaCungCap layNCCtheoten(string tenNCC)
        {
            if (DAL.DALNhaCungCap.layNCCtheoten(tenNCC) == null)
                return null;
            else return DAL.DALNhaCungCap.layNCCtheoten(tenNCC);

        }
    }
}

