using System;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    internal class Program
    {


        static int add(int x, int y)
        {
            Console.WriteLine("--- ADDING BY FUNCTION - 2 Parameters ----");
            return x + y;
        }

        static (int , int ) addmul(int a)
        {
            Console.WriteLine("--- returning mutiple values from a function----");
            return (a+a, a*a);
        }

        static int change(ref int y)
        {
            Console.WriteLine("---  reference passing  ----");
            y = y + 2 * y;
            return y;
        }
        static int add(int x, int y,int z)
        {
            Console.WriteLine("--- ADDING BY FUNCTION - 3 Parameters----");
            return x + y + z;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("----------DATA TYPES:-----------");
            //DATA TYPES:
            int a = 4;
            float b = 5.5F;
            double c = 5.55D;
            char d = '#';
            string e = "how are you?";
            long f = 272878282829290202;
            bool g = true;
            var ok = 10; //var
            Console.WriteLine("Hello World");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(ok);
            Console.WriteLine("{0},{1},{2}",a,b,c ); //print serialwise
            Console.WriteLine("{0:D},{0:N},{0:F}",a ); //print serialwise

            //arrays
            int[] arr = { 10, 20, 30 };
            foreach (var item in arr)
            {
                Console.WriteLine(item.ToString());
            }

            //tuple
            (int a, int b) tup = (10,20);
            Console.WriteLine($"{tup.Item1} :   {tup.Item2}" );


            Console.WriteLine("----------TYPECASTING:-----------");
            int aa = (int)(5.55);  //explicit
            double bb = 5;  //implicit - char-> int ->long-> float-> double
            int cc = Convert.ToInt32(5.55);  //functions
            Console.WriteLine(aa);
            Console.WriteLine(bb);
            Console.WriteLine(cc);


            try {
                int a1 = 100;
                int b1 = 0;
                Console.WriteLine(a1/b1);
            
            }
            catch(Exception _e) { 
            Console.WriteLine(_e.Message);
            }

            Console.WriteLine("\n");

            Console.WriteLine("--------USER INPUT -------------");
            Console.WriteLine("Enter 1st number:");
            string val1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd number:");
            string val2 = Console.ReadLine();
            Console.WriteLine("SUM : " + (Convert.ToInt32(val1) + Convert.ToInt32(val2)));


            Console.WriteLine("---------MATH.Function------------");
            int maxval = Math.Max(10, 20);
            double sqrt = Math.Sqrt(64);
            Console.WriteLine("Math.MAX (10,20) -> " + maxval);
            Console.WriteLine("Math.Sqrt of 64 -> " + sqrt);


            Console.WriteLine("----------String Functions-----------");
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine($"Hello! {name}, your age is {age}");

            Console.WriteLine(name.Length);
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.IndexOf('y'));
            Console.WriteLine(name.Substring(2));

            StringBuilder sb = new StringBuilder("Hello ok ",200);

            sb.AppendLine("Bye");
            Console.WriteLine(sb.ToString());

            int amt = 0;
            String money= "3,000";
            amt = int.Parse(money, System.Globalization.NumberStyles.AllowThousands);
            Console.WriteLine(amt);



            Console.WriteLine("---------Flow/Conditionals------");

            if (Convert.ToInt32(age) > 18)
            {
                Console.WriteLine("Your age -> 18+");
            }
            else
            {
                Console.WriteLine("Your age -> Not 18+");
            }

            switch (Convert.ToInt32(age))
            {

                case 18:

                    {
                        Console.WriteLine("You are exactly 18");
                        break;
                    }

                case 20:
                    {
                        Console.WriteLine("You are exactly 20");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Default Age.");
                        break;

                    }


            }
            int x = 0;
            for (x = 0; x < 4; x++)
            {
                Console.WriteLine(x);
            }

            int y = 0;

            while (y != 10)
            {
                Console.WriteLine(y);
                y++;
            }

            int z = 0;
            do
            {

                Console.WriteLine(z);
                z++;
            } while (z != 5);






            Console.WriteLine("--------- Guessing Game ------");
            bool on = true;
            int ctr = 0;
            int ans = new Random().Next(20);  //till 20
            Console.WriteLine("Keep Guessing , -1 to quit");

            do
            {

                string s;
                Console.WriteLine("Enter Guess : ");
                s= Console.ReadLine();

                if (Convert.ToInt32(s) == ans)
                {
                    Console.WriteLine($"You Found ! {ans} in {ctr} times  ");

                    on = false ;
                }
                else
                {
                    if (Convert.ToInt32(s) == -1)
                    {

                        on = false;
                    
                    }
                    else
                    {
                        if (Convert.ToInt32(s) > ans)
                        {
                            Console.WriteLine("Guess lesser");
                        }

                        else {
                            Console.WriteLine("Guess Higher");

                        }
                        ctr++;

                    }
                        

                }

               

            }
            while (on);







            Console.WriteLine("---------Methods ------");
            //method overloading:
            Console.WriteLine(add(10, 20));
            Console.WriteLine(add(10, 20,30));
            int l = 1;
            Console.WriteLine(l);
            Console.WriteLine(change(ref l));
            Console.WriteLine(l);

            Console.WriteLine(addmul(l));



            Console.WriteLine("--------- OOPS Class------");
            Person p = new Person();
            p.SetName("raj");
            p.SetAge(10);
            Console.WriteLine("Name : " + p.GetName());
            Console.WriteLine("Age : " + p.GetAge());
            p.PrintData();

            Console.ReadLine();
        }
    }
}
