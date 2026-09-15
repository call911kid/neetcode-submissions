public class Solution
{
    public int LongestConsecutive(int[] nums)
    {

        HashSet<int> hs = new(nums);

        int max = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (hs.Contains(nums[i] - 1)) continue;

            int len = 1;

            while (hs.Contains(nums[i] + len++)) { }
            
            max= Math.Max(max, len-1);
        }

        return max;
    }
}
