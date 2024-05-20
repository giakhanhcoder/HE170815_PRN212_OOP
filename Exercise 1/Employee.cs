using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public abstract class Employee : IEmployee
    {
        public string Name { get; set; }
        public int PaymentPerHour {  get; set; }

        public Employee(string name, int paymentPerHour) {
            Name = name;
            PaymentPerHour = paymentPerHour;
        }

        public abstract int calculateSalary();

        public String getName()
        {
            return Name;
        }

        public override string? ToString()
        {
            return $"Name: {Name}, Payment Per Hour: {PaymentPerHour}";
        }
    }
}
