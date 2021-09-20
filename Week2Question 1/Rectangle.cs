using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Question_1
{
    class Rectangle
    {
        protected int length;
        protected int width;

        public int GetDimensions(int length, int width)
        {
            return (length * width);
        }
    }
}
