using PalabrasMagicas;

public class WordProcessorTests
{
    [Fact]
    public void ReverseWord_WhenWordIsValid_ShouldReturnReversedWord()
    {
        
        var word = "Hola";


        var result = WordProcessor.ReverseWord(word);


        Assert.Equal("aloH", result);
    }

    [Fact]
    public void ReverseWord_WhenWordContainsUpperAndLowerCase_ShouldReverseAndMaintainCasing()
    {
        
        var word = "AbCdE";


        var result = WordProcessor.ReverseWord(word);


        Assert.Equal("EdCbA", result);
    }

    [Fact]
    public void IsPalindrome_WhenWordIsPalindrome_ShouldReturnTrue()
    {
        
        var word = "reconocer";


        var result = WordProcessor.IsPalindrome(word);


        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_WhenWordIsNotPalindrome_ShouldReturnFalse()
    {
        
        var word = "Hola";


        var result = WordProcessor.IsPalindrome(word);


        Assert.False(result);
    }

    [Fact]
    public void IsPalindrome_WhenWordHasOneCharacter_ShouldReturnTrue()
    {
        
        var word = "a";


        var result = WordProcessor.IsPalindrome(word);


        Assert.True(result);
    }

    [Fact]
    public void CountVowels_WhenWordContainsVowels_ShouldReturnCorrectCount()
    {
        
        var word = "Hola";


        var result = WordProcessor.CountVowels(word);


        Assert.Equal(2, result);
    }

    [Fact]
    public void CountVowels_WhenWordContainsNoVowels_ShouldReturnZero()
    {
        
        var word = "Gypsy";


        var result = WordProcessor.CountVowels(word);


        Assert.Equal(0, result);
    }

    [Fact]
    public void CountVowels_WhenWordContainsUpperAndLowerCase_ShouldReturnCorrectCount()
    {
        
        var word = "AbCdEfGhI";


        var result = WordProcessor.CountVowels(word);


        Assert.Equal(3, result);
    }
}
