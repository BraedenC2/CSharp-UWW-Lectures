using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectures {
    public sealed class Platypus : Monotreme {

        public Platypus(string name, int age) : base(name, age, "Brown") {

        }

        public override void Speak() {
            Console.WriteLine("Quack?");       
        }

    }
}
