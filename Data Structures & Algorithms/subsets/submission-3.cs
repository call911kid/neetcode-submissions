public class Solution
{
    List<List<int>> ls = new();

    public List<List<int>> Subsets(int[] nums)
    {
        Array.Sort(nums);
        BackTrack(0, nums, new List<int>(), -11);

        return ls;

    }
    private void BackTrack(int i, int[] nums, List<int> subset, int last)
    {
        if (i == nums.Length)
        {
            ls.Add(new List<int>(subset));
            return;
        }

        if (nums[i] != last)
        {
            subset.Add(nums[i]);
            BackTrack(i + 1, nums, subset, nums[i]);
        }
        if (nums[i] != last) subset.RemoveAt(subset.Count - 1);
        BackTrack(i + 1, nums, subset, last);
    }
}
