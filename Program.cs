using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey_APP
{
    class Program
    {
        static void Main(string[] args)
        {
          
             try
             {
                 Console.WriteLine("Welcome");
                 Console.WriteLine("Kindly enter Miles driven");
                 double MileCovered = Convert.ToDouble(Console.ReadLine());
                 Console.WriteLine("Kindly enter the gallon used");
                 double GallonUsed = Convert.ToDouble(Console.ReadLine());

                double MPG = (MileCovered / GallonUsed);

                Console.WriteLine("Miles per Gallon = "+ MPG + " MPG ");

                 Console.ReadLine();
             }

             catch (FormatException e)
             {
                 Console.WriteLine(e.Message);
             }

             Console.ReadLine();

             

        }
    }
}
