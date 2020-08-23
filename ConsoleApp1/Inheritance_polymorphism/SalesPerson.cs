using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_polymorphism
{
    class SalesPerson: Employee
    {
        public int SalesNumber { get; set; }
        public SalesPerson(string fullName, int age, int empID, float currPay,string ssn, int numbOfSales) 
            : base(fullName, age, empID, currPay, ssn)
        {
            // Это принадлежит нам'
            SalesNumber = numbOfSales;
        }
        public override sealed void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if (SalesNumber >= 0 && SalesNumber <= 100)
                salesBonus = 10;
            else
            {
                if (SalesNumber >= 101 && SalesNumber <= 200)
                    salesBonus = 15;
                else
                    salesBonus = 20;
            }
            base.GiveBonus(amount * salesBonus);
        }
    }
}

