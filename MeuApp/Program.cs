using System;

namespace MeuApp
{
  class Program
  {
    static void Main(string[] args)
    {
      int inteiro = 100;
      float real = 25.5f;

      // real = inteiro; // 100.0f
      // inteiro = (int)real;
      // string valorReal = real.ToString();
      // inteiro = int.Parse(valorReal); // Parse sempre espera uma string
      // inteiro = int.Parse("255");
      inteiro = Convert.ToInt32(real);

      // Console.WriteLine(valorReal);
      Console.WriteLine(inteiro);
      Console.WriteLine(Convert.ToBoolean(255));
    }
  }
}