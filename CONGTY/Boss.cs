using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CONGTY
{
    public class Boss : Employee
    {
        public Boss(string id, string name, Date birthDay, Date hireDay, double wage) : base(id, name, birthDay, hireDay, wage)
        {
        }

        public override double calSalary()
        {
            Salary salary = new Salary();
            double total = salary.SalaryCalculation(1, Wage); 
            return total;
        }

        public override string ToString()
        {
            return "** BOSS **" + "\n" + base.ToString();
        }
    }

}