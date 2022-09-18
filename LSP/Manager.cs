using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Manager : Employee
    {
        public override void AssignManager(Employee manager)
        {
            Console.WriteLine("Managed by CEO");
        }

        public virtual void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;

            Salary = baseAmount + (rank * 4);
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("I'm reviewing a performance report");
        }
    }
}
