namespace dotnet.extensions.tests;

public class StringExtensionsTests
{
    private const string NAME = "JOÃO DO PATROCÍNIO DAS NEVES DA COSTA DOS SANTOS DE AZEVEDO E SILVA DE ORLEANS E BRAGANÇA";

    [Theory]
    [InlineData(NAME, "João Do Patrocínio Das Neves Da Costa Dos Santos De Azevedo E Silva De Orleans E Bragança")]
    public void ToProperCase_Default_ReturnsPropercase(string input, string expected)
    {
        Assert.Equal(expected, input.ToLower().ToProperCase());
    }

    [Theory]
    [InlineData(NAME, "JOÃO")]
    public void StrLeft_IgnoreCase_Returns1stWord(string input, string expected)
    {
        Assert.Equal(expected, input.StrLeft(" do"));
    }

    [Theory]
    [InlineData(NAME, "JOÃO DO PATROCÍNIO DAS NEVES DA COSTA DOS SANTOS DE AZEVEDO E SILVA DE ORLEANS E")]
    public void StrLeftBack_IgnoreCase_ReturnAllBeforeLastWord(string input, string expected)
    {
        Assert.Equal(expected, input.StrLeftBack(" braGANça"));
    }

    [Theory]
    [InlineData(NAME, "JOÃO")]
    public void StrLeft_CaseSensitive_Return1stWord(string input, string expected)
    {
        Assert.Equal(expected, input.StrLeft(" DO", StringComparison.Ordinal));
    }

    [Theory]
    [InlineData(NAME, "JOÃO DO PATROCÍNIO DAS NEVES DA COSTA DOS SANTOS DE AZEVEDO E SILVA DE ORLEANS E")]
    public void StrLeftBack_CaseSensitive_ReturnAllBeforeLastWord(string input, string expected)
    {
        Assert.Equal(expected, input.StrLeftBack(" BRAGANÇA", StringComparison.Ordinal));
    }

    [Theory]
    [InlineData(NAME, "DO PATROCÍNIO DAS NEVES DA COSTA DOS SANTOS DE AZEVEDO E SILVA DE ORLEANS E BRAGANÇA")]
    public void StrRight_IgnoreCase_ReturnsAllAfter1stWord(string input, string expected)
    {
        Assert.Equal(expected, input.StrRight(" "));
    }

    [Theory]
    [InlineData(NAME, "BRAGANÇA")]
    public void StrRight_IgnoreCase_ReturnsLastWord(string input, string expected)
    {
        Assert.Equal(expected, input.StrRightBack(" "));
    }

    [Theory]
    [InlineData(NAME, "PATROCÍNIO DAS NEVES DA COSTA DOS SANTOS DE AZEVEDO E SILVA DE ORLEANS E BRAGANÇA")]
    public void StrRight_CaseSensitive_ReturnsAllAfter1stWord(string input, string expected)
    {
        Assert.Equal(expected, input.StrRight("DO ", StringComparison.Ordinal));
    }

    [Theory]
    [InlineData(NAME, "BRAGANÇA")]
    public void StrRight_CaseSensitive_ReturnsLastWord(string input, string expected)
    {
        Assert.Equal(expected, input.StrRightBack("E ", StringComparison.Ordinal));
    }

    [Theory]
    [InlineData(NAME, "AZEVEDO")]
    public void StrMid_IgnoreCase_ReturnsAzevedoBetweenDeAndE(string input, string expected)
    {
        Assert.Equal(expected, input.StrMid("dE ", " e"));
    }

    [Theory]
    [InlineData(NAME, "ORLEANS")]
    public void StrMidBack_IgnoreCase_ReturnsOrleansBetweenDeAndE(string input, string expected)
    {
        Assert.Equal(expected, input.StrMidBack("De ", " E"));
    }

    [Theory]
    [InlineData(NAME, "AZEVEDO")]
    public void StrMid_CaseSensitive_ReturnsAzevedoBetweenDeAndE(string input, string expected)
    {
        Assert.Equal(expected, input.StrMid("DE ", " E", StringComparison.Ordinal));
    }

    [Theory]
    [InlineData(NAME, "ORLEANS")]
    public void StrMidBack_CaseSensitive_ReturnsOrleansBetweenDeAndE(string input, string expected)
    {
        Assert.Equal(expected, input.StrMidBack("DE ", " E", StringComparison.Ordinal));
    }}