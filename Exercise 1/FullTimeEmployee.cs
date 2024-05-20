using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    internal class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string name, int paymentPerHour) 
            : base(name, paymentPerHour)
        {
        }

        public override int calculateSalary()
        {
            return 8 * PaymentPerHour;
        }

        public override string? ToString()
        {
            return base.ToString() + $", Salary: {calculateSalary()}";
        }
    }
}
