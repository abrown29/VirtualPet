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
            Octopus petOctopus = new Octopus(10, 10, 5); //new instance of octopus
            Console.WriteLine("Congratulations! You have just adopted a new pet octopus!"); //new pet, hooray!
            petOctopus.getName(); //name
            petOctopus.viewStats(); //see name, hunger, boredom
            while (true)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1) Feed " + "\n" + "2) Play" + "\n" + "3) Clean tank" + "\n" + "4) Quit");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    petOctopus.feedOctopus();
                }
                else if (choice == 2)
                {
                    petOctopus.playTime();
                }
                else if (choice == 3)
                {
                    petOctopus.cleanTank();
                }
                else if (choice == 4)
                {
                    Environment.Exit(4);
                }
                petOctopus.viewStats();
            }
            
            }
            
        }
    }
