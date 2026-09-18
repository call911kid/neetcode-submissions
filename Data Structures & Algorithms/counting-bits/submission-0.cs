public class Solution
{
    public int[] CountBits(int n)
    {
        int[] ans = new int[n+1];
        for(int i = 0; i <= n; i++)
        {
            for (int j = i; j > 0; j &= (j - 1)) ans[i]++;
        }

        return ans;
    }
}
