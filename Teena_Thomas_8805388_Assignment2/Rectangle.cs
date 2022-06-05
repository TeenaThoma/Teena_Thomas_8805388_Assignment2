using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teena_Thomas_8805388_Assignment2
{
    public class Rectangle
    {
       private int length;
        private int width;

        //Default constructor with length and width values set to 1
        public Rectangle()
        {
            length = 1;
            width = 1;
        }
        //Non-default constructor which sets the values of length and width values from user
        public Rectangle(int len,int wid)
        {
            length = len;
            width = wid;
        }
        public int GetLength()
        {
            return length;
        }
        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }
        public int GetWidth()
        {
            return width;
        }
        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }
        public int GetPerimeter()
        {
            int perimeter = 0;
            perimeter=2*(length+width);
            return perimeter;
        }
        public int GetArea()
        {
            int area = 0;
            area = length * width;
            return area;
        }
    }
}
