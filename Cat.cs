using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectures {
    public class Cat : Mammal {

        public Cat(string name, int age, string furColor) : base(name, age, furColor) {}

        public override void Speak() {
            Console.WriteLine("Meow");
        }

        public override void BathTime() {
            Console.WriteLine($"{Name} is a cat and refused to get in the bath.");
        }

    }
}
