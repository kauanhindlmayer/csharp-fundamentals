using System;
using System.Globalization;

namespace ConsoleApp
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
      // Iniciando com datas
      var data = new DateTime();
      Console.WriteLine(data);
    }

    static void Aula02()
    {
      // Obtendo valores da data
      var data = new DateTime(2020, 10, 12, 13, 23, 14);
      Console.WriteLine(data);
      Console.WriteLine(data.Year);
      Console.WriteLine(data.Month);
      Console.WriteLine(data.Day);
      Console.WriteLine(data.Hour);
      Console.WriteLine(data.Minute);
      Console.WriteLine(data.Second);
      Console.WriteLine(data.DayOfWeek);
      Console.WriteLine(data.DayOfYear);
    }

    static void Aula03()
    {
      // Formatando data
      var data = DateTime.Now;
      var formatada = String.Format("{0:yyyy/MM/dd hh:mm:ss ff zz}", data);
      Console.WriteLine(formatada);
    }

    static void Aula04()
    {
      // Padrões de formatação
      var data = DateTime.Now;
      var formatada = String.Format("{0:r}", data);
      Console.WriteLine(formatada);
    }

    static void Aula05()
    {
      // Adicionando valores
      var data = DateTime.Now;
      Console.WriteLine(data);
      Console.WriteLine(data.AddDays(12));
      Console.WriteLine(data.AddMonths(1));
      Console.WriteLine(data.AddYears(1));
    }

    static void Aula06()
    {
      // Comparando datas
      // DateTime? data = DateTime.Now; // Nullable value types

      var data = DateTime.Now;

      if (data.Date == DateTime.Now.Date)
      {
        Console.WriteLine("É igual!");
      }

      Console.WriteLine(data);
    }

    static void Aula07()
    {
      // CultureInfo
      var pt = new System.Globalization.CultureInfo("pt-PT");
      var br = new System.Globalization.CultureInfo("pt-BR");
      var en = new System.Globalization.CultureInfo("en-US");
      var de = new System.Globalization.CultureInfo("de-DE");
      var atual = CultureInfo.CurrentCulture;

      Console.WriteLine(DateTime.Now.ToString("D", pt));
      // Console.WriteLine(String.Format("{0:d}", DateTime.Now));
    }

    static void Aula08()
    {
      // Timezone
      var utcDate = DateTime.UtcNow;

      Console.WriteLine(DateTime.Now);
      Console.WriteLine(utcDate);
      Console.WriteLine(utcDate.ToLocalTime());

      var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
      Console.WriteLine(timezoneAustralia);

      var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
      Console.WriteLine(horaAustralia);

      var timezones = TimeZoneInfo.GetSystemTimeZones();
      foreach (var timezone in timezones)
      {
        Console.WriteLine(timezone.Id);
        Console.WriteLine(timezone);
        Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
        Console.WriteLine("_________");
      }
    }

    static void Aula09()
    {
      // Timespan
      var timeSpan = new TimeSpan();
      Console.WriteLine(timeSpan);

      var timeSpanNanosegundos = new TimeSpan(1);
      Console.WriteLine(timeSpanNanosegundos);

      var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
      Console.WriteLine(timeSpanHoraMinutoSegundo);

      var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
      Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

      var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(15, 12, 55, 8, 100);
      Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

      Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
      Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
      Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));
    }
  }
}