# Descrição:

Utilização da extenção de "objetos" (genérico)

## Utilização:

Converter strin para Guid

```csharp

var teste = "f9fa8c26-8dd4-4970-9a1f-e87f1338a12e";
Guid g = teste.AsGuid();

```

Lista de extensões e conversões para serem utilizadas referente a objetos genéricos.

```csharp

public static class ObjectExtensions
{
    public static string AsBase64String(this object item);
    public static string AsBase64String(this object item, bool getEncodingByes);
    public static bool AsBool(this object item, bool defaultBool = false);
    public static byte[] AsByte(this Stream inputStream);
    public static byte[] AsByteArray(this string value);
    public static DateTime AsDateTime(this object item, DateTime defaultDateTime = default);
    public static decimal AsDecimal(this object item, decimal defaultDecimal = 0);
    public static decimal AsDecimal(this object item, CultureInfo culture, decimal defaultDecimal = 0);
    public static double AsDouble(this object item, double defaultDouble = 0);
    public static Guid AsGuid(this object item);
    public static int AsInt(this object item, int defaultInt = 0);
    public static long AsLong(this object item, long defaultLong = 0);
    public static string AsString(this object item, string defaultString = null);
    public static void ForEach<T>(this IEnumerable<T> list, Action<T> action);
    public static void ForEach<T>(this IList<T> list, Action<T> action);
    public static T IsDBNull<T>(this object value, T defaultValue);
    public static T IsDBNull<T>(this object value);
    public static bool IsNull(this object value);
}

```
