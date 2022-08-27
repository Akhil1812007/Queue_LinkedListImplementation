namespace Queue_LinkedListImplementation
{
    internal class Node<T>
    {
        internal T data;
        internal Node<T> next;
        public Node(T data)
        {
            this.data = data;
        }
    }
}