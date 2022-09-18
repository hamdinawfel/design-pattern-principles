using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class CEO : BaseEmployee, IManager
    {
        public virtual void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;
            Salary = baseAmount + (rank * 6);
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("I'm reviewing a performance report us CEO");
        }

        public void FireSomeone()
        {
            Console.WriteLine("You are fired!");
        }

    }
}
