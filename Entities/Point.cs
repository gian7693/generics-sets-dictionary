﻿using System;
using System.Collections.Generic;

namespace Course.Entities
{
    struct Point
    {
        public int X { get; set; } 
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
