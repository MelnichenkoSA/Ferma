using System;

namespace Ferma
{
    class Program
    {
        static void Main(string[] args)
        {
            GoodFood Apple = new GoodFood("Яблоко", 15);
            GoodFood Meat = new GoodFood("Мясо", 30);
            BadFood zemlya = new BadFood("Земля", 15);
            BadFood Musor = new BadFood("Мусор", 30);
            Fermer Fermer = new Fermer();
            Fermer.Start();
        }
    }
}
