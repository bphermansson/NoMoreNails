using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMoreNails
{
    public class ToeNail : Nail
    {
        public ToeNail(string toe, double length, bool isPainted, bool hasVitaminDeficiency)
        : base(toe, length, isPainted, hasVitaminDeficiency)
        {
        }
    }
}
