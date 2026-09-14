public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;

        int[] L1 = new int[n + 2];
        int[] L2 = new int[n + 2];

        L1[0] = 1;
        L2[n + 1] = 1;

        for (int i = 1; i <= n; i++)
        {
            L1[i] = nums[i - 1] * L1[i - 1];

            int j = n - i + 1;
            L2[j] = nums[j - 1] * L2[j + 1];
        }

        int[] ans = new int[n];
        for (int i = 1; i <= n; i++)
        {
            ans[i - 1] = L1[i - 1] * L2[i + 1];
        }

        return ans;
    }
}