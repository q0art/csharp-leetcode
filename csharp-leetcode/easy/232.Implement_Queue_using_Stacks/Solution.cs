namespace csharp_leetcode.easy._232.Implement_Queue_using_Stacks;

public class MyQueue
{

    private Stack<int> _stack;

    public MyQueue()
    {
        _stack = new Stack<int>();
    }
    
    public void Push(int x)
    {
        var stack = new Stack<int>();

        while (_stack.Count > 0)
        {
            stack.Push(_stack.Pop());
        }
        
        stack.Push(x);

        while (stack.Count > 0)
        {
            _stack.Push(stack.Pop());
        }
    }
    
    public int Pop()
    {
        return _stack.Pop();
    }
    
    public int Peek()
    {
        return _stack.Peek();
    }
    
    public bool Empty()
    {
        return _stack.Count == 0;
    }
}