using System;

namespace AnimalProject
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            IAnimal snake = new Snake();
            IAnimal rabbit = new Rabbit();
            IAnimal fox = new Fox();
            IAnimal horse = new Horse();

            
            snake.MakeSound();
            snake.Eat();
            snake.Walk();
            snake.Sleep();

            Console.WriteLine();

            
            rabbit.MakeSound();
            rabbit.Eat();
            rabbit.Walk();
            rabbit.Sleep();

            Console.WriteLine();

            
            fox.MakeSound();
            fox.Eat();
            fox.Walk();
            fox.Sleep();

            Console.WriteLine();

       
            horse.MakeSound();
            horse.Eat();
            horse.Walk();
            horse.Sleep();

            Console.WriteLine("\nEnd of Program");
            Console.ReadKey();
        }
    }
}
