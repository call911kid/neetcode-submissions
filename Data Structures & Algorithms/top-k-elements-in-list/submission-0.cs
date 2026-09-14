public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> Dr = new();

        foreach(int x in nums) Dr[x]=Dr.GetValueOrDefault(x, 0) - 1;

        PriorityQueue<int, int> Pr = new();

        foreach(var x in Dr) Pr.Enqueue(x.Key, x.Value);

        int[] ans = new int[k];

        for (int i = 0; i < k; i++) ans[i] = Pr.Dequeue();

        return ans;



    }
}
