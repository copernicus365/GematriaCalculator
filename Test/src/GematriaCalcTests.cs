namespace Test;

public class GematriaCalcTests
{
    [Fact]
    public void Hebr_WVowels_WBreathings_WithSpace()
        => calcHeb("סְפֹר הַכּ֣וֹכָבִ֔ים", 443);

    [Fact]
    public void Hebr_NoVowels_WithSpace()
        => calcHeb("ספר הכוכבים", 443);

    [Fact]
    public void Hebr_NoSpace()
        => calcHeb("הכוכבים", 103);

    [Fact]
    public void Hebr_Yeshua_WVowels()
        => calcHeb("יֵשוּע", 386);

    [Fact]
    public void Hebr_Yeshua_NoVowels()
        => calcHeb("ישוע", 386);

    [Fact]
    public void Hebr_150_ieLastPsalm_WithNunSofit()
        => calcHeb("קן", 150);

    [Fact]
    public void Hebr_150_ieLastPsalm_RegNun()
         => calcHeb("קנ", 150);

    [Fact]
    public void Syr_WVowels_WithSpace()
        => calcSyr("ܡܢܺܝ ܟܰܘܟ̈ܒܶܐ", 149);

    [Fact]
    public void Syr_NoVowels_WSeyame_WithSpace()
        => calcSyr("ܡܢܝ ܟܘܟ̈ܒܐ", 149);

    [Fact]
    public void Syr_NoSpace()
        => calcSyr("ܟܘܟ̈ܒܐ", 49);

    [Fact]
    public void Syr_WSofit_Qushy()
        => calcSyr("ܡܱܠܟ݁ܺܝܢ", 150);

    void calcHeb(string text, int value)
    {
        int val = GematriaCalc.Calculate(text);
        Assert.True(val == value);
    }

    void calcSyr(string text, int value)
    {
        int val = GematriaCalc.CalculateSyriac(text);
        Assert.True(val == value);
    }
}