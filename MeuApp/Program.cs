using System;

namespace MeuApp
{
  class Program
  {
    static void Main(string[] args)
    {
      // Conversão Implícita e Explícita
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

      // Métodos e Funções
      string nome = RetornaNome("Kauan", "Hindlmayer");
      Console.WriteLine(nome);

      // Value Types e Reference Types
      int x = 25;
      int y = x; // y é uma cópia de x, ou seja, y é independente de x.

      Console.WriteLine(x);
      Console.WriteLine(y);

      x = 32;
      Console.WriteLine(x);
      Console.WriteLine(y);

      var arr = new string[2];
      arr[0] = "Item 1";

      var arr2 = arr; // arr2 é uma referência de x, ou seja, se um mudar todos mudam.

      Console.WriteLine(arr[0]);
      Console.WriteLine(arr2[0]);

      arr[0] = "Item 2";
      Console.WriteLine(arr[0]);
      Console.WriteLine(arr2[0]);

      // Structs
      var mouse = new Product(1, "Keyboard", 299.99);

      mouse.Id = 2;

      Console.WriteLine(mouse.Id);
      Console.WriteLine(mouse.Name);
      Console.WriteLine(mouse.Price);
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

  struct Product
  {
    // método construtor
    public Product(int id, string name, double price) 
    {
      Id = id;
      Name = name;
      Price = price;
    }

    // propriedades (sempre começam com letra maiúscula)
    public int Id;
    public string Name;
    public double Price;

    // métodos
    public double PriceInDolar(double dolar)
    {
      return Price * dolar;
    }
  }
}