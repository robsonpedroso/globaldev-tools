# Descrição:

Utilização da extenção de listas

## Utilização:

Divide a lista em pedaços menores

```csharp

var list = new List<string>();
List<List<string>> listChunk = list.ChunkBy(10);

foreach (var itemChunk in listChunk)
{
    foreach (var item in itemChunk)
    {
        Console.WriteLine(item);
    }
}

```

Lista de extensões para serem utilizadas referente a lista.

```csharp

public static class ListExtensions
{
    public static List<List<T>> ChunkBy<T>(this List<T> source, int chunkSize);
}

```
