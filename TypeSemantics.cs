namespace Lectures
{
    public static class TypeSemantics
    {

        private static void Main()
        {

            MyClass a = new (2, 3);
            Console.WriteLine("a: " + a);

            // We are copying the REFERENCE
            MyClass b = a;
            b.x = 5;
            Console.WriteLine($"a: {a}\nb: {b}\n");

            Console.WriteLine($"Before Demo1: {a}");
            Demo1(a);
            Console.WriteLine($"After Demo1: {a}\n");

            Console.WriteLine($"Before Demo2: {a}");
            Demo2(a);
            Console.WriteLine($"After Demo2: {a}\n");

            Console.WriteLine($"Before Demo3: {a}");
            Demo3(ref a);
            Console.WriteLine($"After Demo3: {a}\n");

            MyStruct c = new (2, 3);
            Console.WriteLine($"c: {c}");
            MyStruct d = c;
            d.x = 5;
            Console.WriteLine($"c: {c}\nd: {d}\n");

            Console.WriteLine($"Before Demo4: {c}");
            Demo4(c);
            Console.WriteLine($"After Demo4: {c}\n");

            MyGoodStruct e = new (4, 5);

        }

        private static void Demo1(MyClass obj)
        {
            obj.x = 20; obj.y = 30;
            Console.WriteLine($"In Demo1: {obj}");
        }
        private static void Demo2(MyClass obj)
        {
            obj = new MyClass(99, 99);
            Console.WriteLine($"In Demo2: {obj}");
        }
        private static void Demo3(ref MyClass obj)
        {
            obj = new MyClass(88, 88);
            Console.WriteLine($"In Demo3: {obj}");
        }
        private static void Demo4(MyStruct obj)
        {
            obj.x = 20; obj.y = 30;
            Console.WriteLine($"In Demo4: {obj}");
        }
    }

    //Not a useful class. Just being used for an example of data. 
    public class MyClass
    {
        // NEVER DO THIS, BADDDDDD. ONLY FOR TODAY
        public int x;
        public int y;

        public MyClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return x + " , " + y;
        }
    }

    // Bad Struct
    public struct MyStruct
    {
        // Dont ever do public fields (ANYWHERE, structs or classes)
        public int x;
        public int y;

        public MyStruct(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"{x} and {y}";
        }
    }

    // Good Struct
    public readonly struct MyGoodStruct
    {
        public readonly int x;
        public readonly int y;

        public MyGoodStruct(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
