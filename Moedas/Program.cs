using System;
using System.Globalization;

namespace Moedas
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // Tipo para moedas
      Console.Clear();

      decimal valor = 10536.25m;

      // Formatando moedas
      Console.WriteLine(valor.ToString(
        "C",
        CultureInfo.CreateSpecificCulture("pt-BR")
      ));

      // Math
      Console.WriteLine(
        "Round: " + Math.Round(valor) + "\n" +
        "Ceiling: " + Math.Ceiling(valor) + "\n" +
        "Floor: " + Math.Floor(valor)
      );
    }
  }
}