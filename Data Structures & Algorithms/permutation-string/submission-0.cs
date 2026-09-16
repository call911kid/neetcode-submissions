public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        int[] freq1 = new int[26], freq2 = new int[26];
        foreach(var x in s1) freq1[x - 'a']++;

        for(int i=0;i<s2.Length;i++)
        {
            if (i < s1.Length-1)
            {
                freq2[s2[i] - 'a']++;
                
                continue;
            }
            freq2[s2[i] - 'a']++;
            bool ok = true;
            for(int j = 0; j < 26; j++)
            {
                if (freq1[j] != freq2[j]) ok = false;
            }

            if (ok) return true;
            freq2[s2[i - s1.Length + 1] - 'a']--;

        }

        return false;
    }
}
