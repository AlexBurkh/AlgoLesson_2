using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BiLinkedList
{
    internal class BiLinkedListNode
    {
        internal int Value { get; set; }
        internal BiLinkedListNode NextNode { get; set; }
        internal BiLinkedListNode PrevNode { get; set; }


        public BiLinkedListNode(int value)
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as BiLinkedListNode);
        }

        public bool Equals(BiLinkedListNode node)
        {
            if (this.Value == node.Value && this.NextNode == node.NextNode && this.PrevNode == node.PrevNode)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value, this.NextNode.Value, this.PrevNode.Value);
        }
    }
}
