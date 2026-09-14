public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {


        Dictionary<string, List<string>> res = new();

        foreach (var x in strs) {
            string y = Transform(x);

            if (!res.ContainsKey(y)) res.Add(y, new List<string>());
            
            res[y].Add(x);
        }


        List<List<string>> Anagrams = new();

        foreach (var x in res) Anagrams.Add(x.Value);


        return Anagrams;

    }
    public string Transform(string str)
    {
        int[] freq = new int[26];

        foreach (var x in str) freq[x - 'a']++;

        return string.Join(",", freq);
    }
}
