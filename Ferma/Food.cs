using System;
using System.Collections.Generic;
using System.Text;

namespace Ferma
{
    class Food
    {
        private int call;
        private string name;

        public int Call
        {
            get => call;
        }
        public string Name
        {
            get => name;
        }

        public Food(string name, int call)
        {
            this.name = name;
            this.call = call;
        }
    }
}
