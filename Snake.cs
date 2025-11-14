using System;

namespace AnimalProject
{
    class Snake : IAnimal
    {
        public void Walk()
        {
            Console.WriteLine("Snake crawls on the ground.");
        }

        public void Eat()
        {
            Console.WriteLine("Snake swallows its food in one piece.");
        }

        public void Sleep()
        {
            Console.WriteLine("Snake rests under rocks.");
        }

        public void MakeSound()
        {
            Console.WriteLine("Snake hisses: Hissss!");
        }
    }
}
