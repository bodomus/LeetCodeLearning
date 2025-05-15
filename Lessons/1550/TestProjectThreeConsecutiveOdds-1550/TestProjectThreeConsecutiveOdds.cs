using AutoFixture;

namespace TestProjectThreeConsecutiveOdds;

public class TestProjectThreeConsecutiveOdds
{
    private readonly Fixture _fixture = new Fixture();
    private Solution test = new Solution(); 
    
    [Fact]
    public void ThreeConsecutiveOdds()
    {
        int[] invalidArray = new int[10]{1,2,3,4,5,6,7,8,9,10};
        int[] validArray = new int[8]{1,3,5,6,7,8,9,10};
        int[] validArray1 = new int[7]{1,2,3,6,7,9,11};

        Assert.False(test.ThreeConsecutiveOdds(invalidArray));
        Assert.True(test.ThreeConsecutiveOdds(validArray));
        Assert.True(test.ThreeConsecutiveOdds(validArray1));
    }
}