
public class Solution
{
    public int Trap(int[] heights)
    {
        int[] L = new int[heights.Length + 1];
        int[] R = new int[heights.Length + 1];
        L[0] = heights[0];
        R[heights.Length - 1] = heights[heights.Length - 1];
        for (int i = 1; i < heights.Length; i++) L[i] = Math.Max(L[i - 1], heights[i]);
        for (int i = heights.Length - 2; i >= 0; i--) R[i] = Math.Max(R[i + 1], heights[i]);

        int ans = 0;
        for(int i=0;i<heights.Length;i++)
        {
            ans += Math.Min(L[i], R[i]) - heights[i];
        }

        return ans;
    }
}
