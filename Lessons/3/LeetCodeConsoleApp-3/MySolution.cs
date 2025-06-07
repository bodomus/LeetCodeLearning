namespace LeetCodeConsoleApp_3;

public class MySolution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        //nums1.Concat(nums2).ToList().Sort();
        int[] merged1 = nums1.Concat(nums2).ToArray();
        var merged = merged1.Order().ToList();
        int l = merged.Count;
        double result = 0;
        
        if (l % 2 == 0)
        {
            result = (merged[l / 2 - 1] + merged[l / 2]) / 2.0;
        }
        else
        {
            
            result = (merged[l / 2]);
        }
        return result;
    }
}