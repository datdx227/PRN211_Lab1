using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Person
    {
        //public string code;
        //public string name;
        //public string address;
        //public string position;
        //public int salary;
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public Person()
        {

        }

        public Person(string code, string name, string address, string position, int salary)
        {
            Code = code;
            Name = name;
            Address = address;
            Position = position;
            Salary = salary;
        }

        
    }
}
