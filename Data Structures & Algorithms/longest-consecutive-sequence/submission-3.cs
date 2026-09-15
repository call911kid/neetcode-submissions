public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        Array.Sort(nums);

        int max = 1, len = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1]) continue;
            else if (nums[i] == nums[i - 1] + 1) len++;
            else len = 1;

            max = Math.Max(max, len);
        }

        return Math.Min(max,nums.Length);
    }
}
