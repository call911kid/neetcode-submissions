public class Solution
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);

        HashSet<(int, int, int)> tuples = new();

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                int val = -(nums[i] + nums[j]);
                int idx = Array.BinarySearch(nums, 0, i, val);
                if (idx >= 0) tuples.Add((nums[idx], nums[i], nums[j]));

                idx = Array.BinarySearch(nums, i + 1, j - i - 1, val);
                if (idx >= 0) tuples.Add((nums[i], nums[idx], nums[j]));

                idx = Array.BinarySearch(nums, j + 1, nums.Length - j - 1, val);
                if (idx >= 0) tuples.Add((nums[i], nums[j], nums[idx]));

            }
        }

        return tuples
            .Select(x => new List<int> { x.Item1, x.Item2, x.Item3 })
            .ToList();
    }
}
