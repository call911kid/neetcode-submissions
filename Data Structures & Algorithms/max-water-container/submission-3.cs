public class Solution
{
    public int MaxArea(int[] heights)
    {
        int[] L = new int[heights.Length + 1];
        int[] R = new int[heights.Length + 1];
        L[0] = heights[0];
        R[0] = heights[heights.Length - 1];
        for (int i = 1; i < heights.Length; i++) L[i] = Math.Max(L[i - 1], heights[i]);
        for (int i = 1; i < heights.Length; i++) R[i] = Math.Max(R[i - 1], heights[heights.Length - i - 1]);
       
        int max = 0;
        for (int i = 0; i < heights.Length; i++)
        {
            int left = UpperBound(L, 0, i, heights[i]);
            int right = UpperBound(R, 0, heights.Length - i - 1, heights[i]);

            max = Math.Max(max, Math.Max((i - left) * heights[i], (heights.Length - right - i - 1) * heights[i]));
        }

        return max;


    }
    private int UpperBound(int[] arr, int L, int R, int target)
    {
        int ans = -1;
        while (L <= R)
        {
            int mid = L + (R - L) / 2;

            if (arr[mid] < target)
            {
                L = mid + 1;
            }
            else
            {
                ans = mid;
                R = mid - 1;
            }

        }

        return ans;
    }
}
