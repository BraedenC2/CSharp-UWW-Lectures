﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectures {
    public class Cat : Animal {

        public Cat(string name, int age) : base(name, age) {}

        public override void Speak() {
            Console.WriteLine("Meow");
        }

    }
}
