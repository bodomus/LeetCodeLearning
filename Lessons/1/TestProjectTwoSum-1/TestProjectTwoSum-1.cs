namespace LeetCodeConsoleApp_1; 
public class TestProjectTwoSum
{
    [Fact]
    public void Test1()
    {
        var m = new MySolution();
        int[] invalidArray = new int[10]{1,2,3,4,5,6,7,8,9,10};
        int invalid1 = 124;
        var rr = MySolution.TwoSum(invalidArray, invalid1);
        Assert.True(rr.Length == 0);
//

        int[] validArray = new int[8]{1,3,5,6,7,8,9,10};
        int valid2 = 9;
        rr = MySolution.TwoSum(validArray, valid2);
        int[] valid = new int [] {1, 3};
        Assert.Equal(rr, valid);
//

        int[] validArray1 = new int[7]{1,2,3,6,7,9,11};
        int valid3 = 12;
        rr = MySolution.TwoSum(validArray1, valid3);
        valid = new int [] {0, 6};
        Assert.Equal(rr, valid);
        
        int[] validArray2 = new int[7]{1,2,3,6,7,9,11};
        int valid4 = 12;
        rr = MySolution.TwoSum(validArray2, valid4);
        valid = new int [] {0, 6};
        Assert.Equal(rr, valid);
    }
}