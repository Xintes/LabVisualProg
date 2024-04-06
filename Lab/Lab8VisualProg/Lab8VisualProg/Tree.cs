using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8VisualProg
{
    public class Tree<T> : IEnumerable<T> where T : IComparable<T>
    {
        private Node<T> root;

        public IEnumerator<T> GetEnumerator()
        {
            return InOrderTraversal(root).GetEnumerator();
        }

        private IEnumerable<T> InOrderTraversal(Node<T> node)
        {
            if (node != null)
            {
                foreach (var item in InOrderTraversal(node.Left))
                    yield return item;

                yield return node.Data;

                foreach (var item in InOrderTraversal(node.Right))
                    yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        //------------------------------------в ширину
        //public IEnumerator<T> GetEnumerator()
        //{
        //    return BreadthFirstTraversal(root).GetEnumerator();
        //}

        //private IEnumerable<T> BreadthFirstTraversal(Node<T> node)
        //{
        //    if (node == null)
        //        yield break;

        //    Queue<Node<T>> queue = new Queue<Node<T>>();
        //    queue.Enqueue(node);

        //    while (queue.Count > 0)
        //    {
        //        Node<T> current = queue.Dequeue();
        //        yield return current.Data;

        //        if (current.Left != null)
        //            queue.Enqueue(current.Left);

        //        if (current.Right != null)
        //            queue.Enqueue(current.Right);
        //    }
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return GetEnumerator();
        //}

        public void Insert(T element)
        {
            if (root == null)
            {
                root = new Node<T>(element);
            }
            else
            {
                InsertElement(root, element);
            }
        }

        private void InsertElement(Node<T> node, T element)
        {
            if (element.CompareTo(node.Data) < 0)
            {
                if (node.Left == null)
                {
                    node.Left = new Node<T>(element);
                }
                else
                {
                    InsertElement(node.Left, element);
                }
            }
            else if (element.CompareTo(node.Data) > 0)
            {
                if (node.Right == null)
                {
                    node.Right = new Node<T>(element);
                }
                else
                {
                    InsertElement(node.Right, element);
                }
            }
        }

        public bool Find(T element)
        {
            return FindElement(root, element);
        }

        private bool FindElement(Node<T> node, T element)
        {
            if (node == null)
            {
                return false;
            }

            if (element.CompareTo(node.Data) == 0)
            {
                return true;
            }
            else if (element.CompareTo(node.Data) < 0)
            {
                return FindElement(node.Left, element);
            }
            else
            {
                return FindElement(node.Right, element);
            }
        }

        public void Remove(T element)
        {
            root = Remove(root, element);
        }

        private Node<T> Remove(Node<T> node, T element)
        {
            if (node == null)
                return node;

            int comparison = element.CompareTo(node.Data);

            if (comparison < 0)
            {
                node.Left = Remove(node.Left, element);
            }
            else if (comparison > 0)
            {
                node.Right = Remove(node.Right, element);
            }
            else
            {
                if (node.Left == null)
                    return node.Right;
                else if (node.Right == null)
                    return node.Left;

                Node<T> minValueNode = FindMinValueNode(node.Right);
                node.Right = Remove(node.Right, minValueNode.Data);
                node = new Node<T>(minValueNode.Data) { Left = node.Left, Right = node.Right };
            }

            return node;
        }

        private Node<T> FindMinValueNode(Node<T> node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node;
        }


       
    }
}
