public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        for(int i=0;i<numbers.Length;i++)
        {
            int idx=Array.BinarySearch(numbers,i+1, numbers.Length-i-1, target-numbers[i]);

            if(idx > 0) return new int[]{i+1,idx+1};
        }
        return new int[0]; // duh, strongly typed languages
    }
}
