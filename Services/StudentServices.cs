using okay.Interfaces;
using okay.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okay.Services
{
    internal class StudentServices : Interface1
    {
        Students[] students = { };
        int counter = 0;
        public void create()
        {
            Students student= new Students();
            Console.WriteLine("zehmet olmasa telebenin adini daxil edin");
            SELECT:
            student.Name = Console.ReadLine();
            if(student.Name.Length<3 || student.Name.Length> 30)
            {
                Console.WriteLine("telebenin adi ve ya soyadi 3 den az 30-dan cox ola bilmez");
                Console.WriteLine("zehmet olmasa bir daha daxil edin");
                goto SELECT;
            }
            Console.WriteLine("telebenin soyadini daxil edin");
            CHOOSE:
            student.surname = Console.ReadLine();
            if(student.surname.Length<3 || student.surname.Length> 30)
            {
                Console.WriteLine("telebenin adi ve ya soyadi 3 den az 30-dan cox ola bilmez");
                Console.WriteLine("zehmet olmasa bir daha daxil edin");
                goto CHOOSE;
            }
            Console.WriteLine("telebenin qrupunu daxil edin");
            DECIDE:
            student.GroupNumber = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(student.GroupNumber))
            {
                Console.WriteLine("qrup nomresine bos qoyula bilmez");
                Console.WriteLine("zehmet olmasa yeniden daxil edin");
                goto DECIDE;
            }
            counter++;
            student.ID = counter;
            Array.Resize(ref students, students.Length + 1);
            students[students.Length-1] = student;
           
        }

        public void show()
        {
            if (students.Length == 0)
            {
                Console.WriteLine("heleki hec bir telebe yaradilmayib");
            }
            else
            {
                foreach (Students item in students)
                {
                    Console.WriteLine($"telebe adi: {item.Name} telebe soyadi: {item.surname} telebe qrupu: {item.GroupNumber} telebe ID: {item.ID}");
                }
            }
        }

        public void ShowById()
        {
            Students student = new Students();
            Console.WriteLine("telebe Id daxil edin");
            int Id=Convert.ToInt32(Console.ReadLine());
            foreach  (Students item in students)
            {
                if (item.ID == Id)
                {
                    Console.WriteLine($"telebenin adi: {item.Name}  telebenin soyadi: {item.surname}  telebenin qrupu: {item.GroupNumber}");
                }
            }
        }
    }
}

