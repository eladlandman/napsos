using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logger_project
{
    public class calculator
    {
        public static int counter;
        public calculator() { counter = 0; }
        public bool MoreThanSeventy(int num)
        {
            return (num >= 70);
        }

        public int Bigger(int a, int b)
        {
            counter++;
            if (a >= b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public int Multiply(int num)
        {
            counter++;
            return num * 2;

        }



        public bool Prime(int a)
        {
            counter++;
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
            
        }

        public int GetCounterValue()
        {
            counter++;
            return counter;
        }


    }
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("hello world");
            Console.WriteLine("hey one two three");

            

            


            
        }
    }
}
