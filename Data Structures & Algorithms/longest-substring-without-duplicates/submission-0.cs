    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int L = 0, R = 0, max = 0;

            HashSet<char> hs = new();
            while (L < s.Length)
            {
                while (R < s.Length)
                {
                    if (hs.Contains(s[R])) break;
                
                    hs.Add(s[R]);
                    R++;
                    max = Math.Max(max, R - L);
                }
                
                hs.Remove(s[L]);
                L++;
            }
            return max;
        }
    }
