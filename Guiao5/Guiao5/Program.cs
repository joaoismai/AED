namespace Guiao5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Exercicio 5.1
            int n = 5;
            Console.WriteLine($"f1({n}) = {Ex51.F1(n)}, running time: Θ(n)");
            Console.WriteLine($"f2({n}) = {Ex51.F2(n)}, running time: Θ(n^2)");
            Console.WriteLine($"f3({n}) = {Ex51.F3(n)}, running time: Θ(n^2)");
            Console.WriteLine($"f4({n}) = { Ex51.F4(n)}, running time: Θ(n)");
            Console.WriteLine($"f5({n}) = {Ex51.F5(n)}, running time: Θ(n^2)");
            Console.WriteLine($"f6({n}) = {Ex51.F6(n)}, running time: Θ(n^2)");
            */


            
            int[] array = { 2, 4, 7, 5, 9, 1, 3, 6 };
            int targetSum = 10;

            Console.WriteLine("Array: [{0}]", string.Join(", ", array));
            Console.WriteLine("Target Sum: {0}\n");

            Console.WriteLine("Output from find_pairs_v1:");
            Ex55.find_pairs_v1(array, targetSum);

            Console.WriteLine("\nOutput from find_pairs_v2:");
            Ex55.find_pairs_v2(array, targetSum);
        }
    }
}
