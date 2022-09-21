using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment1
{
    public class CheckData
    {
        public string validString()
        {
            string output = "";
            bool isNameValid = false;
            string pattern = @"^[a-zA-Z0-9 ]+$"; // only letter, number, and at least 1 letter (neu cho phep null doi + thanh *)
            while (isNameValid == false)
            {
                output = Console.ReadLine();
                isNameValid = Regex.IsMatch(output,pattern);
                if (isNameValid == false)
                {
                    Console.WriteLine("Enter only letter and number and at least 1 letter or number!");
                    Console.Write("Please re-enter:");
                    Console.ReadKey(true); // readkey(true) khong hien thi phim an tren man hinh
                }
                else
                {

                }
            }
            return output;
        }
        public int validNumber()
        {
            int output = 0;
            bool isValid = false;
            while (isValid == false)
            {
                //convert string to int 32, tra ve true neu convert thanh cong, false neu nguoc lai
                isValid = int.TryParse(Console.ReadLine(), out output); 
                if(isValid == false)
                {
                    Console.WriteLine("Enter only integer number.");
                    Console.Write("Please enter integer: ");
                    Console.ReadKey(true); 
                }
                else
                {

                }
                
            }
            return output;       
        }
    }
}
