using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CONGTY
{
    public class Salary
    {
        private Date paydate;
        private double total;
        public double SalaryCalculation(double rate, double wage)
        {
            total = rate * wage;
            return total;
        }

        public override string ToString()
        {
            return $"Pay date: {paydate.ToString()}. Wage: {total}";
        }

    }
}