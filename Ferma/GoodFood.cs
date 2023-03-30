using System;
using System.Collections.Generic;
using System.Text;

namespace Ferma
{
    class GoodFood:Food
    {
        private int call;
        private string name;

        public int Call
        {
            get => call;
        }

        public GoodFood(string name, int call) : base (name,call)
        {
            this.name = name;
            this.call = call;
        }
    }
}
