namespace DFSAndBFSTreeTraversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tree = new Node<int>(9,
                new Node<int>(7, new Node<int>(25), new Node<int>(72), new Node<int>(8)),
                new Node<int>(14),
                new Node<int>(3, new Node<int>(1), new Node<int>(19)));

            //                     9
            //
            //         7           14          3
            //
            //  25    72    8             1       19

            Console.WriteLine($"{new String('=', 20)} Breadth-First Search (BFS) {new String('=', 20)}");
            BFSTraverse(tree);
            Console.WriteLine();

            Console.WriteLine($"{new String('=', 20)} Depth-First Search (DFS) {new String('=', 20)}");
            DFSTraverse(tree);
        }

        public static void DFSTraverse<T>(Node<T> node, Stack<Node<T>> s = null)
        {
            s = s ?? new Stack<Node<T>>();
            s.Push(node);
            foreach (var item in node.Children)
            {
                DFSTraverse(item, s);
            }

            Console.WriteLine(s.Pop().Data);
        }

        public static void BFSTraverse<T>(Node<T> node)
        {
            var q = new Queue<Node<T>>();
            q.Enqueue(node);

            while (q.Count > 0)
            {
                node = q.Dequeue();
                Console.WriteLine(node.Data);
                foreach (var item in node.Children)
                {
                    q.Enqueue(item);
                }
            }
        }
    }
}
