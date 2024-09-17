namespace Lectures
{
    public static class Arrays
    {
        private static void Main()
        {
            int[] nums;

            nums = new int[5];

            nums[0] = 10;
            nums[1] = 5;
            nums[2] = 20;

            Console.WriteLine(nums[0]);
            Console.WriteLine(nums[1]);
            Console.WriteLine(nums[2]);
            Console.WriteLine(nums[3]);
            Console.WriteLine(nums[4]);

            Console.WriteLine(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            Console.WriteLine(string.Join(", ", nums));

            double[] a = new double[3];

            a[0] = 1.1d;
            a[1] = 2.2d;
            a[2] = 3.3d;

            double[] b = a;
            b[0] = 4.4d;

            Console.WriteLine("a: " + string.Join(", ", a));
            Console.WriteLine("b: " + string.Join(", ", b));

            int[] c = new int[3];
            c[0] = 1;
            c[1] = 2;
            c[2] = 3;


            Console.WriteLine("before: " + string.Join(", ", c));
            AddOne(c);
            Console.WriteLine("after: " + string.Join(", ", c));

            int[] values =
            {
                1,
                2,
                3,
                4,
                5
            };
            string[] names =
            {
                "Braeden",
                "Peacy",
                "Dylan",
                "Thomas",
                "Ben",
                "Devin"
            };
            double[] grades =
            [
                23.5d,
                32.7d,
                75.7d,
                94.8d
            ];


            int[][] jagged = new int[3][];

            int[,] rectangular = new int[2, 3];
            rectangular[0, 0] = 1;
            rectangular[0, 1] = 2;


            int[,,,] god = new int[2, 2, 2, 2];
            god[0, 0, 0, 0] = 3;
        }

        public static void AddOne(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i]++;
            }
        }
    }
}
