using System;

namespace FunWithEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpType emp = EmpType.Contractor;
            Console.WriteLine((int)emp);

           
        }   
        enum EmpType
        {
            Manager,
            Grunt,
            Contractor,
            VicePresident
        }
    
    }
}
