namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Mohamed Ayman Okba";
            string[] splitedString = input.Split(' ');
            Array.Reverse(splitedString);
            input = string.Join(" ", splitedString);
            Console.WriteLine(input);
        }
    }
}