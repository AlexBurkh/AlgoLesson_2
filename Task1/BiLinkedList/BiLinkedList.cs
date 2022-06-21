using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BiLinkedList
{
    internal class BiLinkedList : IBiLinkedList
    {
        public int Count { get; private set; }
        private BiLinkedListNode _head = null;
        private BiLinkedListNode _tail = null;

        public void AddNode(int value)
        {
            BiLinkedListNode node = new BiLinkedListNode(value);

            if (Count == 0)
            {
                _head = node;
            }
            else
            {
                _tail.NextNode = node;
                node.PrevNode = _tail;
            }
            _tail = node;
            Count++;
        }

        public void AddNodeAfter(BiLinkedListNode node, int value)
        {
            throw new NotImplementedException();
        }

        public BiLinkedListNode FindNode(int searchValue)
        {
            throw new NotImplementedException();
        }

        public void RemoveNode(int index)
        {
            if (index < 0) return;
            BiLinkedListNode currentNode = _head;
            for (int i = 0; i < index - 1; i++)
            {
                if (currentNode.NextNode != null)
                {
                    currentNode = currentNode.NextNode;
                }
            }
            currentNode.NextNode = null;
        }

        public void RemoveNode(BiLinkedListNode node)
        {
            if (_head.Equals(node))
            {
                _head = null;
            }
            else
            {
                BiLinkedListNode currentNode = _head;
                for (int i = 0; i < Count; i++)
                {
                    currentNode = currentNode.NextNode;
                    if (currentNode.Equals(node))
                    {
                        currentNode = null;
                    }
                }
            }
            
        }
    }
}
