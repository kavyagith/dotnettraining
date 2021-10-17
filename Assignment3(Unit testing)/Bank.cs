using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
	public class BankAcc : Program
	{
		List<double> DepositList = new List<double>();
		public string Username { get; set; }

		public string AccountNumber { get; set; }

		public string Password { get; set; }

		public double Balance { get; set; }

		public int rate = 12;

		public BankAcc(string username,string password,string accountNumber, double Balance)
		{
			this.Username = username;
			this.Password = password;
			this.AccountNumber = accountNumber;
			this.Balance = Balance;

			Console.WriteLine("Username: {0} , Balance: {1}", username, Balance);
			NextMenu();
		}

		public void NextMenu()
		{
			double balance = Balance;
			Console.WriteLine("Enter 1 for Withdrawl, 2 for Deposit, 3 for create account, 4 for logout");
			string StringMenu = Console.ReadLine();
			string user=Username; 
			string pswd=Password; 
			string accounNum= AccountNumber;
			int NextChoice = Convert.ToInt32(StringMenu);
			switch (NextChoice)
			{
				case 1:
					Withdraw(user,pswd,accounNum);
					break;
				case 2:
					Deposit(user, pswd, accounNum);
					break;
				case 3:
					CreateAccount();
					break;
				case 4:
					Logout(user, pswd, accounNum);
					break;
				
			}
		}

		public bool CreateAccount()
        {
			string name;
			Random generator = new Random();
			String accountNumber = generator.Next(0, 1000000).ToString("D6");
			Console.WriteLine("Enter username: ");
			name = Console.ReadLine();
			Console.WriteLine("Account opened");
			Console.WriteLine("Account number is:"+ accountNumber);
			return true;
		}

		public double Withdraw(string user, string pswd, string accounNum)
		{
			Console.WriteLine("Enter username: ");
			user = Console.ReadLine();
			Console.WriteLine("Enter password");
			pswd = Console.ReadLine();
			Console.WriteLine("Enter account number: ");
			accounNum = Console.ReadLine();
			Console.WriteLine("Available Balance: {0}", Balance);
			Console.WriteLine("How much would you like to withdraw?: ");
			double WithdrawAmt = Convert.ToDouble(Console.ReadLine());
			if(WithdrawAmt>Balance)
            {
				throw new InvalidOperationException("Insufficient balance");

			}
			else if (user!=Username)
			{
				throw new InvalidOperationException("Invalid username");
			}
			else if(pswd!=Password)
            {
				throw new InvalidOperationException("Invalid password");
			}
			else if (accounNum != AccountNumber)
			{
				throw new InvalidOperationException("Invalid Account number");
			}
			else
            {
				Console.WriteLine("Successfull operation");
				Balance = Balance -= WithdrawAmt;
			}
			
			Console.WriteLine(Balance);
			NextMenu();
			return WithdrawAmt;
		}

		public double Deposit(string user, string pswd, string accounNum)
		{
			Console.WriteLine("Enter username: ");
			user = Console.ReadLine();
			Console.WriteLine("Enter password");
			pswd = Console.ReadLine();
			Console.WriteLine("Enter account number: ");
			accounNum = Console.ReadLine();
			Console.WriteLine("Available Balance: {0}", Balance);
			Console.WriteLine("How much would you like to deposit?: ");
			double DepositAmt = Convert.ToDouble(Console.ReadLine());
			DepositList.Add(DepositAmt);
			if (DepositAmt <= 0)
			{
				throw new InvalidOperationException("Invalid inpute");

			}
			else if (user != Username)
			{
				throw new InvalidOperationException("Invalid username");
			}
			else if (pswd != Password)
			{
				throw new InvalidOperationException("Invalid password");
			}
			else if (accounNum != AccountNumber)
			{
				throw new InvalidOperationException("Invalid username");
			}
			else
			{
				Balance = Balance + DepositAmt;
				Console.WriteLine("Available balance" + Balance);
			}
			NextMenu();
			return DepositAmt;
		}

		public bool Logout(string user, string pswd, string accounNum)
		{
			Console.WriteLine("Enter username: ");
			user = Console.ReadLine();
			Console.WriteLine("Enter password");
			pswd = Console.ReadLine();
			Console.WriteLine("Enter account number: ");
			accounNum = Console.ReadLine();
			if (user != Username)
			{
				throw new InvalidOperationException("Invalid username");
			}
			else if (pswd != Password)
			{
				throw new InvalidOperationException("Invalid password");
			}
			else if (accounNum != AccountNumber)
			{
				throw new InvalidOperationException("Invalid username");
			}
			else
			{
				Console.WriteLine("Goodbye: " + Username);
				return true;
			}
		}

		
	}
}