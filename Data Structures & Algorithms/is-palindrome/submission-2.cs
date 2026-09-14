public class Solution
{
    public bool IsPalindrome(string s)
    {
        for (int i = 0,j=s.Length-1; i<j;)
        {
            while (i < j && !IsAlphaNumeric(s[i])) i++;
            while (i < j && !IsAlphaNumeric(s[j])) j--;

            if (i < j && char.ToLower(s[i]) != char.ToLower(s[j])) return false;

            i++; j--;
        }

        return true;
    }

    private bool IsAlphaNumeric(char c)
    {
        return char.IsLetterOrDigit(c);
    }
}
