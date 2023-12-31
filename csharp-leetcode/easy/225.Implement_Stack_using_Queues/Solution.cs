namespace csharp_leetcode.easy._225.Implement_Stack_using_Queues;

public class MyStack
{
    private Queue<int> _queue;

    public MyStack()
    {
        _queue = new Queue<int>();
    }

    public void Push(int x)
    {
        _queue.Enqueue(x);

        for (int i = 0; i < _queue.Count - 1; i++)
            _queue.Enqueue(_queue.Dequeue());
    }

    public int Pop() => _queue.Dequeue();
    
    public int Top() => _queue.Peek();
    
    public bool Empty() => _queue.Count == 0;
}