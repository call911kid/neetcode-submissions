public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> Dir = new();

        for (int i = 0; i < nums.Length; i++)
        {
            if (Dir.ContainsKey(target - nums[i]))
            {
                return new int[] { Dir[target-nums[i]],i };
            }

            Dir.Add(nums[i],i);
        }

        return new int[0]; //
    }
}
