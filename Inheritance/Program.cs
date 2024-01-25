using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
     
            Bird bird1 = new Bird();
            bird1.Beaks = "crow";
            bird1.HasFeathers = true;
            bird1.HasBones = true;
            bird1.Legs = 2;

            Reptile reptile1 = new Reptile();
            {
                reptile1.Scales = true;
                reptile1.Color = "snakes";
                reptile1.Old = "turtles";
                reptile1.ColdBlooded = true;
            };


            bird1.PrintBirdDetails();



            reptile1.PrintReptileDetails();


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
