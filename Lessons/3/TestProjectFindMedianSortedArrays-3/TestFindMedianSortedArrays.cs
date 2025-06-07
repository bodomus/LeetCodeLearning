using LeetCodeConsoleApp_3;

public class TestFindMedianSortedArrays
{
    [Fact]
    public void Test1()
    {
        var mySolution = new MySolution();
        int[] a1 = [1, 3];
        int[] a2 = [2];

        var d = mySolution.FindMedianSortedArrays(a1, a2);
        Assert.Equal(2.00000, d);
    }
    
    [Fact]
    public void Test2()
    {
        var mySolution = new MySolution();
        int[] a1 = [1, 2];
        int[] a2 = [3, 4];

        var d = mySolution.FindMedianSortedArrays(a1, a2);
        Assert.Equal(2.50000, d);
    }
    
    
}