namespace Lectures {
    public abstract class Mammal : Animal {

        protected string furColor;

        public Mammal(string name, int age, string furColor) : base(name, age) {
            this.furColor = furColor;
        }

        public string FurColor {
            get => furColor;
        }

    }
}
