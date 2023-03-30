using System;
using System.Collections.Generic;
using System.Text;

namespace Ferma
{
    class Cat:Animal
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
        public Cat(string name, int hunger) : base (name,hunger)
        {
            this.name = name;
            type = "Кошка";
            this.hunger = hunger;
            voice = "Мяу Мяу";
        }
    }
}
