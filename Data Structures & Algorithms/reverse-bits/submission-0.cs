public class Solution
{
    public uint ReverseBits(uint n)
    {
        uint ans = 0;
        for (int i = 0;i<32;i++)
        {
            if ((n & (1 << i)) == 0) continue;

            ans |= 1u << (31 - i);
        }

        return ans;
    }
}
