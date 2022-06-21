using System;
using Task1.BLL;

//1) Требуется реализовать класс двусвязного списка и операции вставки, удаления и поиска элемента в нём в соответствии с интерфейсом.
//2) Требуется написать функцию бинарного поиска, посчитать его асимптотическую сложность и проверить работоспособность функции.

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BiLinkedList list = new BiLinkedList();
            list.AddNode(13);
            list.AddNode(14);
            list.AddNode(15);
            list.AddNode(16);
            var node = list.FindNode(14);
            list.AddNodeAfter(node, 17);
            list.RemoveNode(node);
            list.RemoveNode(0);
        }
    }
}
