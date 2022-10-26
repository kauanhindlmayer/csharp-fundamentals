using System;

namespace Arrays
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // Arrays
      Console.Clear();
      
      var meuArray = new int[5]{1, 2, 3, 4, 5}; // Reference types precisam da palavra reservada new
      
      meuArray[0] = 12;

      // Console.WriteLine(meuArray[0]);

      // Percorrendo um array
      for (int index = 0; index < meuArray.Length; index++)
      {
        Console.WriteLine(meuArray[index]);
      }

      // ForEach
      Console.WriteLine("--------------------");
      foreach (var item in meuArray)
      { 
        Console.WriteLine(item);
      }

      // Alterando os valores
      Console.WriteLine("--------------------");
      var primeiro = new int[4];
      var segundo = new int[4];

      segundo[0] = primeiro[0];

      primeiro[0] = 23;
      Console.WriteLine(segundo[0]);
    }
  }
}