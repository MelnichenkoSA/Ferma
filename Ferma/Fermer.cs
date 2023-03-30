using System;
using System.Collections.Generic;
using System.Text;

namespace Ferma
{
    class Fermer
    {
        public List<Animal> Animals;
        public Fermer()
        {

        }
        public void Start()
        {
            Console.WriteLine("Стартуем");
            Console.WriteLine("Что ты хочешь сделать на моей ферме ? \n 1.Создать животинку\n 2.Покормить животинку 3. Уйти");
            int i = int.Parse(Console.ReadLine());
            switch(i)
            {
                case 1:
                    Console.WriteLine("1.Кошку 2.Собаку 3.Лошадь 4.Свою 5.Назад");
                    int u = int.Parse(Console.ReadLine());
                    switch(u)
                    {
                        case 1:
                            Console.WriteLine("Дай ей кличку");
                            string x = Console.ReadLine();
                            Console.WriteLine("И голод как ни странно");
                            int y = int.Parse(Console.ReadLine());
                            Animals.Add(new Cat(x, y));
                            Start();
                            break;
                        case 2:
                            Console.WriteLine("Дай ей кличку");
                            string a = Console.ReadLine();
                            Console.WriteLine("И голод как ни странно");
                            int b = int.Parse(Console.ReadLine());
                            Animals.Add(new Dog(a, b));
                            Start();
                            break;
                        case 3:
                            Console.WriteLine("Дай ей кличку");
                            string c = Console.ReadLine();
                            Console.WriteLine("И голод как ни странно");
                            int d = int.Parse(Console.ReadLine());
                            Animals.Add(new Cat(c, d));
                            Start();
                            break;
                        case 4:
                            Console.WriteLine("Дай ей кличку");
                            string e = Console.ReadLine();
                            Console.WriteLine("А как называется?");
                            string r = Console.ReadLine();
                            Console.WriteLine("И голод как ни странно");
                            int f = int.Parse(Console.ReadLine());
                            Console.WriteLine("Как говорит?");
                            string g = Console.ReadLine();
                            Animals.Add(new Animal(e, r, f, g));
                            Start();
                            break;
                        default:
                            Start();
                            break;
                    }
                case 2:
            }
        }
        public void DoMeal(Animal x, Food y)
        {
            x.Eat(y);
        }
    }
}
