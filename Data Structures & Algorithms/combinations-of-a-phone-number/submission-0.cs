public class Solution
{
    List<string> ls = new();

    public List<string> LetterCombinations(string digits)
    {
        if (digits.Length == 0)
            return ls;

        BackTrack(0, digits, new StringBuilder());

        return ls;
    }

    private void BackTrack(int i, string str, StringBuilder strB)
    {
        if (i == str.Length)
        {
            ls.Add(strB.ToString());

            return;
        }

        
        var s = GetLetters(str[i]);

        

        foreach(var c in s)
        {
            strB.Append(c);
            BackTrack(i + 1, str, strB);
            strB.Remove(strB.Length - 1, 1);
        }


    }

    private string GetLetters(char digit)
    {
        int d = digit - '0';

        int start = (d - 2) * 3;

        if (d > 7)
            start++;

        return new string(
            Enumerable.Range(0, d == 7 || d == 9 ? 4 : 3)
                      .Select(i => (char)('a' + start + i))
                      .ToArray()
        );
    }
}
