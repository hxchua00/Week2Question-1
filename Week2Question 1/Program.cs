using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Question_1
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cost per sq. foot: ");
            double cost = double.Parse(Console.ReadLine());
            Console.WriteLine();
            LandCalculator newCal = new LandCalculator();
            bool option = true;
            while (option)
            {
                Console.WriteLine("Enter length of plot: ");
                int length = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter width of plot: ");
                int width = int.Parse(Console.ReadLine());

                newCal.CalulateFinalCost(cost, length, width);

                Console.WriteLine("Press Q to quit now.");
                char input = (char)Console.Read();

                if(input is 'Q' || input is 'q')
                {
                    Console.WriteLine("Goodbye!");
                    Console.ReadLine();
                    option = false;
                    break;
                }
                Console.WriteLine();
            }
           
            Console.ReadLine();
        }
    }
}
