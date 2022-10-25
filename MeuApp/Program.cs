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

      string nome = RetornaNome("Kauan", "Hindlmayer");
      Console.WriteLine(nome);
    }

    static string RetornaNome(
      string nome, 
      string sobrenome, 
      int idade = 18 // parâmetro opcional
    )
    {
      return nome + " " + sobrenome + " tem " + idade.ToString();
    }
  }
}