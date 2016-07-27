using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedRockBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //instances of the class->objects

           //var account= new Account();
           // //account.Id = 1;
           // account.Name = "Sudha";
           // account.Deposit(400);
           // account.Withdraw(200);

           // // account.Balance = 10000000;
           // Console.WriteLine("Id:{0},Name:{1},Balance:{2:c}", account.Id, account.Name, account.Balance);
            
           // var account2 = new Account();
           // account2.Name = "Savings";
           // Console.WriteLine("Id:{0},Name:{1},Balance:{2:c}", account2.Id, account2.Name, account2.Balance);

          Customer c1=  Bank.CreateCutomer("Sudha","test@test.com","RedmondRidge, WA")

                    


        }
    }
}
