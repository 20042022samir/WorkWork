

using okay.Methods;
using okay.Services;

StudentServices studentServices=new StudentServices();
TeacherService teacherService=new TeacherService();
Console.WriteLine("hansi emeliyyati secmek isteyirsiniz?");
HERE:
Console.ForegroundColor= ConsoleColor.Green;
Console.WriteLine("1-->TELEBE");
Console.WriteLine("2-->MUELLIM");
try
{
    
    int choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1)
    {
        Console.WriteLine("1-->Telebe elave etmek");
        Console.WriteLine("2-->telebe gostermek");
        Console.WriteLine("3-->telebe axtarmaq");
        Console.WriteLine("4-->emeliyyati saxlamaq");
        int choice2 = Convert.ToInt32(Console.ReadLine());


        while (choice2 != 4)
        {
            switch (choice2)
            {
                case 1:
                    studentServices.create();
                    break;
                case 2:
                    studentServices.show();
                    break;
                case 3:
                    studentServices.ShowById();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("yalniz 4 emelliyyat var");
                    break;
            }
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("1-->Telebe elave etmek");
            Console.WriteLine("2-->telebe gostermek");
            Console.WriteLine("3-->telebe axtarmaq");
            Console.WriteLine("4-->emeliyyati saxlamaq");
            choice2 = Convert.ToInt32(Console.ReadLine());
        }
    }
    else if (choice == 2)
    {
        Console.WriteLine("1-->muellim elave etmek");
        Console.WriteLine("2-->muellim gostermek");
        Console.WriteLine("3-->muellim axtarmaq");
        Console.WriteLine("4-->emeliyyati saxlamaq");
        int choice3 = Convert.ToInt32(Console.ReadLine());
        while (choice3 != 4)
        {
            switch (choice3)
            {
                case 1:
                    teacherService.create();
                    break;
                case 2:
                    teacherService.show();
                    break;
                case 3:
                    teacherService.ShowById();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("yalniz 4 emelliyyat var");
                    break;
            }
            Console.WriteLine("1-->muellim elave etmek");
            Console.WriteLine("2-->muellim gostermek");
            Console.WriteLine("3-->muellim axtarmaq");
            Console.WriteLine("4-->emeliyyati saxlamaq");
            choice3 = Convert.ToInt32(Console.ReadLine());
        }
    }
}
catch (Exception)
{
    Console.WriteLine("duzgun bir sey daxil et");
    goto HERE;
}
