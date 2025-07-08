using System.Collections.Generic;
using UnityEngine;

public class DynamicArray : MonoBehaviour
{
    // public List<int> list1 = new List<int>() { 1, 2, 3};
    public object[] array = new object[0];

    public void Add(object o)
    {
        var temp = new object[array.Length + 1];
        for (int i = 0; i < array.Length; i++)
            temp[i] = array[i];

        array = temp;
        array[array.Length - 1] = o;
    }

    private void Start()
    {
        // ������ �߰�
        // list1.Add(10); // �������� �� 10�� list1�� �߰���

        // for (int i = 0; i < 10; i++) // 0 ~ 9���� ���� list1�� �߰�
        // {
            // list1.Add(i);
        // }

        // list1.Insert(1, 50); // list1�� 1��° ���� 50�� ������

        // list1.Remove(5); // �� 5�� ����

        // list1.RemoveAt(5); // �ε��� 5���� �ִ� ���� ����

        // list1.RemoveRange(1, 3); // �ε��� 1������ 3������ ����

        // list1.Clear(); // ������ ��� ����

        // list1.RemoveAll(x => x > 5); // ���� List �ȿ��� x > 5 ���� ��� ����

        // list1.Sort(); // �������� ����

        //if (list1.Contains(10)) // List���� 10��� ���� ������ true
            //Debug.Log("�� 10�� ����");
        //else
            //Debug.Log("�� 10 ����");

    }
}
