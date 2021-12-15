# Descrição:

Utilização da extenção de Guid

## Utilização:

Verificar se o Guid é "branco" (Empty)

```csharp

var id = Guid.Empty;

if (id.IsNullOrEmpty())
    Console.WriteLine("Guid é Empty = 00000000-0000-0000-0000-000000000000");

```

Lista de extensões para serem utilizadas referente ao guid.

```csharp

public static class GuidExtensions
{
    public static bool IsEmpty(this Guid guid);
    public static bool IsEmpty(this Guid? guid);
    public static bool IsNullOrEmpty(this Guid guid);
    public static string TakeHyphenOff(this Guid value);
    public static Guid? ToDBNull(this Guid guid);
}

```
