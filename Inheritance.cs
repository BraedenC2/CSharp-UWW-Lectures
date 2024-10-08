using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectures {
    public static class Inheritance {

        private static void Main() {

            Dog koro = new Dog("Koro", 5);
            Cat mona = new Cat("Mona", 7);

            Animal mewlie = new Cat("Mewlie", 12);

            Animal a1 = koro;
            Animal a2 = mona;

            Animal[] animals = [koro, mona, mewlie];

            Console.WriteLine(koro.Name);

            for (int i = 0; i < animals.Length; i++) {
                Console.WriteLine(animals[i]);
                animals[i].Speak();
            }

        }
    }
}
