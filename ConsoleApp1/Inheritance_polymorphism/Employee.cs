using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_polymorphism
{
    abstract class Employee
    {
        protected BenefitPackage empBenefits = new BenefitPackage();
        public BenefitPackage Benefits { get { return empBenefits; } set { empBenefits = value; } }

        protected string empName;
        protected int empID;
        protected float currPay;
        protected int empAge;
        protected string empSSN;
        public Employee(string name, int age, int id, float pay, string ssn)
        {
            empName = name;
            empAge = age;
            empID = id;
            currPay = pay;
            empSSN = ssn;
        }
        public double GetBenefitCost()
        {
            return empBenefits.ComputePayDeduction();
        }
        public virtual void GiveBonus(float amount)
        {
            currPay += amount;
        }
        public virtual void DisplayStats()
        {
            Console.WriteLine("Name : {0}", empName);
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("Age: {0}", empAge);
            Console.WriteLine("Pay: {0}", currPay);
            Console.WriteLine("SSN: {0}", empSSN);
        }

    }
}
