public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> Dr = new();

        foreach (int x in nums)
        {
            if (!Dr.ContainsKey(x))
            {
                Dr.Add(x, 0);
            }
            Dr[x]--;
        }

        PriorityQueue<int, int> Pr = new();

        foreach (var x in Dr) Pr.Enqueue(x.Key, x.Value);

        int[] ans = new int[k];

        for (int i = 0; i < k; i++) ans[i] = Pr.Dequeue();

        return ans;



    }
}
