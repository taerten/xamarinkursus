using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _25_08_2016_Async
{
    class Program
    {
        static void Main(string[] args)
        {
             MainAsync().Wait();
            //MainAsync();
            
        }
                // Asymc/await
        public static async Task MainAsync()
        {
            var stopWatch = new Stopwatch();

            stopWatch.Start();
                

             Task t1 = Task.Delay(2000);
             Task t2 = Task.Delay(1000);
             Task t3 = Task.Delay(3000);

            // throw new Exception();

            await Task.WhenAll(t1, t2, t3);
            await Task.WhenAny(t1, t2, t3);

            stopWatch.Stop();
                Console.WriteLine(stopWatch.Elapsed);
                Console.ReadKey();
            
        }
        
    }
}
