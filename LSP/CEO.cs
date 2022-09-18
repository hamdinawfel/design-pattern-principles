using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class CEO: Employee
    {
        public override void AssignManager(Employee manager)
        {
            throw new Exception("A CEO doesn't have a manager");
        }

        public virtual void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;
            Salary = baseAmount + (rank * 6);
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("I'm reviewing a performance report");
        }

        public void FireSomeone()
        {
            Console.WriteLine("You are fired!");
        }
    }
}
