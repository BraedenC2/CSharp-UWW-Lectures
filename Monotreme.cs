using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectures {
    public abstract class Monotreme : Mammal, IEggLayer {

        public Monotreme(string name, int age, string furColor) : base(name, age, furColor) {
        }

        public void LayEgg() {
            Console.WriteLine($"{Name} laid an egg");
        }
    }
}
