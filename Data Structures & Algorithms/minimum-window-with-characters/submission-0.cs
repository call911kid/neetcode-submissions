public class Solution
{
    public string MinWindow(string s, string t)
    {
        int[] freq2 = new int[256];
        foreach(char c in t) freq2[c]++;

        int L = 1, R = s.Length;
        string ans = "";
        while (L <= R)
        {
            int mid = L + (R - L) / 2;
            string check = CheckInclusion(s, mid, freq2);
            if (check == null) L = mid + 1;
            else
            {
                ans = check;
                R = mid - 1;
            }
            //Console.WriteLine($"{mid} = {check}");
        }

        return ans;
    }
    public string CheckInclusion(string s1, int len, int[] freq2)
    {
        int[] freq1 = new int[256];

        for (int i = 0; i < s1.Length; i++)
        {
            if (i < len - 1)
            {
                freq1[s1[i]]++;

                continue;
            }
            freq1[s1[i]]++;
            bool ok = true;
            for (int j = 0; j < 256; j++)
            {
                if (freq1[j] < freq2[j]) ok = false;
            }

            if (ok) return s1.Substring(i - len + 1, len);
            freq1[s1[i - len + 1]]--;

        }

        return null;
    }
}
