using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Coach : Person
    {
        //public int yearsofExp;
        public int YearsofExp { get; set; }

        public Coach()
        {
        }

        public Coach(string code, string name, string address, string position, int salary, int yearsofExp) : base(code, name, address, position, salary)
        {           
            YearsofExp = yearsofExp;
        }

        public override string? ToString()
        {
            return Code + "\t" + Name + "\t" + Address + "\t" + "\t" + Position + "\t" + Salary + "\t" + YearsofExp;
        }
    }
}
