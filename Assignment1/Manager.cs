using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;
using System.Numerics;
using System.IO;

namespace Assignment1
{
    public class Manager : IManager
    {   
        CheckData cd = new CheckData();
        public Manager()
        {

        }

        public Manager(List<Player> listP, List<Coach> listC)
        {
            ListC = listC;
            ListP = listP;
        }

        public Manager(List<Player> listP)
        {
            ListP = listP;
        }
        public Manager(List<Coach> listC)
        {
            ListC = listC;
        }
        public List<Player> ListP { get; }
        public List<Coach> ListC { get; }
        public void inputListPlayer()
        {
            
            Console.WriteLine("Enter Player Code: ");
            string code = cd.validString();
            Console.WriteLine("Enter Name:");
            string name = cd.validString(); ;
            Console.WriteLine("Enter Address: ");
            string address = cd.validString();
            Console.WriteLine("Enter Shirt Number: ");
            int shirtnumber  = cd.validNumber(); 
            Console.WriteLine("Enter position: ");
            string position = cd.validString();
            Console.WriteLine("Enter salary: ");
            int salary = cd.validNumber();
            ListP.Add(new Player(code,name,address,shirtnumber, position,salary));
        }
        
        public void showPlayer()
        {
            foreach (Player player in ListP)
                Console.WriteLine("Player Code: " + player.Code + " Name: " + player.Name + " Address: " + player.Address + " ShirtNumber: " + player.Shirtnumber +
                    " Position: " + player.Position + " Salary: " + player.Salary);           
        }
        public void inputListCoach()
        {
            Console.WriteLine("Enter Coach Code: ");
            string code = cd.validString();
            Console.WriteLine("Enter Name:");
            string name = cd.validString();
            Console.WriteLine("Enter Address: ");
            string address = cd.validString();
            Console.WriteLine("Enter position: ");
            string position = cd.validString();
            Console.WriteLine("Enter salary: ");
            int salary = cd.validNumber();
            Console.WriteLine("Enter Year of Experience: ");
            int yearsofExp = cd.validNumber();
            ListC.Add(new Coach(code, name, address, position, salary, yearsofExp));
        }

        public void showCoach()
        {
            foreach (Coach coach in ListC)
                Console.WriteLine("Coach Code: " + coach.Code + " Name: " + coach.Name + " Address: " + coach.Address +
                    " Position: " + coach.Position + " Salary: " + coach.Salary + " Year Of Experience: " + coach.YearsofExp);
        }
        public void changerPlayer()
        {
            //CheckData cd = new CheckData();
            Console.WriteLine("Nhap vao Player code: ");
            var playerCode = Console.ReadLine();
            Console.WriteLine("Nhap vao Option: (0 de thay doi Shirt Number, 1 de thay doi Salary)");
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 0)
            {
                Console.WriteLine("Nhap vao ShirtNumber moi: ");
                int newShirt = Convert.ToInt32(Console.ReadLine());
                ListP.Where(x => x.Code == playerCode).ToList()
            .ForEach(x => x.Shirtnumber = newShirt);
            }
            if (option != 0)
            {
                Console.WriteLine("Nhap vao Salary moi: ");
                int newSalary = Convert.ToInt32(Console.ReadLine());
                ListP.Where(x => x.Code == playerCode).ToList()
            .ForEach(x => x.Salary = newSalary);
            }

        }
        public void countCoach()
        {
            int count = 0;
            foreach (Coach coach in ListC)
            {
                if(coach.YearsofExp > 3)
                {
                    count++;
                }
            }
            Console.WriteLine("So Coach co hon 3 nam kinh nghiem la: " + count);
        }
        public void sumPSalary()
        {
            int sum = 0;
            foreach (Player player in ListP)
            {
                if (player.Position.Trim().ToLower().Equals("striker"))
                {
                    sum += player.Salary;
                }
            }
            Console.WriteLine("Tong luong cua hang tien dao la: " + sum);
        }
        public void showMaxLuong()
        {
            int maxPlayer = ListP.Max(x => x.Salary);
            int maxCoach = ListC.Max(y => y.Salary);
            if(maxPlayer > maxCoach) {
                foreach (Player player in ListP)
                {
                    if (player.Salary == maxPlayer)
                    {
                        Console.WriteLine("Nguoi co luong cao nhat la Player: " + player.Name);
                    }
                }
            }
            if (maxPlayer < maxCoach)
            {
                foreach (Coach coach in ListC)
                {
                    if (coach.Salary == maxCoach)
                    {
                        Console.WriteLine("Nguoi co luong cao nhat la Coach: " + coach.Name);
                    }
                }
            }
            else
            {
                foreach (Coach coach in ListC)
                {
                    if (coach.Salary == maxCoach)
                    {
                        Console.Write("Hai nguoi dong thoi co luong cao nhat la: Coach " + coach.Name);
                    }
                }
                foreach (Player player in ListP)
                {
                    if (player.Salary == maxPlayer)
                    {
                        Console.Write(" va Player: " + player.Name + "\n");
                    }
                }
            }
        }
        public void sortPShirtNum()
        {
            Console.WriteLine("Sort the Player list by ascending Shirt Number:");
            ListP.Sort((x, y) => x.Shirtnumber.CompareTo(y.Shirtnumber));

            foreach (Player player in ListP)
                Console.WriteLine("Player Code: " + player.Code + " Name: " + player.Name + " Address: " + player.Address + " ShirtNumber: "+ player.Shirtnumber +
                    " Position: " + player.Position + " Salary: " + player.Salary) ;
        }

        public void sortCoach3Exp()
        {
            Console.WriteLine("Sort by decending the Coach list salaries:");
            ListC.Sort((x, y) => y.Salary.CompareTo(x.Salary));
            foreach (Coach coach in ListC)
            {
                if(coach.YearsofExp == 3)
                {
                    Console.WriteLine("Coach Code: " + coach.Code + " Name: " + coach.Name + " Address: " + coach.Address  +
                    " Position: " + coach.Position + " Salary: " + coach.Salary + " Year Of Experience: " + coach.YearsofExp);
                }
            }
        }
    }
}
