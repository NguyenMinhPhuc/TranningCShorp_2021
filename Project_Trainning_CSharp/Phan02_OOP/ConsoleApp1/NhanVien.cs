using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP
{
   public class NhanVien:Person
    {
      private  double heSoLuong;
        public NhanVien() : base()
        {

        }
        public NhanVien(string maNhanVien, string tenNhanVien,int tuoiNhanVien, string diaChi,double heSoLuong) : base(maNhanVien,tenNhanVien,tuoiNhanVien,diaChi)
        {
            this.heSoLuong = heSoLuong;
        }

        public override void NhapThongTinPerson()
        {
            base.NhapThongTinPerson();
            Console.WriteLine("Nhap HeSoLuong: ");
             heSoLuong=Convert.ToDouble( Console.ReadLine());
        }
        public override string ToString()
        {
            return base.ToString()+ string.Format("He so Luong {0}",heSoLuong);
        }
    }
}
