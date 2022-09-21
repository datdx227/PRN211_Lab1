using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Player : Person
    {
        //public string code;
        //public string name;
        //public string address;
        //public int shirtnumber; 


        // public string position;
        //public int salary;

        public Player()
        {
        }

        //public Player(string code, string name, string address, string position, int salary)
        //{
        //    Code = code;
        //    Name = name;
        //    Address = address;
        //    Position = position;
        //    Salary = salary;
        //}

        /*public Player(string code, string name, string address, int shirtnumber, string position, int salary)
        {
            Code = code;
            Name = name;
            Address = address;
            Shirtnumber = shirtnumber;
            Position = position;
            Salary = salary;
        }*/
        public Player(string code, string name, string address, int shirtnumber, string position, int salary) : base(code, name, address, position, salary)
        {
            Shirtnumber = shirtnumber;
        }
        //public string Code { get => code; set => code = value; }
        //public string Name { get => name; set => name = value; }
        //public string Address { get => address; set => address = value; }
        public int Shirtnumber { get; set; }
        //public string Position { get => position; set => position = value; }
        //public int Salary { get => salary; set => salary = value; }

        public override string? ToString()
        {
            return Code + "\t" + Name + "\t" + Address + "\t" + Shirtnumber + "\t" + Position + "\t" + Salary;
        }
    }
}
