using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Emailnizi daxil edin : ");
            string email = Console.ReadLine();
            Console.WriteLine("Passwordunuzu saxil edin : ");
            string password = Console.ReadLine();


            User user1 = new User(email,password);
            
        }
    }
}
