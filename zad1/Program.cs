namespace zad1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int readSeed;
            int readItemNumber;
            Console.WriteLine("Podaj seed: ");
            readSeed = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPodaj liczbe przedmiotow:  ");
            readItemNumber = int.Parse(Console.ReadLine());

            Problem problem = new Problem(readItemNumber, readSeed);
            Result result = new Result();

            Console.WriteLine($"{problem.ToString()}");
            result = problem.Solve(20);
            Console.WriteLine($"{result.ToString()}");
        }

    }
}
