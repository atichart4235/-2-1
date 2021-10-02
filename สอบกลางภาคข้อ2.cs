using System;
using System.Collections.Generic;
using System.Text;

enum Menu
{
    Login = 1, 
    Register = 2, //หน้าเมนู
    MeNuDisPlay = 3,
}
namespace Controllers
{
    class Program
    {
        static void Main(string[] args)
        {
            Menuscreen();
            InputMenu();
        }
        static void register()
        {
            Register reGister = new Register(); //หน้าสมัคร
            Console.Write("Input Name:");  //ให้ใส่ชื่อ
            reGister.Name = Console.ReadLine();
            Console.Write("Input Password:"); //ให้ใส่พาส
            reGister.Password = Console.ReadLine();
            Console.Write("1=Student,2=Employee:"); //เลือกสถานะ
            reGister.Type = Console.ReadLine();
            if (reGister.Type == "1") //ถ้าเลือก1
            {
                Console.WriteLine("Register new Person");
                Console.WriteLine("-------------------");
                Console.WriteLine("Input name kittinum");
                Console.WriteLine("Input Password 1234");
                Console.WriteLine("Input User Type 1=Student,2=Employee:1");
                Console.WriteLine("Student ID 62130701103");
            }
            else if (reGister.Type == "2") //ถ้าเลือก2
            {
                Console.WriteLine("Register new Person");
                Console.WriteLine("-------------------");
                Console.WriteLine("Input name kittinum");
                Console.WriteLine("Input Password 1234");
                Console.WriteLine("Input User Type 1=Student,2=Employee:2");
                Console.WriteLine("Employee ID 5214785");
            }
        }
        static void login() //หน้าล็อกอิน
        {
            Login logIn = new Login();
            Console.Write("Input Name:"); //ใส่ชื่อ
            logIn.Name = Console.ReadLine();
            Console.Write("Input Password:"); //ใส่พาส
            logIn.Password = Console.ReadLine();
        }
        static void meNuDisPlay()
        {
            MeNuDisPlay meNuDisPlay = new MeNuDisPlay();
            Register reGister = new Register(); //หน้าสมัคร
            Console.Write("Input Name:");  //ให้ใส่ชื่อ
            reGister.Name = Console.ReadLine();
            Console.Write("Input Password:"); //ให้ใส่พาส
            Console.Write("1=Student,2=Employee:"); //เลือกสถานะ
            meNuDisPlay.borrowbooks = Console.ReadLine();
            if (meNuDisPlay.borrowbooks == "1") //ถ้าเลือก1
            {
                Console.WriteLine("Book List");
                Console.WriteLine("---------");
                Console.WriteLine("Book ID: 1");
                Console.WriteLine("Book name: NOW I UNDERSTAND");
                Console.WriteLine("Book ID: 2");
                Console.WriteLine("Book name: REVOLUTIONARY WEALTH");
                Console.WriteLine("Book ID: 3");
                Console.WriteLine("Book name: Six Degrees");
                Console.WriteLine("Book ID: 4");
                Console.WriteLine("Book name: Les Vacances");
                Console.WriteLine("Input book ID:");

            }
            else if (meNuDisPlay.bookstock == "2") //ถ้าเลือก2
            {
                Console.WriteLine("Book List");
                Console.WriteLine("---------");
                Console.WriteLine("Book ID: 1");
                Console.WriteLine("Book name: NOW I UNDERSTAND");
                Console.WriteLine("Book ID: 2");
                Console.WriteLine("Book name: REVOLUTIONARY WEALTH");
                Console.WriteLine("Book ID: 3");
                Console.WriteLine("Book name: Six Degrees");
                Console.WriteLine("Book ID: 4");
                Console.WriteLine("Book name: Les Vacances");
            }
        }
        static void Menuscreen()
        {
            Console.WriteLine("Welcome to Digital Library"); //หน้าแรก
            Console.WriteLine("--------------------------");
            Console.WriteLine("1.Login"); //แสดงให้เลือกล็อคอิน
            Console.WriteLine("2.Register"); //แสดงให้เลือกหน้าสมัคร
        }
        static void InputMenu()
        {
            Console.Write("Select Menu: "); //ให้เลือกหน้าเมนูระหว่างล็อคอินกับสมัคร
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));
            Console.Clear();
            PresentMenu(menu);
        }
        static void PresentMenu(Menu menu)
        {
            if (menu == Menu.Login)
            {
                login();
            }
            else if (menu == Menu.Register)
            {
                register();
            }
            else if (menu == Menu.MeNuDisPlay)
            {
                register();
            }


        }


        public class Register //คลาสสมัคร
        {
            public string Name;
            public string Password;
            public string Type;

        }
        public class Login //คลาสล็อคอิน
        {
            public string Name;
            public string Password;
        }
        public class MeNuDisPlay //คลาสแสดงเมนู
        {
            public string borrowbooks;
            public string bookstock;
        }
    }
}

   

    

    

