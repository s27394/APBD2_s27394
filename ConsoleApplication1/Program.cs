using System;
using System.Linq;

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
      int maxResult = findMax(arr);
      Console.WriteLine("calculated avg: " + averageResult);
      Console.WriteLine("calculated max: " + maxResult);
      
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

    public static int findMax(int[] array)
    {
      int max = -1;
      for (int i = 1; i < array.Length; i++)
      {
        if (array[i] > max)
        {
          max = array[i];
        }
      }
      return max;
    }
  }
}