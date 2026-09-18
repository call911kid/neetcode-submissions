public class Solution
{
    
    
    public List<List<int>> Subsets(int[] nums)
    {

        List<List<int>> ls = new();
        
        for(int i = 0; i < (1 << nums.Length); i++)
        {
            List<int> subset=new List<int>();
            for(int j = 0; j < 10; j++)
            {
                if ((i & (1 << j)) != 0) subset.Add(nums[j]);
            }
            ls.Add(subset);
        }

        return ls;
    }
    
}
