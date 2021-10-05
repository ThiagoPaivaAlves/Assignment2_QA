﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_QA
{
    class Rectangle
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
            this.width = width;
            this.height = height;
        }

        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
    }
}
