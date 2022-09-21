using Assignment1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Xml.Linq;

namespace Demo_PRN211_SE1630
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1.Lesson 1");
                Console.WriteLine("2.Lesson 2");
                Console.WriteLine("3.Lesson 3");
                Console.WriteLine("4.Lesson 4");
                Console.WriteLine("0.Exit");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 0: return;
                    case 1:
                        {
                            Lesson1();
                            break;
                        }
                    case 2:
                        {
                            Lesson2();
                            break;
                        }
                    case 3:
                        {
                            Lesson3();
                            break;
                        }
                    case 4:
                        {
                            Lesson4();
                            break;
                        }
                    default:
                        break;
                }

            }
        }

        static void Lesson4()
        {
            List<Player> listP = new List<Player>();
            List<Coach> listC = new List<Coach>();
            IManager m = new Manager(listP,listC);
            IManager m1 = new Manager(listP);
            IManager m2 = new Manager(listC);
            listP.Add(new Player("P01", "Xuan Truong", "Ha Noi", 01 , "striker", 1500));
            listP.Add(new Player("P02", "Tuan Linh", "Ha Noi", 03 , "striker", 1600));
            listP.Add(new Player("P03", "Van Toan", "Ha Noi", 02 , "striker", 1300));
            listP.Add(new Player("P04", "Cong Phuong", "Ha Noi", 05 , "defender", 1400));
            listP.Add(new Player("P05", "Hoa Phat", "Ha Noi", 04 , "defender", 1300));
            listP.Add(new Player("P06", "Van Lam", "Ha Noi", 06 , "goalkeeper", 1100));
            listC.Add(new Coach("C01", "Xuan Dat", "Ha Noi", "Chinh", 1600, 3));
            listC.Add(new Coach("C02", "Quang Nhat", "Ha Noi", "Chinh", 1400, 4));
            listC.Add(new Coach("C03", "Tuan Anh", "Ha Noi", "Phu", 1300, 5));
            listC.Add(new Coach("C04", "Tuan Duong", "Ha Noi", "The Luc", 1200, 3));
            listC.Add(new Coach("C05", "Duc Anh", "Ha Noi", "The Hinh", 1100, 2));
            while (true)
            {
                Console.WriteLine("1. Input Student to List.");
                Console.WriteLine("2. Input Coach to List.");
                Console.WriteLine("3. Show list Student.");
                Console.WriteLine("4. Show list Coach");
                Console.WriteLine("5. Change Player ShirtNumber/Salary.");
                Console.WriteLine("6. Count the coaches that have years of experience >=3.");
                Console.WriteLine("7. Sum of the salary of the players that are the striker.");
                Console.WriteLine("8. Who have the max salary?");
                Console.WriteLine("9. Sort the list of players by ascending shirt number.");
                Console.WriteLine("10. Sort descending salaries of experienced coaches = 3.");
                Console.WriteLine("0. Exit.");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0:                        
                            return;
                    case 1:
                        {
                            m1.inputListPlayer();
                            break;
                        }
                    case 2:
                        {
                            m2.inputListCoach();
                            break;
                        }
                    case 3:
                        {
                            m1.showPlayer();
                            break;
                        }
                    case 4:
                        {
                            m2.showCoach();
                            break;
                        }
                    case 5:
                        {
                            m1.changerPlayer();
                            break;
                        }
                    case 6:
                        {
                            m2.countCoach();
                            break;
                        }
                    case 7:
                        {
                            m1.sumPSalary();
                            break;
                        }
                    case 8:
                        {
                            m.showMaxLuong();
                            break;
                        }
                    case 9:
                        {
                            m1.sortPShirtNum();
                            break;
                        }
                    case 10:
                        {
                            m2.sortCoach3Exp();
                            break;
                        }
                    default:
                        break;
                }
            }
        }
        private static void Lesson3()
        {
            Console.WriteLine("1. Count how many Students that first name is \"Yen\".");
            Console.WriteLine("2. Count how many of you have the \"Van\" padding.");
            Console.WriteLine("3. Count how many students that  their lastnames starting with the letter \"N\".");
            List<string> list = new List<string>
            {  "Nguyen Huu Nam",
                "Ngo Hao Nam",
                "Nguyen Ngoc Bao Chau",
                "Ta Thi Thuong",
                "Bui Hoang Lan",
                "Nguyen Van Anh",
                "Trinh Van Toan",
                "Dao Hai Yen",
                "Yen Thap Tam",
                "Yen Khuynh Thanh",
                "Yen Ngoc Tam",
                "Dam Van Anh",
                "Trinh Van Ninh"
            };
            Console.WriteLine("Danh sach sinh vien: ");
            int countFN = 0;
            int countP = 0;
            int countLN = 0;
            foreach (string item in list)
            {
                Console.WriteLine(item);
                string s = item.Trim();
                string firstname = s.Substring(0, s.IndexOf(' '));
                string padding = s.Substring(s.IndexOf(' ') + 1, s.LastIndexOf(' ') - firstname.Length - 1);
                string lastname = s.Substring(s.LastIndexOf(' ') + 1);
                
                if (firstname.Equals("Yen"))    { countFN++; }
                if (padding.Equals("Van"))  { countP++; }
                if (lastname.StartsWith("N"))   { countLN++; } //if (lastname.Substring(0, 1).Equals("N"))   { countLN++; }
            }
            Console.WriteLine("So sinh vien co ho la \"Yen\": " + countFN);
            Console.WriteLine("So sinh vien co ten dem la \"Van\": " + countP);
            Console.WriteLine("So sinh vien co ten bat dau bang \"N\": " + countLN);
        }
        static void Lesson2()
        {
            Console.WriteLine("1. Print out the screen all prime numbers of this array.");
            Console.WriteLine("2. Count how many prime numbers there are in the above array, how many composite numbers?");
            Console.WriteLine("3. Arranges this array in descending order that items are square numbers.");
            var numbers = Generate(100);
            var selected = numbers.Take(20).ToArray();
            Array.Sort(selected);
            // string.Join chuyển mảng thành chuỗi
            // .where : dùng để lọc data dựa trên điều kiện cho trước.
            Console.WriteLine("Selected : " + string.Join(", ", selected));
            Console.WriteLine("Primes : " + string.Join(",", selected.Where(IsPrime)));
            //Console.ReadLine();
            int n = selected.Length;
            Console.WriteLine("Primes count: " + string.Join(",", selected.Count(IsPrime)));
            Console.WriteLine("Composte count : " + string.Join(",", selected.Count(IsComposite)));
            sortSquares(selected);
            Console.Write("After Sort: ");
            for (int i = 0; i < n; i++) 
            { 
                Console.Write(selected[i] + " ");
            }
            Console.WriteLine();
        }
        //Sắp xếp array theo thứ tự giảm dần
        public static void sortSquares(int[] arr)
        {
            int n = arr.Length;

            // First convert each array
            // elements into its square
            for (int i = 0; i < n; i++)
                arr[i] = arr[i] * arr[i];

            // Sort an array using
            // "inbuild sort function"
            // in Arrays class.
            Array.Reverse(arr);
        }
        private static readonly Random _r = new Random();
        
        //Sinh ra 1 array ngẫu nhiên từ 1 - 100
        public static int[] Generate(int size)
        {
            var numbers = Enumerable.Range(1, 100).ToArray();
            // Shuffling the elements of the array:
            for (var i = 0; i < numbers.Length; i++)
            {
                var j = _r.Next(i, numbers.Length);
                var temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
            }
            
            return numbers;
        }
        static void Lesson1()
        {
            while (true)
            {
                Console.WriteLine("Nhap vao lua chon cua ban: ");
                Console.WriteLine("1. Print to the screen odd composite numbers < n.");
                Console.WriteLine("2. Print out n second prime numbers.");
                Console.WriteLine("3. In the natural numbers <= n count how many numbers there are:\r\n + Divide by 3.\r\n + Divide 4 with the remainder 1.\r\n + The end digit is “6”.\r\n");
                Console.WriteLine("4. Print out the successful development of prime numbers from small to large.");
                Console.WriteLine("0. Back.");
                int x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 0: return;
                    case 1:
                        PrintOddCompositeNumbers();
                        break;
                    case 2:
                        PrimeNumber();
                        break;
                    case 3:
                        CountNumber();
                        break;
                    case 4:
                        successdevePrimeNum();
                        break;
                    default:
                        Console.WriteLine("Goodbye!");
                        break;
                }
            }
        }

        private static void successdevePrimeNum()
        {
            Console.WriteLine("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = n;
            List<int> arr = new List<int>();
            // Tách n thành các hệ só nguyên tố i
            for (int i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    arr.Add(i);
                    n /= i;
                }
            }
            Console.Write($"{a} --> ");
            int lastIndex = arr.Count - 1;
            // in ra 
            for (int i = 0; i < arr.Count; i++)
            {
                if (i == lastIndex)
                {
                    Console.Write(arr[i]);
                }
                else
                {
                    Console.Write(arr[i] + ".");
                }

            }
            Console.WriteLine();
        }

        private static void CountNumber()
        {
            Console.WriteLine("Nhap vao n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int dem = 0; // 
            int demchia3 = 0;
            int demchia4du1 = 0;
            int demketthucbang6 = 0;
            int i;
            for (i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    demchia3++;
                }
                if (i % 4 == 1)
                {
                    demchia4du1++;
                }
                if(i % 10 == 6)
                {
                    demketthucbang6++;
                }
                //Console.WriteLine(i + "chia het cho 3: " + demchia3 + " , chia du cho 4: " + demchia4du1 + ", ket thuc bang 6: " +demketthucbang6);
            }
            Console.WriteLine("Co " + demchia3 + " so chia het cho 3\nCo "+ demchia4du1 + " so chia cho 4 du 1\nCo "+ demketthucbang6 + " so ket thuc bang 6");
        }
        private static void PrimeNumber()
        {
            Console.WriteLine("Nhap vao n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int dem = 0; // dem tong so nguyen to
            int i = 2;
            Console.WriteLine(n + " so nguyen to tiep theo: ");
            while (dem < n)
            {
                if (IsPrime(i) == true)
                {
                    //Console.Write(i + ", ");
                    dem++;
                }
                i++;
            }
            // in ra n so nguyen to tiep theo 
            while (dem < 2*n & dem >= n)
            {
                if (IsPrime(i) == true)
                {
                    Console.Write(i + ", ");
                    dem++;
                }
                i++;
            }
            Console.WriteLine();
        }

        private static void PrintOddCompositeNumbers()
        {
            Console.WriteLine("Nhap vao n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            // in ra composite number le
            for (int number = 1; number < n; number++)
            {
                if (IsComposite(number) == true & number % 2 == 1)                  
                    Console.WriteLine("odd composite  number -> {0}", number);
            }

            Console.ReadKey();
        }
        static bool IsPrimeNumber(int number)
        {
            int divisionCount = 0;
            int index_number = number;

            while (index_number > 0)
            {
                if (number % index_number == 0)
                    divisionCount++;

                index_number--;
            }

            return (divisionCount == 2);
        }
        private static bool IsPrime(int number)
        {
            //since 0 and 1 is not prime return false.
            if (number == 1 || number == 0) return false;

            //Run a loop from 2 to n-1
            for (int i = 2; i < number; i++)
            {
                // if the number is divisible by i, then n is not a prime number.
                if (number % i == 0) return false;
            }
            //otherwise, n is prime number.
            return true;
        }
        //So khong phai so nguyen to thi la so tong hop
        private static bool IsComposite(int number)
        {
            if (number == 1 || number == 0) return true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return true;
            }
            return false;
        }
    }
}