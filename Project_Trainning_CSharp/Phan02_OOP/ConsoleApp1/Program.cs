using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //mô hình hóa: class, object
            // kế thừa , Đa hình
            // tính đóng gói
            // dùng lại
            SinhVien sv;
            sv= new SinhVien();
            //sv.MaSinhVien = "2";
            //sv.TenSinhVien = "Nguyen Thi B";
            //sv.TuoiSinhVien = 23;
            //sv.DiaChi = "binh Duong";

            //SinhVien svc = new SinhVien()
            //{
            //    MaSinhVien = "4",
            //    TenSinhVien = "Nguyen Van D",
            //    TuoiSinhVien = 54,
            //    DiaChi="Vung Tau"
            //};

            sv.NhapThongTinPerson();
          
            List<int> vs = new List<int>();
            ArrayList arrayList = new ArrayList();
            string[] vs1 = new string[]
            {
                "vs1","vs2"
            };


            NhanVien nv = new NhanVien();
            nv.NhapThongTinPerson();
            //SinhVien sva = new SinhVien("1", "Nguyen Van A", 34, "Dong Nai");
            //SinhVien svb = new SinhVien("2");

            //SinhVien svd = new SinhVien(svb);

            List<NhanVien> nhanViens = new List<NhanVien>();
            List<SinhVien> sinhViens = new List<SinhVien>();

            List<Person> people = new List<Person>();
            NhanVien nhanVien = new NhanVien();
            people.Add(nhanVien);
            SinhVien sinhVien = new SinhVien();
            people.Add(sinhVien);

            foreach (var item in people)
            {
                item.NhapThongTinPerson();
            }

        }
    }
}
