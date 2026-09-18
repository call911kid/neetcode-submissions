public class Solution
{
    public int Reverse(int x)
    {
        int ans = 0;
        while (x != 0)
        {
            int pop = x % 10;
            x /= 10;

            if (ans > int.MaxValue / 10 || ans == int.MinValue / 10 && pop < int.MinValue % 10) return 0;
            if (ans < int.MinValue / 10 || ans == int.MaxValue / 10 && pop > int.MaxValue % 10) return 0;

            ans *= 10;
            ans += pop;

            
        }

        return ans;
    }
}
