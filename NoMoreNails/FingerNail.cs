using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NoMoreNails
{
    public class FingerNail : Nail
    {
        public FingerNail(string finger, double length, bool isPainted, bool hasVitaminDeficiency)        : base(finger, length, isPainted, hasVitaminDeficiency)        {        }
    }
}
