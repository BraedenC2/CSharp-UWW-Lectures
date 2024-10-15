using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectures {
    public class Bird : Animal, IEggLayer {

        public Bird (string name, int age) : base(name, age) {

        }

        public override void Speak() {
            Console.WriteLine("Tweet");
        }
        public void LayEgg() {
            Console.WriteLine("Lays eggs");
        }
    }
}
