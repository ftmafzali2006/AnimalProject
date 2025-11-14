using System;

namespace AnimalProject
{
    class Horse : IAnimal
    {
        public void Walk()
        {
            Console.WriteLine("Horse gallops with clattering hooves.");
        }

        public void Eat()
        {
            Console.WriteLine("Horse grazes on fresh grass.");
        }

        public void Sleep()
        {
            Console.WriteLine("Horse usually naps while standing.");
        }

        public void MakeSound()
        {
            Console.WriteLine("Horse neighs: Neigh!");
        }
    }
}
