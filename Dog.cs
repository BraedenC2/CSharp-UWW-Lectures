using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectures {
    public sealed class Dog : Mammal {

        public Dog(string name, int age, string furColor) : base(name, age, furColor) {}

        public void PlayFetch() {
            Console.WriteLine($"Played fetch with {name}");
        }
        public override void Speak() {
            Console.WriteLine("Wolf!");
        }
    }
}
