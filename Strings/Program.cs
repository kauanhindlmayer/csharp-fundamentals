using System;
using System.Text;

namespace Strings
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.Clear();
      Aula09();
    }
    
    static void Aula01()
    {
      var id = Guid.NewGuid();
      id.ToString();

      id = new Guid("427d8354-95f8-4169-a9ed-891a3b81c2ac");

      id = new Guid();
      Console.WriteLine(id);
    }

    static void Aula02()
    {
      var price = 10.2;
      // var texto = "O preço do produto é R$" + price + " apenas na promoção!";
      // var texto = string.Format("O preço do produto é R${0} apenas na prmoção!", price);
      var texto = $@"O preço do produto é R${price} 
      apenas na promoção!";

      Console.WriteLine(texto);
    }

    static void Aula03()
    {
      var texto = "Testando";
      Console.WriteLine(texto.CompareTo("Testando")); // Retorna 0
      Console.WriteLine(texto.CompareTo("testando")); // Retorna 1
      Console.WriteLine(texto.CompareTo("")); // Retorna 0
      Console.WriteLine(texto.CompareTo(null)); // Retorna 0

      var texto2 = "Este texto é para fins de teste.";
      Console.WriteLine(texto2.Contains("teste")); // true
      Console.WriteLine(texto2.Contains("Teste")); // false
      Console.WriteLine(texto2.Contains("Teste", StringComparison.OrdinalIgnoreCase)); // true
      Console.WriteLine(texto2.Contains(null)); // Erro
    }

    static void Aula04()
    {
      var texto = "Este texto é para fins de teste.";
      Console.WriteLine(texto.StartsWith("Este")); // true
      Console.WriteLine(texto.StartsWith("este")); // false
      Console.WriteLine(texto.StartsWith("texto")); // false

      Console.WriteLine(texto.EndsWith("teste")); // true;
      Console.WriteLine(texto.EndsWith("Teste")); // false;
      Console.WriteLine(texto.EndsWith("fins")); // false;
    }

    static void Aula05()
    {
      var texto = "Este texto é um teste.";
      Console.WriteLine(texto.Equals("Este texto é um teste.")); // true
      Console.WriteLine(texto.Equals("este texto é um teste.")); // false
      Console.WriteLine(texto.Equals("Este texto é um teste.", StringComparison.OrdinalIgnoreCase)); // true
    }

    static void Aula06()
    {
      var texto = "Este texto é um teste.";
      Console.WriteLine(texto.IndexOf("é")); // 11
      Console.WriteLine(texto.LastIndexOf("s")); // 18
    }

    static void Aula07()
    {
      var texto = "Este texto é um teste.";
      Console.WriteLine(texto.ToLower());
      Console.WriteLine(texto.ToUpper());
      Console.WriteLine(texto.Insert(11, "AQUI "));
      Console.WriteLine(texto.Remove(11, 5));
      Console.WriteLine(texto.Length);
    }

    static void Aula08()
    {
      var texto = " Este texto é um teste. ";
      Console.WriteLine(texto.Replace("Este", "isto"));
      Console.WriteLine(texto.Replace("Casa", "isto"));

      var divisao = texto.Split(" ");
      Console.WriteLine(divisao[0]);
      Console.WriteLine(divisao[1]);
      Console.WriteLine(divisao[2]);
      Console.WriteLine(divisao[3]);

      var resultado = texto.Substring(5, 5);
      Console.WriteLine(resultado);

      Console.WriteLine(texto.Trim());
    }

    static void Aula09()
    {
      var texto = new StringBuilder();
      texto.Append("\nEste texto é um teste.");
      texto.Append("\nEste texto é um teste.");
      texto.Append("\nEste texto é um teste.");
      texto.Append("\nEste texto é um teste.");

      texto.ToString();
      Console.WriteLine(texto);
    }
  }
}