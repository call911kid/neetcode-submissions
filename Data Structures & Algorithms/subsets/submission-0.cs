public class Solution
{
    List<List<int>> ls = new();
    
    public List<List<int>> Subsets(int[] nums)
    {
        BackTrack(0, nums, new List<int>());

        return ls;

    }
    private void BackTrack(int i, int[] nums, List<int> subset)
    {
        if (i == nums.Length)
        {
            ls.Add(new List<int>(subset));
            return;
        }
       
        subset.Add(nums[i]);
        BackTrack(i + 1, nums, subset);
        subset.RemoveAt(subset.Count - 1);
        BackTrack(i + 1, nums, subset);
    }
}
