public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int L = 0, R = 0, max = 0, chars=0;

        int[] freq=new int[26];
        while (L <= R && L < s.Length)
        {
            while (R < s.Length && freq[s[R]-'a'] == 0)
            {


                freq[s[R] - 'a']++;
                chars++;
                R++;
                max = Math.Max(max, R - L);
            }
            freq[s[L] - 'a']--;
            chars--;
            L++;
        }
        return max;
    }
}
