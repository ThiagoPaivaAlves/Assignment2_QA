using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_QA
{
    public class Rectangle
    {
        private int width;
        private int height;

        public Rectangle()
        {
            this.width = 1;
            this.height = 1;
        }
        public Rectangle(int width, int height)
        {
            if (width < 0)
                this.width = 1;
            else
                this.width = width;
            if (height < 0)
                this.height = 1;
            else
                this.height = height;
        }

        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }

        public int getPerimeter() 
        {
            return 2 * (Width + Height);
        }
        public int getArea() 
        {
            return (Width * Height);
        }
    }
}
