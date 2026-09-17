public class MinStack
{
    List<(int, int)> lst = new();

    
    public MinStack()
    {
        
    }

    public void Push(int val)
    {
        lst.Add((val, lst.Count == 0 ? val : Math.Min(val, lst[lst.Count - 1].Item2)));
    }

    public void Pop()
    {
        lst.RemoveAt(lst.Count - 1);
    }

    public int Top()
    {
        return lst[lst.Count - 1].Item1;
    }

    public int GetMin()
    {
        return lst[lst.Count - 1].Item2;
    }
}
