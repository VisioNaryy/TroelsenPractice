using System;

namespace FunWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(2, 3, out int sum);
            Console.WriteLine(sum);

            // Передать список значений double, разделенных запятыми...
            double average;
            average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
            Console.WriteLine("Average of data is: {0}", average);
            // ... или передать массив значении double.
            double[] data = { 4.0, 3.2, 5.7 };
            average = CalculateAverage(data);
            Console.WriteLine("Average of data is: {0}", average);
            // Среднее из 0 равно О!
            Console.WriteLine("Average of data is: {0}", CalculateAverage());
            Console.ReadLine();

        }
        static int Add(int x, int y, out int sum)
        {
            return sum = x + y;
        }
        
        static double CalculateAverage(params double[] values)
        {
            double sum = 0;
            if (values.Length==0)
                Console.WriteLine(sum);
            for(int i=0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return (sum / values.Length);
        }

        //local function
        static int AddWrapper(int x, int y)
        {
           return Add();
           int Add()
            {
                return x + y;
            }
        }
    }
}
