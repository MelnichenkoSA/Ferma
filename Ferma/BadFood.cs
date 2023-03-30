using System;
using System.Collections.Generic;
using System.Text;

namespace Ferma
{
    class BadFood:Food
    {
        private int call;
        private string name;

        public int Call
        {
            get => call;
        }

        public BadFood(string name, int call) : base(name, call)
        {
            this.name = name;
            this.call = -(call);
        }
    }
}
