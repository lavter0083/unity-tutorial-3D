using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class StudyDictionry : MonoBehaviour
{
    public Dictionary<string, int> persons = new Dictionary<string, int>();

    private void Start()
    {
        // Dictionary�� ������ �߰�
        persons.Add("ö��", 10);
        persons.Add("����", 15);
        persons.Add("����", 20);

        persons["ö��"] = 13; // ö�� �� �����

        int age = persons["ö��"]; // key������ value�� ���
        Debug.Log($"ö���� ���̴� {age}�Դϴ�.");

        foreach (var person in persons )
        {
            if (person.Value == 15)
                Debug.Log($"���̰� 15�� ����� �̸��� {person.Key}�Դϴ�.");
            
            Debug.Log($"{person.Key}�� ���̴� {person.Value}�Դϴ�.");
        }

        if (persons.ContainsKey("ö��"))
        {
            Debug.Log("��� �߿� ö���� �ִ� ������");
        }

        if (persons.ContainsValue(17))
        {
            Debug.Log("17���� ����� �ִ�.");
        }
    }
}
