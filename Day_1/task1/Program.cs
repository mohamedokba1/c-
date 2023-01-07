using System.Buffers;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxDistance=0;
            int result=0;
            int repeatedElement = 0;
            Console.Write("Enter the size of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for(int i=0; i<arr.Length; i++)
            {
                Console.Write($"Element {i} : ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            for(int i=0; i<arr.Length ; i++)
            {
                for (int j=i+1; j<arr.Length; j++)
                {
                    // i=> firstOccurance 
                    // j=> lastOccurance
                    if(arr[i] == arr[j])
                    {
                        maxDistance = j - i - 1; // number of cells or indexes between the same values.
                    }
                }
                if(maxDistance > result)
                {
                   result = maxDistance;
                   repeatedElement = arr[i];
                   
                }
            }
            Console.WriteLine($"\n\nMax Distance = {result} \nBetween first {repeatedElement} and last {repeatedElement}");
        }
    }
}