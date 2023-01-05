using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class Manat
    {
        public double Azn { get; set; }
        public Manat(double azn)
        {
            Azn = azn;
        }
        public static implicit operator Dollar(Manat manat) 
       // public static explicit operator Dollar(Manat manat)
        {
            return new Dollar(manat.Azn/1.7);
        }
    }
}
