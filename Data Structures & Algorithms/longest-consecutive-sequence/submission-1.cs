public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        Array.Sort(nums);

        Dictionary<int, int> dir = new();

        int max = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            dir[nums[i]] = dir.GetValueOrDefault(nums[i] - 1) + 1;

            max = Math.Max(max, dir[nums[i]]);
        }

        return max;
    }
}
