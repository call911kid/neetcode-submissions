public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {


        Dictionary<string, List<string>> Anagrams = new();

        foreach (var x in strs) {
            string y = Transform(x);

            if (!Anagrams.ContainsKey(y)) Anagrams.Add(y, new List<string>());

            Anagrams[y].Add(x);
        }

        return Anagrams.Values.ToList();

    }
    public string Transform(string str)
    {
        int[] freq = new int[26];

        foreach (var x in str) freq[x - 'a']++;

        return string.Join(",", freq);
    }
}
