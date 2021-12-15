# Descrição:

Utilização da extenção de Enum

## Utilização:

Obter a descrição do valor do enum

```csharp

enum Teste
{
    [Description("Nenhum")]
    None,
    [Description("Todos")]
    All
}

static void Main(string[] args)
{
    var description = Teste.All.GetDescription();
    
    // Todos
    Console.WriteLine(description);
}

```

Converter string para Enum

```csharp

enum Teste
{
    [Description("Nenhum")]
    None,
    [Description("Todos")]
    All
}

static void Main(string[] args)
{
    Teste description = "None".ToEnum<Teste>();
    
    // Nenhum
    Console.WriteLine(description.GetDescription());
}

```

Lista de extensões para serem utilizadas referente ao Enum.

```csharp

public static class EnumExtension
{
    public static string GetDescription(this Enum value);
    public static IEnumerable<T> GetValues<T>();
    public static T ToEnum<T>(this string value, bool? ignoreCase = null);
    public static T ToEnum<T>(this object value, bool? ignoreCase = null);
    public static string ToLower(this Enum value);
    public static int ToValue<T>(this string value);
}

```
