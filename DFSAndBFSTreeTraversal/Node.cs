namespace DFSAndBFSTreeTraversal
{
    internal class Node<T>
    {
        public IEnumerable<Node<T>> Children { get; set; }
        public T Data { get; set; }

        public Node(T data, params Node<T>[] children)
        {
            this.Data = data;
            this.Children = children;
        }
    }
}
