public class Solution
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        SortedDictionary<int, int> sDir = new();
        for(int i=0;i<k;i++) sDir[nums[i]] = sDir.GetValueOrDefault(nums[i], 0) + 1;

        int[] ans = new int[nums.Length - k + 1];
        ans[0] = sDir.Keys.Last();
        for(int i=k;i<nums.Length;i++)
        {
            sDir[nums[i - k]]--;
            if(sDir[nums[i - k]] == 0) sDir.Remove(nums[i - k]);
            sDir[nums[i]] = sDir.GetValueOrDefault(nums[i], 0) + 1;
            ans[i - k + 1] = sDir.Keys.Last();
        }
        return ans;
    }
}
