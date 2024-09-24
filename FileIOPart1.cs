namespace Lectures
{
    public static class FileIOPart1
    {
        private static void FileWritingDemo()
        {
            // Only use relative paths!!:
            string path = @"data\test1.txt";

            if (File.Exists(path))
            {
                Console.WriteLine("Exists");
            }
            else
            {
                Console.WriteLine("Does not exists");
            }

            try
            {
                using StreamWriter writer = new StreamWriter(path);
                writer.WriteLine("Hello, World!"); // Overwrites existing content
                writer.WriteLine("How are you?");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error while writing to file.");
                Console.WriteLine(e.Message);
            }

        }
        private static void Main()
        {

            FileWritingDemo();


        }
    }
}
