namespace dotnet.extensions.lib;

public static class StringExtensions
{
    private static readonly string[] ptBRprepositions = ["da", "de", "do", "das", "dos", "e"];


    public static string ToProperCase(this string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return input;
        }

        string[] words = input.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 1)
            {
                words[i] = words[i][0].ToString().ToUpper() + words[i][1..].ToLower();
            }
            else
            {
                words[i] = words[i].ToUpper();
            }
        }

        return string.Join(' ', words);
    }

    public static string ToLower(this string input, IEnumerable<string> prepositions)
    {
        string[] lowerCasePrepositions = prepositions.Select(preposition => preposition.ToLower()).ToArray();

        IEnumerable<string> words = input.Split(' ');
        words = words.Select(word =>
                    Array.IndexOf(lowerCasePrepositions, word.ToLower()) < 0 ? word : word.ToLower()
                );

        return string.Join(' ', words);
    }

    public static string ToPtBrProperName(this string name) =>
        name.ToProperCase().ToLower(ptBRprepositions);

    public static string StrLeft(this string input, string delimiter, StringComparison stringComparison = StringComparison.OrdinalIgnoreCase)
    {
        int pos = input.IndexOf(delimiter, stringComparison);
        if (pos < 0)
        {
            return string.Empty;
        }

        return input[..pos];
    }

    public static string StrRight(this string input, string delimiter, StringComparison stringComparison = StringComparison.OrdinalIgnoreCase)
    {
        int pos = input.IndexOf(delimiter, stringComparison);
        if (pos < 0)
        {
            return string.Empty;
        }

        return input[(pos + delimiter.Length)..];
    }

    public static string StrLeftBack(this string input, string delimiter, StringComparison stringComparison = StringComparison.OrdinalIgnoreCase)
    {
        int pos = input.LastIndexOf(delimiter, stringComparison);
        if (pos < 0)
        {
            return string.Empty;
        }

        return input[..pos];
    }

    public static string StrRightBack(this string input, string delimiter, StringComparison stringComparison = StringComparison.OrdinalIgnoreCase)
    {
        int pos = input.LastIndexOf(delimiter, stringComparison);
        if (pos < 0)
        {
            return string.Empty;
        }

        return input[(pos + delimiter.Length)..];
    }

    public static string StrMid(this string input, string delimiterLeft, string delimiterRight, StringComparison stringComparison = StringComparison.OrdinalIgnoreCase)
    {
        int posLeft = input.IndexOf(delimiterLeft, stringComparison);
        if (posLeft < 0)
        {
            return string.Empty;
        }

        int posRight = input.IndexOf(delimiterRight, posLeft + delimiterLeft.Length, stringComparison);
        if (posRight < 0)
        {
            return string.Empty;
        }

        if (posLeft >= posRight)
        {
            return string.Empty;
        }

        return input[(posLeft + delimiterLeft.Length)..posRight];
    }

    public static string StrMidBack(this string input, string delimiterLeft, string delimiterRight, StringComparison stringComparison = StringComparison.OrdinalIgnoreCase)
    {
        int posRight = input.LastIndexOf(delimiterRight, stringComparison);
        if (posRight < 0)
        {
            return string.Empty;
        }

        int posLeft = input.LastIndexOf(delimiterLeft, posRight - delimiterRight.Length, stringComparison);
        if (posLeft < 0)
        {
            return string.Empty;
        }

        if(posLeft >= posRight)
        {
            return string.Empty;
        }

        return input[(posLeft + delimiterLeft.Length)..posRight];        
    }

    public static string Reverse(this string input)
    {
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}
