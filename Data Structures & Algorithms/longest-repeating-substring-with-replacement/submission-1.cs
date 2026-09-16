public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        int[] freq = new int[26];
        int L = 0, R = 0, max = 0;
        while(L < s.Length)
        {
            while (R < s.Length)
            {
                
                freq[s[R] - 'A']++;
                int maxChar = 0;
                foreach (var x in freq) maxChar = Math.Max(maxChar, x);
                if (R - L + 1 - maxChar > k)
                {
                    freq[s[R] - 'A']--;
                    break;
                }
                max = Math.Max(max, R - L + 1);
                ++R;
            }
            freq[s[L] - 'A']--;
            ++L;
        }
        return max;
    }
}
