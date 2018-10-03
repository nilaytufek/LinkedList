using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class Node<V>
    {
        public V value;
        public Node(V v)
        {
            value = v;
        }
        public Node<V> NextNode = null;
    }
    class LinkedList<V>
    {
        public Node<V> first = null;
        public Node<V> last = null;
        
        public LinkedList()
        {
            first = null;
            last = first;
        }
        public void Add(Node<V> node)
        {
            if (first == null)
            {
                first = node;
            }
            else
            {
                last.NextNode = node;
            }
            last = node;
        }
        public void Remove(Node<V> node)
        {
            Node<V> candidate = first;
            if (node == candidate)
            {
                first = first.NextNode;
                return;
            }
            while (Comparer<Node<V>>.Default.Compare(candidate.NextNode, node) != 0)
            {
                candidate = candidate.NextNode;
            }
            candidate.NextNode = candidate.NextNode.NextNode;

        }
        public V[] GetList()
        {
            V[] arr = new V[0];
            Node<V> tmp = first;
            int i = 0;
            while (tmp != null)
            {
                Array.Resize(ref arr, i + 1);
                arr[i] = tmp.value;
                tmp = tmp.NextNode;
                i++;
                
            }
            return arr;
        } 
        public bool Search(V val)
        {
            Node<V> tmp = first;
            while(tmp != null)
            {
                if(Comparer<V>.Default.Compare(tmp.value, val) == 0)
                {
                    return true;
                }
                tmp = tmp.NextNode;
            }

            return false;
        }

    }
}
