using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BLL
{
    internal interface IBiLinkedList
    {
        void AddNode(int value);
        void AddNodeAfter(BiLinkedListNode node, int value);
        void RemoveNode(int index);
        void RemoveNode(BiLinkedListNode node);
        BiLinkedListNode FindNode(int searchValue);
    }
}
