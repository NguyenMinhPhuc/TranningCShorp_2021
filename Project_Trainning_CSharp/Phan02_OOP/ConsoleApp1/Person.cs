using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP
{
  public  class Person:IComparable
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
            //MyString myString = new MyString();
            //myString.Display();
         

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

        public override bool Equals(object obj)
        {
            return this.iD.Equals(((Person)obj).ID);
        }
        public int CompareTo(object obj)
        {
            if(obj is Person)
                return this.ID.CompareTo(((Person)obj).ID);
            return -1;
        }

        public Person()
        {

        }
        public Person(string iD,string fullName,int age, string address)
        {
            this.iD = iD;this.fullName = fullName;this.address = address; this.age = age;
        }
        ////a, b. parameter
        //Person person;//global trong class person
        //public int Add(int a,int b)
        //{
        //    person = new Person();
        //    int c = a + b;
        //    return c;
        //}
        //public void Display()
        //{
        //    if(person!=null)
        //    {
        //        Person person;
        //        int j = 0;
        //        for (int i = 0; i < 8; i++)
        //        {
        //             j = 8;
        //            person = new Person();

        //        }
        //        Console.Write(j);
        //    }
        //    else
        //    {
        //        Console.Write(j);
        //    }
        //}
        
        
    }
}
