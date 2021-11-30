using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP
{
  public  class Person
    {

        string iD;
        string fullName;
        int age;
        string address;

        public string ID { get => iD; set => iD = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public int Age { get => age; set => age = value; }
        public string Address { get => address; set => address = value; }

        public virtual void NhapThongTinPerson()
        {
            Console.WriteLine("Nhap MSSV: ");
            iD = Console.ReadLine();
            Console.WriteLine("Nhap Ten: ");
            fullName = Console.ReadLine();
            Console.WriteLine("Nhap Tuoi: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap DiaChi: ");
            address = Console.ReadLine();
        }
        public override string ToString()
        {
            return string.Format("ID: {0} - fullName: {1} - Age: {2} - address: {3}", ID, fullName, age, address);
        }
        public Person()
        {

        }
        public Person(string iD,string fullName,int age, string address)
        {
            this.iD = iD;this.fullName = fullName;this.address=address,this.age = age;
        }
    }
}
