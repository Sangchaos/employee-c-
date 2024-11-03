using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace CONGTY
{
    public abstract class Employee
    {
        private string id;
        private string name;
        private Date birthDay;
        private Date hireDay;
        private double wage;

        protected Employee(string id, string name, Date birthDay, Date hireDay, double wage)
        {
            Id = id;
            Name = name;
            BirthDay = birthDay;
            HireDay = hireDay;
            Wage = wage;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public Date BirthDay { get => birthDay; set => birthDay = value; }
        public Date HireDay { get => hireDay; set => hireDay = value; }
        public double Wage { get => wage; set => wage = value; }

        public abstract double calSalary();

        public override string ToString()
        {
            return $"Employee Information:\n" +
                   $"ID: {Id}\n" +
                   $"Name: {Name}\n" +
                   $"Birth Date: {BirthDay.ToString()}\n" +
                   $"Hire Date: {HireDay.ToString()}\n" +
                   $"Salary: {calSalary()}$";
        }




    }


}