public class Solution
{
    public int HammingWeight(uint n)
    {
        int count = 0;

        for (; n > 0; n /= 2) count += (int)(n % 2);
        
        return count;

    }
}
