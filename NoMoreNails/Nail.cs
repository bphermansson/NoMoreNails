﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMoreNails
{
    public class Nail
    {
        public string FingerOrToe { get; set; }
        public Nail(string fingerOrToe, double length, bool isPainted, bool hasVitaminDeficiency)

        public void Grow(double growLength)
        {
            Length = Length + growLength;
        }
        public void Clip()
        {
            if (Length > 2.0)
            {
                Console.WriteLine($"{FingerOrToe} - Nageln har klippts!");
                Length = 1.0;
            }
        }
    }
}