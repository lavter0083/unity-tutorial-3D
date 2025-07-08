using System.Collections.Generic;
using UnityEngine;

public class StudyLinkedList : MonoBehaviour
{
    public LinkedList<int> linkedList1 = new LinkedList<int>();
    public LinkedListNode<int> node2;

    private void Start()
    {
        for (int i = 0; i <= 10; i++)
        {
            linkedList1.AddLast(i); // 1~10까지 추가
        }
        linkedList1.AddFirst(10);
        linkedList1.AddLast(50);

        var node = linkedList1.AddFirst(1);

        linkedList1.AddBefore(node, 100);
        linkedList1.AddAfter(node2, 30);
    }
}
