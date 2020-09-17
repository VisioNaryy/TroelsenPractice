using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PLINQDataProcessingWithCancellation
{
    class Program
    {
        static CancellationTokenSource cancelToken = new CancellationTokenSource();
        static void Main(string[] args)
        {
            Console.WriteLine("Start any key to start processing");
            Console.ReadKey();
            Console.WriteLine("Processing");
            Task.Factory.StartNew(() => ProcessIntData());
            Console.ReadLine();
        }
        static void ProcessIntData()
        {
            // Get a very large array of integers.
            int[] source = Enumerable.Range(1, 10_000_000).ToArray();
            // Find the numbers where num % 3 == 0 is true, returned
            // in descending order.
            int[] modThreelsZero = null;
            try
            {
                int[] modThreeIsZero = (from num in source.AsParallel().WithCancellation(cancelToken.Token)
                                        where num % 3 == 0
                                        orderby num descending
                                        select num).ToArray();
                Console.WriteLine($"Found { modThreeIsZero.Count()} numbers that match query!");
            }
            catch (OperationCanceledException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
