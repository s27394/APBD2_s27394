using System;

namespace ConsoleApplication1
{
  internal class Program
  {
    static int[] arr = { 1, 2, 3, 3, 4, 4, 4, 1, 2, 5, 6, 3, 1, 2, 3, 4, 1 };
    public static void Main(string[] args)
    {
      Console.WriteLine("HELLO FROM THE OTHER SIDEEE");

      int x = 10;
      int y = 15;
      int z = 20;

      double averageResult = calculateAverage(arr);
      Console.WriteLine("calculated avg: " + averageResult);
      
      Console.WriteLine("GOOODINGHT!");
    }

    public static double calculateAverage(int[] arr)
    {
      int sum = 0;
      foreach (var val in arr)
      {
        sum += val;
      }
      return (double)sum/(double)arr.Length;
    }
  }
}