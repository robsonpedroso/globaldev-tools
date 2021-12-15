# Descrição:

Utilização da extenção de Strings

## Utilização:

Validar o CPF

```csharp

var cpf = "000.000.001-91";

if (cpf.IsValidCPF())
    Console.WriteLine("Valido");
else
    Console.WriteLine("inválido");

```

Validar o CNPJ

```csharp

var cnpj = "13.730.229/0001-23";

if (cnpj.IsValidCNPJ())
    Console.WriteLine("Valido");
else
    Console.WriteLine("inválido");

```

Validar documento independente se for CPF ou CNPJ

```csharp

var document = "13.730.229/0001-23";

if (document.IsValidDocument())
    Console.WriteLine("Valido");
else
    Console.WriteLine("inválido");

```

Lista de extensões para serem utilizadas referente a string.

```csharp

public static class StringExtensions
{
    public static string ClearStrings(this string value);
    public static string EncodeToUTF8(this string value);
    public static bool HasUnicodeChar(this string input);
    public static bool IsNullOrEmpty(this string value);
    public static bool IsNullOrWhiteSpace(this string value);
    public static bool IsNumeric(this string value);
    public static bool IsUnicode(this string input);
    public static bool IsValidCNPJ(this string CNPJ);
    public static bool IsValidCPF(this string CPF);
    public static bool IsValidDocument(this string document);
    public static bool IsValidEmail(this string email);
    public static bool IsValidZipCode(this string cep, bool allowDash = true);
    public static string MaskCNPJ(this string CNPJ);
    public static string MaskCPF(this string CPF);
    public static string MaskZipCode(this string CEP);
    public static string OnlyAlphanumeric(this string value);
    public static int OnlyNumbers(this string value);
    public static string TakeAccentsOff(this string value);
    public static string ToFormat(this string value, params object[] values);
    public static string TrimJson(this string value);
    public static string Truncate(this string value, int maxLength);
    public static string URLDecode(this string url);
    public static string URLEncode(this string url);
}

```
