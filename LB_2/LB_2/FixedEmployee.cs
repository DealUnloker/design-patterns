using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_2
{
    class FixedEmployee : IEmployee
    {
        public double WagePerMonth { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }
        public FixedEmployee(string name, int id, double wage)
        {
            this.Name = name;
            this.ID = id;
            this.WagePerMonth = wage;
        }
        public double countMounthWage()
        {
            return this.WagePerMonth;
        }

        public int getID()
        {
            return this.ID;
        }

        public string getName()
        {
            return this.Name;
        }
    }
}
