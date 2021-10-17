using System;

namespace Bank
{
    public class Program
    {
        static void Main(string[] args)
        {
            string username ;
            string password;
            string accountNum;
            Console.WriteLine("Enter username: ");
            username = Console.ReadLine();
            Console.WriteLine("Enter password");
            password = Console.ReadLine();
            Console.WriteLine("Enter Account number: ");
            accountNum = Console.ReadLine();
            BankAcc newAccount = new BankAcc(username,password,accountNum, 2000);
        }
    }
}
