using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectures {
    public abstract class Animal {

        protected string name;
        protected int age;

        public Animal(string name, int age) {
            Name = name;
            Age = age;
        }

        public sealed override string ToString() {
            return $"{Name} is {Age} years old.";
        }

        public abstract void Speak();

        public virtual void BathTime() {
            Console.WriteLine($"{Name} took a bath");
        }

        public string Name {
            get => name;
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentNullException("value");
                }
                name = value;
            }
        }

        public int Age {
            get => age;
            set {
                if (age < 0 || age > 100) {
                    throw new ArgumentOutOfRangeException(nameof(age));
                }
                age = value;
            }
        }
    }
}
