using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectures {
    public static class Polymorphism {

        private static void Main() {

            Animal[] animals = [

                new Cat("Pickles", 17, "Black"),
                new Dog("Lexi", 8, "Brown"),
                new Cat("Kitty", 20, "Gray"),
                new Dog("Yoda", 14, "Gray"),
                new Dog("Baylee", 12, "White")

                ];

            for (int i = 0; i < animals.Length; i++) {
                Console.WriteLine(animals[i]);
                animals[i].Speak();
                animals[i].BathTime();

                if (animals[i] is Dog d) {
                    d.PlayFetch();
                } else {
                    Console.WriteLine($"Can't play fetch with {animals[i].Name} because {animals[i].Name}'s a {animals[i].GetType().Name}");
                }


/*                Dog d = animals[i] as Dog;
                d?.PlayFetch();*/



/*                // Typecheck
                if (animals[i] is Dog) {
                    // Explicit Downcast
                    Dog d = (Dog) animals[i];
                    d.PlayFetch();
                }*/
            }
        }
    }
}
