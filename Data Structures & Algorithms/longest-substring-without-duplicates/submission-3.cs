public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int L = 0, R = 0, max = 0, chars=0;

        int[] freq=new int[256];
        while (L < s.Length)
        {
            while (R < s.Length && freq[s[R]] == 0)
            {


                freq[s[R]]++;
                chars++;
                R++;
                max = Math.Max(max, R - L);
            }
            freq[s[L]]--;
            chars--;
            L++;
        }
        return max;
    }
}
