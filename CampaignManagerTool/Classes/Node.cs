public class Node<T>
{
    public Node<T> Next;
    public T Object;
    public Node<T> Previous;

    public Node(T obj, Node<T> next = default, Node<T> previous = default)
    {
        Object = obj;
        Next = next;
        Previous = previous;
    }

    public Node<T> GetLast()
    {
        if (Next == default) return this;
        return Next.GetLast();
    }

    public Node<T> GetFirst()
    {
        if (Previous == default) return this;
        return Previous.GetFirst();
    }
}