using LeetCodeConsoleApp_3;

namespace TestProjectLengthOfLongestSubstring_3a;

public class TestLengthOfLongestSubstring
{
    
    private MySolution _solution = new MySolution();
    [Fact]
    public void ShouldGet_3()
    {
        // Arrange
        string input = "abcabcbb";
        int expected = 3;
        
        // Act
        int fact = _solution.LengthOfLongestSubstring(input);
        
        //Assert 
        Assert.Equal(expected, fact);

    }
    
    [Fact]
    public void ShouldGet_1()
    {
        // Arrange
        string input = "bbbbb";
        int expected = 1;
        
        // Act
        int fact = _solution.LengthOfLongestSubstring(input);
        
        //Assert 
        Assert.Equal(expected, fact);

    }
    
    [Fact]
    public void ShouldGet_3a()
    {
        // Arrange
        string input = "pwwkew";
        int expected = 3;
        
        // Act
        int fact = _solution.LengthOfLongestSubstring(input);
        
        //Assert 
        Assert.Equal(expected, fact);

    }
}