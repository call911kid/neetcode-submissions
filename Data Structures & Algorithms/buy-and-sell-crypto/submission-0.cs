public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int max = 0, min = int.MaxValue;
        foreach (int x in prices){
            max = Math.Max(max, x - min);
            min = Math.Min(min, x);
        }

        return max;
    }
}
