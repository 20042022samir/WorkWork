using okay.Interfaces;
using okay.Methods;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okay.Services
{
    internal class TeacherService : Interface1
    {
        Teacher[] teachers = { };
        int counter2 = 0;
        public void create()
        {
            Teacher teacher = new Teacher();
            Console.WriteLine("zehmet olmasa muellimin adini daxil edin");
            ENTER:
            teacher.Name = Console.ReadLine();
            if(teacher.Name.Length<3 || teacher.Name.Length > 30)
            {
                Console.WriteLine("muellimin adi ve ya soyadi 3 den az 30 dan boyuk ola bilmez");
                Console.WriteLine("zehmet olmasa bir daha daxil edin");
                goto ENTER;
            }
            Console.WriteLine("muellimin soyadini daxil edin");
            teacher.surname = Console.ReadLine();
            AGAIN:
            if(teacher.surname.Length<3 || teacher.surname.Length> 30)
            {
                Console.WriteLine("muellimin adi ve ya soyadi 3 den az 30 dan boyuk ola bilmez");
                Console.WriteLine("zehmet olmasa bir daha daxil edin");
                goto AGAIN;
            }
            Console.WriteLine("muellimin qrupunu daxil edin");
            AGAINN:
            teacher.GroupNumber = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(teacher.GroupNumber))
            {
                Console.WriteLine("qrupun nomresi bos buraxila bilmez");
                Console.WriteLine("bir daha daxil edin");
                goto AGAINN;
            }
            counter2++;
            teacher.ID = counter2;
            Array.Resize(ref teachers, teachers.Length + 1);
            teachers[teachers.Length - 1] = teacher;
        }

        public void show()
        {
            if (teachers.Length == 0)
            {
                Console.WriteLine("heleki hec bir muellim yaradilmayib");
            }
            else
            {
                foreach (Teacher item in teachers)
                {
                    Console.WriteLine($"muellim adi: {item.Name} muellim soyadi: {item.surname} muellim qrupu: {item.GroupNumber} muellim ID: {item.ID}");
                }
            }
        }

        public void ShowById()
        {
            Teacher teacher= new Teacher();
            Console.WriteLine("muellim ID ni daxil edin");
            int enter=Convert.ToInt32(Console.ReadLine());
            if (enter == teacher.ID)
            {
                Console.WriteLine($"muellimin adi: {teacher.Name} muellimin soyadi: {teacher.surname} muellimin qrupu: {teacher.GroupNumber}");
            }
        }
    }
}
