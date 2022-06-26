using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grouped
{
    internal class Bank
    {
        public int accountNO;
        public string firstname;
        public string lastname;
        public double balance;
        public static List<Bank> banks = new List<Bank>();
        
    }
    public void addcustomer()
    {
        
    }

    public void deposite(double amt)
    {

        Bank.Add(this);
     }
    public Bank(int accountno,string firstname,string lastname,double amount)
    {
        
    }
}
