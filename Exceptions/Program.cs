using System;

namespace Exceptions
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var arr = new int[3];

      try
      {
        // for (int i = 0; i < 10; i++)
        // {
          // System.IndexOutOfRangeException
          // Console.WriteLine(arr[i]);
        // }

        Cadastrar("");
      }
      catch (IndexOutOfRangeException ex) // Sempre do mais específico para o mais genérico
      {
        // Console.WriteLine(ex.InnerException);
        Console.WriteLine(ex.Message);
        Console.WriteLine("Não encontrei o índice na lista!");
      }
      catch (ArgumentNullException ex)
      {
        // Console.WriteLine(ex.InnerException);
        Console.WriteLine(ex.Message);
        Console.WriteLine("Falha ao cadastrar o texto!");
      }
      catch (Exception ex)
      {
        // Console.WriteLine(ex.InnerException);
        Console.WriteLine(ex.Message);
        Console.WriteLine("Ops, algo deu errado!");
      }
      finally // Sempre é executado independente de ocorrer erro ou não
      {
        Console.WriteLine("Chegou ao fim!");
      }
    }

    private static void Cadastrar(string texto)
    {
      if (string.IsNullOrEmpty(texto))
      throw new MinhaException(DateTime.Now);
    }

    public class MinhaException : Exception
    {
      public MinhaException(DateTime date)
      {
        QuandoAconteceu = date;
      }
      public DateTime QuandoAconteceu { get; set; }
    }
  }
}