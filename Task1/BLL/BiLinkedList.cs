using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BLL
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
            BiLinkedListNode nodeToAdd = new BiLinkedListNode(value);
            if (node != null)
            {
                if (node.NextNode != null)
                {
                    nodeToAdd.NextNode = node.NextNode;
                    nodeToAdd.NextNode.PrevNode = nodeToAdd;
                }
                nodeToAdd.PrevNode = node;
                node.NextNode = nodeToAdd;
                Count++;
            }
            else
            {
                Console.WriteLine("Запрошена вставка после  несуществующей ноды");
            }
        }

        public BiLinkedListNode FindNode(int searchValue)
        {
            if (Count == 0) return null;
            BiLinkedListNode currentNode = _head;
            for (int i = 0; i < Count; i++)
            {
                if (currentNode.Value == searchValue)
                {
                    return currentNode;
                }
                currentNode = currentNode.NextNode;
            }
            Console.WriteLine("Нода с запрашиваемым значением не найдена");
            return null;
        }

        public void RemoveNode(int index)
        {
            if (index >= 0 && index < Count)
            {
                BiLinkedListNode currentNode = _head;
                for (int i = 0; i <= index; i++)
                {
                    if (i == 0)
                    {
                        currentNode = _head;
                    }
                    if (i == index)
                    {
                        if (currentNode == _head)
                        {
                            _head = currentNode.NextNode;
                            _head.PrevNode = null;
                            Count--;
                            return;
                        }
                        if (currentNode == _tail)
                        {
                            _tail = _tail.PrevNode;
                            _tail.NextNode = null;
                            Count--;
                            return;
                        }
                        if (currentNode.NextNode != null)
                            currentNode.NextNode.PrevNode = currentNode.PrevNode;
                        if (currentNode.PrevNode != null)
                            currentNode.PrevNode.NextNode = currentNode.NextNode;
                        Count--;
                    }
                    else
                    {
                        currentNode = currentNode.NextNode;
                    }
                }
            }
        }

        public void RemoveNode(BiLinkedListNode node)
        {
            BiLinkedListNode currentNode = _head;
            for (int i = 0; i < Count; i++)
            {
                if (currentNode.Equals(node))
                {
                    if (currentNode == _head)
                    {
                        _head = currentNode.NextNode;
                        _head.PrevNode = null;
                        Count--;
                        return;
                    }
                    if (currentNode == _tail)
                    {
                        _tail = _tail.PrevNode;
                        _tail.NextNode = null;
                        Count--;
                        return;
                    }
                    if (currentNode.NextNode != null)
                        currentNode.NextNode.PrevNode = currentNode.PrevNode;
                    if (currentNode.PrevNode != null)
                        currentNode.PrevNode.NextNode = currentNode.NextNode;
                    Count--;
                }
                currentNode = currentNode.NextNode;
            }
        }
    }
}
