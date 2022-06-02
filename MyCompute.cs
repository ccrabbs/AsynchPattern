using System.Threading;

namespace AsynchPattern
{
    internal class MyCompute
    {
        public double Compute(int a, int b)
        {
            double res = 4.7 * a - b / 3.5 + 25.8;
            // assume it takes 10 seconds to complete
            Thread.Sleep(10000);
            return res;
        }
    }
}