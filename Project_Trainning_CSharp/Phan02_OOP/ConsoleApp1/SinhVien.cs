using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP
{
    //Class: field (private), property (public), method (private, public, protected, internal), Constructor (public)
    //Tầm vực truy cập: private, protected, internal, public, protected internal 
    //Viet lop Entity
    public class SinhVien : Person
    {
        #region field -- biến thành viên
        //private string maSinhVien;//canval
        //private string tenSinhVien;
        //private int tuoiSinhVien;
        //private string diaChi;
        private double diemTrungBinh;
        #endregion

        #region Properties
        //public string MaSinhVien
        //{
        //    get
        //    {
        //        return maSinhVien;
        //    }
        //    set
        //    {
        //        maSinhVien = value;
        //    }
        //}

        //public string TenSinhVien { get; set; }
        //public int TuoiSinhVien { get => tuoiSinhVien; set => tuoiSinhVien = value; }
        //public string DiaChi { get => diaChi; set => diaChi = value; }
        //dùng phím tắt : Ctrl+R+E =>Enter
        #endregion

        #region Method: Phương thức 
        //1. Phương thức không có giá trị trả về: public void Add( int a, int b)
        //1.1 Phương thức có tham số vào, không có tham số ra
        //1.2 Phương thức có tham số vào, và có tham số ra (Truyền tham chiếu)
        //1.3 phương thức không có tham số
        //2. Phương thức có giá trị trả về: khai báo giá trị trả về ex: public int Add(int a,int b)
        //2.1 Phương thức có tham số vào, không có tham số ra
        //2.2 Phương thức có tham số vào, và có tham số ra (Truyền tham chiếu)
        //2.3 phương thức không có tham số
        //==> Nạp chồng phương thức (viết phương thức trùng tên)
        //1. Kiểu của tham số: void Add(int a, int b) nạp chồng void Add(double a, double b)
        //2. Số lượng tham số khác nhau: void Add(int a,int b,int c) nạp chồng void Add(int a, int b)
        //3. Thứ tự của tham số khác nhau: void Add(int a , int b, float c) nạp chồng void Add(int a,float b, int c)
        //Example

        public override void NhapThongTinPerson()
        {
            base.NhapThongTinPerson();
            Console.WriteLine("Nhap DiaChi: ");
            diemTrungBinh = Convert.ToDouble(Console.ReadLine());
        }
        //public SinhVien NhapThongTinSinhVien(int index)
        //{
        //    Console.WriteLine("Nhap sinh Thu " + index + ": ");
        //    SinhVien sv = new SinhVien();
        //    Console.WriteLine("Nhap MSSV: ");
        //    sv.MaSinhVien = Console.ReadLine();
        //    Console.WriteLine("Nhap Ten: ");
        //    sv.TenSinhVien = Console.ReadLine();
        //    Console.WriteLine("Nhap Tuoi: ");
        //    sv.TuoiSinhVien = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Nhap DiaChi: ");
        //    sv.DiaChi = Console.ReadLine();
        //    return sv;
        //}

        public override string ToString()
        {
            return base.ToString() + string.Format("Diem trung binh {0}", diemTrungBinh);
        }
    
    #endregion

    #region Contructor -- Hàm tạo
    //1. hàm tạo không tham số: Trong c# luôn có 1 hàm tạo không tham số làm mặc định
    //cú pháp: public TenClass(){}
    public SinhVien()
        {

        }
        //2. Hàm tạo có tham số
        public SinhVien(string maSinhVien, string tenSinhVien, int tuoiSinhVien, string diaChi, double diemTrungBinh) : base(maSinhVien, tenSinhVien, tuoiSinhVien, diaChi)

        {
            this.diemTrungBinh = diemTrungBinh;
        }
        //public SinhVien(string maSinhVien)
        //{
        //    this.maSinhVien = maSinhVien;
        //}
        //3. Hàm tạo sao chép
        public SinhVien(SinhVien sinhVien)
        {
            this.diemTrungBinh = sinhVien.diemTrungBinh;
        }
        #endregion

        #region DeConstructor
        //C# không cần viết


        #endregion
    }
}
