using System;
using System.Threading.Tasks;

namespace ass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args[0]);
            RealTimeCityBikeDataFetcher fetchiBoi = new RealTimeCityBikeDataFetcher();
            Task<int> task = fetchiBoi.GetBikeCountInStation(args[0]);
            task.Wait();
            int bikes = task.Result;
            Console.WriteLine("Bikes awailable: " + bikes.ToString());
        }
    }
}
