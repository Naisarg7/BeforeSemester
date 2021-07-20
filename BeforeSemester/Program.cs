using System;

namespace BeforeSemester
{
    class Access
    {
        public string userName;

        public void getAccess()
        {
            Console.WriteLine("Enter your name : ");
            userName = Console.ReadLine();
        }
    }

    class Display
    {
        Access a = new Access();
        public void showInfo()
        {   
            a.getAccess();
            Console.WriteLine("Hello {0}",a.userName);
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {
            Display record = new Display();
            record.showInfo();
        }
    }
}
