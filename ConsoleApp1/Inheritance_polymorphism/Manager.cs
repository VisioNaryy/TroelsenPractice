﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_polymorphism
{
    class Manager : Employee
    {
        public int StockOptions { get; set; }


        public Manager(string fullName, int age, int empID, float currPay, string ssn, int numbOfOpts)
                        : base(fullName, age, empID, currPay, ssn)
        {
            // Это свойство определено в классе Manager.
            StockOptions = numbOfOpts;
        }
        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOptions += r.Next(500);
        }
        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Stock Options: {0}", StockOptions);
        }
    }
}
