using System.Diagnostics;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string number;
            var timer = Stopwatch.StartNew();
            for(int i=1; i<999999999; i++) 
            {
                number = i.ToString();
                for(int j=0; j< number.Length; j++) 
                {   
                    if (number[j] == '1') 
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine($"Number of 1's = {counter}");
            long milliSeconds = timer.ElapsedMilliseconds;
            Console.WriteLine($"Time = {milliSeconds} ms");

            Console.WriteLine("**********************************************");
            ////////////////////////////////////////////////////////////
            // 1 digit => 1
            // 2 digits => 20
            // 3 digits => 300
            // 4 digits => 4000
            // 5 digits => 50000
            // counter = digits * 10 ^(digist - 1)
            var timer2 = Stopwatch.StartNew();
            double counter2 = 0;
            //Console.Write("Enter Max Range: ");
            string maxRange = "99999999";
            int numberOfDigits = maxRange.Length;
            
            counter2 = numberOfDigits * Math.Pow(10, (numberOfDigits-1));
            Console.WriteLine($"Number of 1's = {counter2}");
            long milliSeconds2 = timer2.ElapsedMilliseconds;
            Console.WriteLine($"Time = {milliSeconds2} ms");
        }
    }
}