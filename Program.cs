using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Octopus petOctopus = new Octopus();
            Console.WriteLine("Congratulations! You have just adopted a new pet octopus!");
            petOctopus.getName();
            petOctopus.getColor();
            Console.ReadKey();
        }
    }
}
