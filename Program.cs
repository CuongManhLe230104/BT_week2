using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt_week2
{
    internal class Program
    {
        class Student
        {
            public int id { get; set; }
            public string name { get; set; }
            public int age { get; set; }

            public override string ToString()
            {
                return $"Ma so sinh vien: {id}, Ten sinh vien: {name}, Tuoi cua sinh vien: {age} ";
            }
            static void Main(string[] args)
            {
                List<Student> students = new List<Student>
            {
                new Student {id = 123, name = "Le Manh Cuong", age = 22},
                new Student {id = 234, name = "Le Thanh Nhan", age = 14},
                new Student {id = 345, name = "Tran Nguyen Van Thinh", age = 19},
                new Student {id = 456, name = "Pham Minh Tan", age = 15},
                new Student {id = 567, name = "Tran Hoang The Dang", age = 17}
            };

                //a. Danh sach toan bo sinh vien
                Console.WriteLine("\nDanh sach toan sinh vien: ");
                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }

                //b. Hoc sinh co tuoi tu 15-18
                var tuoisv = students.Where(s => s.age >= 15 && s.age <= 18);
                Console.WriteLine("\nHoc sinh co do tuoi tu 15 den 18: ");
                foreach (var student in tuoisv)
                {
                    Console.WriteLine(student);
                }

                //c.Hoc sinh co ten bat dau bang chu A
                var tensvA = students.Where(s => s.name.StartsWith("A")).ToList();
                Console.WriteLine("\nHoc sinh co ten bat dau bang chu 'A' : ");
                if (tensvA.Any())
                {
                    foreach (var student in tensvA)
                    {
                        Console.WriteLine(student);
                    }
                }
                else
                {
                    Console.WriteLine("\nKhong co hoc sinh nao ten bat dau bang chu A. ");
                }

                //d.Tinh tong tuoi cua tat ca hoc sinh
                var TongTuoi = students.Sum(s => s.age);
                Console.WriteLine($"\nTong so tuoi cua sinh vien co trong danh sach: {TongTuoi}");

                //e.Tim va in ra hoc sinh co so tuoi lon nhat
                var TuoiMax = students.OrderByDescending(s => s.age).FirstOrDefault();
                Console.WriteLine("\nHoc sinh co so tuoi lon nhat: ");
                Console.WriteLine(TuoiMax);

                //f.sap xep danh sach hoc sinh theo tuoi tang dan va in ra danh sach sau khi sap xep 
                var SapXepTuoi = students.OrderBy(s => s.age);
                Console.WriteLine("\nDanh sach hoc sinh sap khi sap xep: ");
                foreach (var student in SapXepTuoi)
                {
                    Console.WriteLine($"{student.name}");
                }
            }
        }
    }
}
