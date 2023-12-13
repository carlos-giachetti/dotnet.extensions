namespace dotnet.extensions.tests;

public class StringExtensionsTests
{
    private const string NAME = "JO�O DO PATROC�NIO DAS NEVES DA COSTA DOS SANTOS DE AZEVEDO E SILVA DE ORLEANS E BRAGAN�A";

    [Theory]
    [InlineData(NAME, "Jo�o Do Patroc�nio Das Neves Da Costa Dos Santos De Azevedo E Silva De Orleans E Bragan�a")]
    public void TestToProperCase(string input, string expected)
    {
        Assert.Equal(expected, input.ToLower().ToProperCase());
    }

    [Theory]
    [InlineData(NAME, "JO�O")]
    public void TestStrLeftIgnoreCase(string input, string expected)
    {
        Assert.Equal(expected, input.StrLeft(" do"));
    }

    [Theory]
    [InlineData(NAME, "JO�O DO PATROC�NIO DAS NEVES DA COSTA DOS SANTOS DE AZEVEDO E SILVA DE ORLEANS E")]
    public void TestStrLeftBackIgnoreCase(string input, string expected)
    {
        Assert.Equal(expected, input.StrLeftBack(" braGAN�a"));
    }

    [Theory]
    [InlineData(NAME, "JO�O")]
    public void TestStrLeftCaseSensitive(string input, string expected)
    {
        Assert.Equal(expected, input.StrLeft(" DO"));
    }

    [Theory]
    [InlineData(NAME, "JO�O DO PATROC�NIO DAS NEVES DA COSTA DOS SANTOS DE AZEVEDO E SILVA DE ORLEANS E")]
    public void TestStrLeftBack(string input, string expected)
    {
        Assert.Equal(expected, input.StrLeftBack(" BRAGAN�A"));
    }

    [Theory]
    [InlineData(NAME, "DO PATROC�NIO DAS NEVES DA COSTA DOS SANTOS DE AZEVEDO E SILVA DE ORLEANS E BRAGAN�A")]
    public void TestStrRightIgnoreCase(string input, string expected)
    {
        Assert.Equal(expected, input.StrRight(" "));
    }

    [Theory]
    [InlineData(NAME, "BRAGAN�A")]
    public void TestStrRightBackIgnoreCase(string input, string expected)
    {
        Assert.Equal(expected, input.StrRightBack(" "));
    }

    [Theory]
    [InlineData(NAME, "PATROC�NIO DAS NEVES DA COSTA DOS SANTOS DE AZEVEDO E SILVA DE ORLEANS E BRAGAN�A")]
    public void TestStrRightCaseSensitive(string input, string expected)
    {
        Assert.Equal(expected, input.StrRight("DO "));
    }

    [Theory]
    [InlineData(NAME, "BRAGAN�A")]
    public void TestStrRightBackCaseSensitive(string input, string expected)
    {
        Assert.Equal(expected, input.StrRightBack("E "));
    }

    [Theory]
    [InlineData(NAME, "AZEVEDO")]
    public void TestStrMidIgnoreCase(string input, string expected)
    {
        Assert.Equal(expected, input.StrMid("dE ", " e"));
    }

    [Theory]
    [InlineData(NAME, "ORLEANS")]
    public void TestStrMidBackIgnoreCase(string input, string expected)
    {
        Assert.Equal(expected, input.StrMidBack("De ", " E"));
    }

    [Theory]
    [InlineData(NAME, "AZEVEDO")]
    public void TestStrMidCaseSensitive(string input, string expected)
    {
        Assert.Equal(expected, input.StrMid("DE ", " E", StringComparison.Ordinal));
    }

    [Theory]
    [InlineData(NAME, "ORLEANS")]
    public void TestStrMidBackCaseSensitive(string input, string expected)
    {
        Assert.Equal(expected, input.StrMidBack("DE ", " E", StringComparison.Ordinal));
    }
}