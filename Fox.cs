using System;

namespace AnimalProject
{
    class Fox : IAnimal
    {
        public void Walk()
        {
            Console.WriteLine("Fox walks quietly and stealthily.");
        }

        public void Eat()
        {
            Console.WriteLine("Fox eats the meat of its prey.");
        }

        public void Sleep()
        {
            Console.WriteLine("Fox sleeps in an underground den.");
        }

        public void MakeSound()
        {
            Console.WriteLine("Fox says: Yap Yap!");
        }
    }
}
