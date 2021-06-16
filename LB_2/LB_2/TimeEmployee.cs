using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_2
{
    class TimeEmployee : IEmployee
    {
        public double WagePerHour { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }

        public TimeEmployee(string name, int id, double wage)
        {
            this.Name = name;
            this.ID = id;
            this.WagePerHour = wage;
        }
        public double countMounthWage()
        {
            return 5 * 4 * 8 * WagePerHour;
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
