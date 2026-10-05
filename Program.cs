namespace _20261005_FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // cw - > Console.WriteLine(); (snippets)

            Console.Write("Enter a value for k: ");
            //int k = int.Parse(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"k = {k}");
            Console.WriteLine($"k = {k:X}");

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
