using System;
using System.Collections.Generic;
using System.Text;

namespace Ferma
{
    class Dog:Animal
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
        public Dog(string name, int hunger) : base(name, hunger)
        {
            this.name = name;
            type = "Собачка";
            this.hunger = hunger;
            voice = "Гав Гав";
        }
    }
}
