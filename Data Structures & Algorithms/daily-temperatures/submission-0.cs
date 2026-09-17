public class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        Stack<int> st = new();
        int[] res = new int[temperatures.Length];

        for (int i = 0; i < temperatures.Length; i++)
        {
            while (st.Count > 0 && temperatures[i] > temperatures[st.Peek()])
            {
                
                res[st.Peek()] = i - st.Pop();
            }
            st.Push(i);
        }
        return res;
    }
}
