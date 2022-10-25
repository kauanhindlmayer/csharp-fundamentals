using System;

namespace Calculator
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine("[1] - Soma");
      Console.WriteLine("[2] - Subtração");
      Console.WriteLine("[3] - Multiplicação");
      Console.WriteLine("[4] - Divisão");
      Console.WriteLine("[5] - Sair");

      Console.WriteLine("---------------------");
      Console.WriteLine("Selecione uma opção: ");
      short res = short.Parse(Console.ReadLine());

      switch (res)
      {
        case 1: Sum(); break;
        case 2: Sub(); break;
        case 3: Mul(); break;
        case 4: Div(); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
      }
    }

    static void Sum()
    {
      Console.Clear();
      Console.WriteLine("Primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());

      float result = v1 + v2;
      Console.WriteLine($"\nO resultado da soma é {result}");
      Console.ReadKey();
      Menu();
    }

    static void Sub()
    {
      Console.Clear();
      Console.WriteLine("Primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());

      float result = v1 - v2;
      Console.WriteLine($"\nO resultado da subtração é {result}");
      Console.ReadKey();
      Menu();
    }

    static void Div()
    {
      Console.Clear();
      Console.WriteLine("Primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());

      float result = v1 / v2;
      Console.WriteLine($"\nO resultado da divisão é {result}");
      Console.ReadKey();
      Menu();
    }

    static void Mul()
    {
      Console.Clear();
      Console.WriteLine("Primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());

      float result = v1 * v2;
      Console.WriteLine($"\nO resultado da multiplicação é {result}");
      Console.ReadKey();
      Menu();
    }
  }
}