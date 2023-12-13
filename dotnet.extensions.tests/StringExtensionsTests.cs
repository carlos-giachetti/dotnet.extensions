namespace dotnet.extensions.tests;

public class StringExtensionsTests
{
    private const string NAME = "JOÃO DO PATROCÍNIO DAS NEVES DA COSTA DOS SANTOS DE AZEVEDO E SILVA DE ORLEANS E BRAGANÇA";

    [Theory]
    [InlineData(NAME, "João Do Patrocínio Das Neves Da Costa Dos Santos De Azevedo E Silva De Orleans E Bragança")]
    public void TestToProperCase(string input, string expected)
    {
        Assert.Equal(expected, input.ToLower().ToProperCase());
    }

    [Theory]
    [InlineData(NAME, "JOÃO")]
    public void TestStrLeftIgnoreCase(string input, string expected)
    {
        Assert.Equal(expected, input.StrLeft(" do"));
    }

    [Theory]
    [InlineData(NAME, "JOÃO DO PATROCÍNIO DAS NEVES DA COSTA DOS SANTOS DE AZEVEDO E SILVA DE ORLEANS E")]
    public void TestStrLeftBackIgnoreCase(string input, string expected)
    {
        Assert.Equal(expected, input.StrLeftBack(" braGANça"));
    }

    [Theory]
    [InlineData(NAME, "JOÃO")]
    public void TestStrLeftCaseSensitive(string input, string expected)
    {
        Assert.Equal(expected, input.StrLeft(" DO"));
    }

    [Theory]
    [InlineData(NAME, "JOÃO DO PATROCÍNIO DAS NEVES DA COSTA DOS SANTOS DE AZEVEDO E SILVA DE ORLEANS E")]
    public void TestStrLeftBack(string input, string expected)
    {
        Assert.Equal(expected, input.StrLeftBack(" BRAGANÇA"));
    }

    [Theory]
    [InlineData(NAME, "DO PATROCÍNIO DAS NEVES DA COSTA DOS SANTOS DE AZEVEDO E SILVA DE ORLEANS E BRAGANÇA")]
    public void TestStrRightIgnoreCase(string input, string expected)
    {
        Assert.Equal(expected, input.StrRight(" "));
    }

    [Theory]
    [InlineData(NAME, "BRAGANÇA")]
    public void TestStrRightBackIgnoreCase(string input, string expected)
    {
        Assert.Equal(expected, input.StrRightBack(" "));
    }

    [Theory]
    [InlineData(NAME, "PATROCÍNIO DAS NEVES DA COSTA DOS SANTOS DE AZEVEDO E SILVA DE ORLEANS E BRAGANÇA")]
    public void TestStrRightCaseSensitive(string input, string expected)
    {
        Assert.Equal(expected, input.StrRight("DO "));
    }

    [Theory]
    [InlineData(NAME, "BRAGANÇA")]
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