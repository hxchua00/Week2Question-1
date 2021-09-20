using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Question_1
{
    class LandCalculator : Rectangle
    {
        double cost;
        double finalCost;

        Rectangle newRect = new Rectangle();

        public void CalulateFinalCost(double cost, int length, int width)
        {
            int dimensions = newRect.GetDimensions(length,width);
            finalCost = cost * dimensions;

            Console.WriteLine("Final cost of the rectangle plot is: " + finalCost);
            Console.WriteLine();
        }
    }
}
