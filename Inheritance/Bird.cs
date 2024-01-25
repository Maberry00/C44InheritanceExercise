using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public bool HasBones { get; set; }
        public int Legs { get; set; }
        public string Beaks { get; set; }
        public bool HasFeathers { get; set; }


        public void PrintBirdDetails()
        {
            Console.WriteLine($"Has Feathers: {HasFeathers}");
            Console.WriteLine($"Beak: {Beaks}");
            Console.WriteLine($"Has BackBone: {HasBones}");
        }
    }
}