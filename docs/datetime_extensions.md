# Descrição:

Utilização da extenção de DateTime

## Utilização:

Pegar a data atual no final do dia (horário 23:59:59)

```csharp

var date = DateTime.Now;
date = date.EndDay();

// 15/12/2021 23:59:59
Console.WriteLine(date);

```

Obter os valores referente a um intervalo de datas

```csharp

var start = DateTime.Now;
var end = DateTime.Now.AddDays(5);

var interval = start.Interval(end);

var days = interval.Days;
var Hours = interval.Hours;
var minutes = interval.Minutes;
var Seconds = interval.Seconds;
var milliseconds = interval.Milliseconds;

```

Lista de extensões para serem utilizadas referente ao guid.


```csharp

// Modelo utilizado no intervalo de datas
// Essa classe se encontra na lib
public class IntervalDate
{
    public IntervalDate(TimeSpan interval);

    public int Days { get; set; }
    public double Hours { get; set; }
    public double Minutes { get; set; }
    public double Seconds { get; set; }
    public double Milliseconds { get; set; }
}

public static class DateTimeExtensions
{
    public static DateTime ChangeTime(this DateTime dateTime, int hours, int minutes, int seconds = 0, int milliseconds = 0);
    public static DateTime EndDay(this DateTime dateTime);
    public static DateTime InitDay(this DateTime dateTime);
    public static IntervalDate Interval(this DateTime startDate, DateTime endDate);
    public static int IntervalDays(this DateTime startDate, DateTime endDate);
    public static double IntervalHours(this DateTime startDate, DateTime endDate);
    public static TimeSpan Multiply(this TimeSpan multiplicand, int multiplier);
    public static TimeSpan Multiply(this TimeSpan multiplicand, double multiplier);
}

```
