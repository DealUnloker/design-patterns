using System;
using System.Collections;

namespace LB_2
{
    class EmployeeComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            int result = (new CaseInsensitiveComparer()).Compare(((IEmployee)y).countMounthWage(), ((IEmployee)x).countMounthWage());
            if (result == 0)
            {
                result = (new CaseInsensitiveComparer()).Compare(((IEmployee)x).getName(), ((IEmployee)y).getName());
            }
            return result;
        }
    }
}
