using Business.Abstract;
using Business.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GetDog();
            GetCat();
            GetBird();

            Console.ReadKey();
        }

        private static void GetDog()
        {
            Dog dog = new Dog();

            IDogService _dogService = new DogManager(dog);

            dog = _dogService.Color();
            dog = _dogService.Size();

            Console.WriteLine(string.Format("{0}{1}", "Color of the Dog : ", dog.Color));
            Console.WriteLine(string.Format("{0}{1}", "Size of the Dog : ", dog.Size));
            Console.WriteLine("\r\n");
        }

        private static void GetCat()
        {
            Cat cat = new Cat();
            ICatService _catService = new CatManager(cat);

            cat = _catService.Color();
            cat = _catService.Size();

            Console.WriteLine(string.Format("{0}{1}", "Color Of The Cat : ", cat.Color));
            Console.WriteLine(string.Format("{0}{1}", "Size Of The Cat : ", cat.Size));
            Console.WriteLine("\r\n");
        }

        private static void GetBird()
        {
            Bird bird = new Bird();

            IBirdService _birdService = new BirdManager(bird);

            bird = _birdService.Color();
            bird = _birdService.Size();

            Console.WriteLine(string.Format("{0}{1}", "Color Of The Bird : ", bird.Color));
            Console.WriteLine(string.Format("{0}{1}", "Size Of The Bird : ", bird.Size));

        }
    }
}
