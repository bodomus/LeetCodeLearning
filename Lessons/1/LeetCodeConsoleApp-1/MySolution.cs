namespace LeetCodeConsoleApp_1;

public class MySolution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var lookup = new Dictionary<int, int>(capacity: nums.Length);

        for (int i = 0; i < nums.Length; i++)
        {
            int need = target - nums[i];

            if (lookup.TryGetValue(need, out int j))
                return new[] { j, i };           // нашли пару

            // сохраняем текущий элемент, если такую пару ещё не видели
            lookup[nums[i]] = i;
        }

        return Array.Empty<int>();               // или throw new InvalidOperationException(...)
    }
}