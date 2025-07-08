using System.Collections.Generic;
using UnityEngine;

public class StudyStack : MonoBehaviour
{
    public Stack<int> stack = new Stack<int>();

    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            stack.Push(i); // 1 ~ 10���� ���� Stack�� �߰�
        }

        Debug.Log(stack.Pop()); // Last ���� ����

        Debug.Log(stack.Peek()); // �� ������ ���� ����� Ȯ��
    }
}

