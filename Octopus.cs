using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Octopus
    {
        //fields
        private string name;
        private int hunger;
        private int boredom;
        private int tankCleanliness;

        //properties
        public string Name //user can choose name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Boredom
        {
            get { return this.boredom; }
            set { this.boredom = value; }
        }

        public int TankCleanliness
        {
            get { return this.tankCleanliness; }
            set { this.tankCleanliness = value; }
        }
        
        //constructors
        public Octopus(int hunger, int boredom, int tankCleanliness)
        {
            this.hunger = 5;
            this.boredom = 5;
            this.tankCleanliness = 1;
        }
        //methods

        public void getName() //gets name from user and stores it
        {
            Console.WriteLine("What is your octopus's name?");
            this.name = Console.ReadLine();
        }

        public void viewStats() //shows baseline pet statistics
        {
            Console.WriteLine(this.name + " the octopus" + "\n");
            Console.WriteLine("Hunger" + "\n" + this.hunger + "\n");
            Console.WriteLine("Boredom" + "\n" + this.boredom + "\n");
            Console.WriteLine("Tank Cleanliness" + "\n" + this.tankCleanliness + "\n");
        }

        public void feedOctopus() //when user feeds the ocotpus, they are less hungry but the tank is also dirtier
        {
            this.hunger--;
            this.tankCleanliness++;
        }

        public void playTime() //when ocotpus plays, it is less bored but gets hungrier
        {
            this.boredom--;
            this.hunger++;
        }

        public void cleanTank() //clean the dirty tank, no effect on other properties
        {
            this.tankCleanliness--;
        }
    }
}
