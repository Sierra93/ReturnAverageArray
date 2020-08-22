using System;
using System.Linq;

namespace ReturnAverageArray {
    class Program {
        static int[] arr = new int[] { 1, 4, 5 };
        static void Main() {            
            int result = CalculateAverage(arr);
            Console.WriteLine($"Результат: {result}");
            Console.ReadKey();
        }
        static int CalculateAverage(int[] arr) => (int)arr.Average();
    }
}
