using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool Scales { get; set; }
        public string Old { get; set; }
        public string Color { get; set; }
        public bool ColdBlooded { get; set; }


        public void PrintReptileDetails()
        {
            Console.WriteLine($"Has Scales: {Scales}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Has ColdBlood : {ColdBlooded}");

        }
    }
}