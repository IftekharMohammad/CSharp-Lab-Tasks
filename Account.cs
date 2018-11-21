using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    public struct customdate{
        public int day;
        public int month;
        public int year;
    }

    public class Account {
        private string accountid;
        private string accountname;
        private double balance;
        private  customdate accountopeningdate;

        public string AccountID{
            set {
                this.accountid = value;
            }
            get{
                return this.accountid;
            }

        }
        public string AccountName{
            set {
                this.accountname = value;
            }
            get{
                return this.accountname;
            }

        }
        public double AccountBalance{
            set {
                this.balance = value;
            }
            get{
                return this.balance;
            }

        }
        public customdate AccountOpeningDate{
            set {
                this.accountopeningdate = value;
            }
            get{
                return this.accountopeningdate;
            }

        }
        public void ShowIndividual() {
            Console.WriteLine("Account ID: {0}", this.accountid);
            Console.WriteLine("Account Name: {0}", this.accountname);
            Console.WriteLine("Account Balance: {0}", this.balance);
            Console.WriteLine("Account Opening Date: {0}/{1}/{2}", this.accountopeningdate.day, this.accountopeningdate.month, this.accountopeningdate.year);
            Console.WriteLine("----------------------oooo-------------------------");
        }

        public void Diposit(double money){
            this.balance = this.balance + money;
            this.ShowIndividual();
        }

        public void Withdraw(double money) {
            this.balance = this.balance - money;
            this.ShowIndividual();
        }
        public static void Exchange(Account id1, Account id2, double amount) {
            id1.Withdraw(amount);
            id2.Diposit(amount);
        } 

    }
    class Program
    {
        static void Main(string[] args)
        {
            customdate[] aaa = new customdate[2];            
            aaa[0].day = 1;
            aaa[0].month = 2;
            aaa[0].year = 2017;

            aaa[1].day = 3;
            aaa[1].month = 4;
            aaa[1].year = 2018;

            Account[] accountdata = new Account[2];
            accountdata[0] = new Account();
            accountdata[0].AccountID = "A-10001";
            accountdata[0].AccountName = "AAAAA";
            accountdata[0].AccountBalance = 100000;
            accountdata[0].AccountOpeningDate = aaa[0];

            accountdata[1] = new Account();
            accountdata[1].AccountID = "A-10002";
            accountdata[1].AccountName = "BBBBB";
            accountdata[1].AccountBalance = 500000;
            accountdata[1].AccountOpeningDate = aaa[1];

            bool exit = true;

            while (exit) {
                string id;
                bool found = false;
                Console.WriteLine("Press 1 for Show Individual");
                Console.WriteLine("Press 2 for Show All");
                Console.WriteLine("Press 3 for Deposit");
                Console.WriteLine("Press 4 for Withdraw");
                Console.WriteLine("Press 5 for Exchange");
                Console.WriteLine("Press 6 for Exit");
                Console.WriteLine("Input Your Option:");
                int option;
                option =Convert.ToInt32(Console.ReadLine());

                switch (option) {
                    case 1:
                        Console.WriteLine("Enter Account ID: ");
                        found = false;
                        id =Console.ReadLine();
                        for (int i = 0; i < accountdata.Length; i++) {
                            if (accountdata[i].AccountID == id) {
                                accountdata[i].ShowIndividual();
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("Data Not Found");
                        }
                        break;
                    case 2:
                        for (int i = 0; i < accountdata.Length; i++) {
                            accountdata[i].ShowIndividual();
                        }
                            break;
                    case 3:
                        Console.WriteLine("Enter Account ID: ");
                        found = false;
                        id =Console.ReadLine();
                        for (int i = 0; i < accountdata.Length; i++) {
                            if (accountdata[i].AccountID == id) {
                                Console.WriteLine("Enter Amount: ");
                                double amount;
                                amount = Convert.ToDouble(Console.ReadLine());
                                accountdata[i].Diposit(amount);
                                found = true;
                            }
                            if (found)
                            {
                                break;
                            }
                            else {
                                Console.WriteLine("Data Not Found");
                            }
                        }
                            break;
                     case 4:
                        Console.WriteLine("Enter Account ID: ");
                        found = false;
                        id =Console.ReadLine();
                        for (int i = 0; i < accountdata.Length; i++) {
                            if (accountdata[i].AccountID == id) {
                                Console.WriteLine("Enter Amount: ");
                                double amount;
                                amount = Convert.ToDouble(Console.ReadLine());
                                accountdata[i].Withdraw(amount);
                                found = true;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("Data Not Found");
                        }
                            break;

                    case 5:
                            bool f1 = false, f2 = false;
                            Account a1=null, a2=null;
                            Console.WriteLine("Enter Your Account Number:");
                            string id1 = Console.ReadLine();
                            for (int i = 0; i < accountdata.Length; i++)
                            {
                                if (accountdata[i].AccountID == id1)
                                {
                                    a1 = accountdata[i];
                                    f1 = true;
                                    break;
                                }
                            }
                                if (!f1) {
                                    Console.WriteLine("Data Not Found");
                                    break;
                                }
                            
                            Console.WriteLine("Enter Reciever Account Number:");
                            string id2 = Console.ReadLine();
                            for (int i = 0; i < accountdata.Length; i++) {
                                if (accountdata[i].AccountID == id2) {
                                    a2 = accountdata[i];
                                    f2 = true;
                                    break;
                                }
                            }
                                if (!f2) {
                                    Console.WriteLine("Data Not Found");
                                    break;
                                }
                            Console.WriteLine("Enter Amount:");
                            double aa =Convert.ToDouble(Console.ReadLine());
                                Account.Exchange(a1,a2,aa);
                                break;
                    case 6:
                            exit = false;
                            break;
                }
            }

        }
    }
}
