public class Solution
{
    public int SingleNumber(int[] nums)
    {
        int ans = 0;

        for(int j = 0; j < nums.Length; j++) ans^= nums[j];

        return ans;
    }
}
