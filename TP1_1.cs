using System;

namespace ConsoleApplication1
{
  internal static class Program
  {
    static void Ex1()
    {
      for (int a = 1; a <= 10; a++)
      {
        Console.WriteLine("table of: " + a );
        for (int i = 0; i <= 10; i++)
        {
          int somme = a * i;
          Console.WriteLine(a + "*" + i + "=" + somme);
        }
      }
    } 
    static void Ex2()
    {
      for (int a = 1; a <= 10; a++)
      {
        Console.WriteLine("table of: " + a );
        for (int i = 0; i <= 10; i++)
        {
          int somme = a * i;
          if ((somme % 2) == 1)
          {
            Console.WriteLine(a + "*" + i + "=" + somme);
          }
        }
      }
    } 
    static void Ex3()
    {
      int a = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("table of: " + a );
      for (int i = 0; i <= 10; i++)
      {
        int somme = a * i;
        Console.WriteLine(a + "*" + i + "=" + somme);
      }
    } 
    public static void A(string[] args)
    {
      Ex3();
    }
  }
}