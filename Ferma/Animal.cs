using System;
using System.Collections.Generic;
using System.Text;

namespace Ferma
{
    class Animal
    {
        private string name;
        private string type;
        private string voice;
        private int hunger;

        public string Name
        { 
            get => name;
        }
        public string Type
        {
            get => type;
        }
        public string Voice
        {
            get => voice;
        }
        public int Hunger
        {
            get => hunger;
        }

        public Animal(string name, string type, int hunger, string voice)
        {
            this.name = name;
            this.type = type;
            this.hunger = hunger;
            this.voice = voice;
        }

        public Animal(string name, int hunger)
        {
            this.name = name;
            this.hunger = hunger;
        }

        public void Talk()
        {
            hunger -= 5;
            Console.WriteLine($"{voice}");
        }

        public void Eat(Food x)
        {
            hunger += x.Call;
            Console.WriteLine($"Покушал {x.Name} на {x.Call} сытности");
        }

        public void Sleep()
        {
            Console.WriteLine($"{name} отправился спать");
        }
    }
}
