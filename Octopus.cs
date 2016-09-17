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
        private string color;
        private int hunger;
        private int boredom;
        private int tankCleanliness;
        private int health;

        //properties
        public string Name //user can choose name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Color //user can choose color
        {
            get { return this.color; }
            set { this.color = value; }
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

        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }
        
        //constructors
        public Octopus()
        {
          
        }
        //methods

        public void getName() //gets name from user and stores it
        {
            Console.WriteLine("What is your octopus's name?");
            this.name = Console.ReadLine();
        }

        public void getColor() //gets color from user and stores it
        {
            Console.WriteLine("What color is your octopus?");
            this.color = Console.ReadLine();
        }
    }
}
