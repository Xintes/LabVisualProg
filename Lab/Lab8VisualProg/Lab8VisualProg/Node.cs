using System.Collections;

namespace Lab8VisualProg
{
    public class Node<T> where T : IComparable<T>
    {
        public T Data { get; }
        public Node<T> Left { get; set; } = null!;
        public Node<T> Right { get; set; } = null!;
        public Node(T data) => Data = data;
    } 
}
