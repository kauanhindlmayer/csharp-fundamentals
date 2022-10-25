using System;

namespace Strings
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.Clear();
      Aula03();
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

      var texto2 = "Esste texto é para fins de teste.";
      Console.WriteLine(texto2.Contains("teste")); // true
      Console.WriteLine(texto2.Contains("Teste")); // false
      Console.WriteLine(texto2.Contains("Teste", StringComparison.OrdinalIgnoreCase)); // true
      Console.WriteLine(texto2.Contains(null)); // Erro
    }
  }
}