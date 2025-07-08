using UnityEngine;

public class StudyString : MonoBehaviour
{
    public string str1 = "HELLO W O O R R L L D***";

    public string[] str2 = new string[3] { "so", "hot", "helpme" };

    private void Start()
    {
        Debug.Log(str1[0]); // H

        Debug.Log(str1[2]); // L

        Debug.Log(str2[0]); // so
        Debug.Log(str2[2]); // helpme

        Debug.Log(str1.Length); // ���ڿ� ����
        Debug.Log(str1.Trim()); // �յ� ���� ����
        Debug.Log(str1.Trim('*')); // �յ� ���� * ����

        Debug.Log(str1.Contains('H')); // �빮�� H�� �ִ���
        Debug.Log(str1.Contains('h')); // �ҹ��� h�� �ִ���

        Debug.Log(str1.Contains("Hello")); // Hello�� �ִ���

        Debug.Log(str1.ToUpper()); ; // �빮�� ��ȯ
        Debug.Log(str1.ToLower()); ; // �ҹ��� ��ȯ

        str1 = (str1.Replace("HELLO", "no"));
        Debug.Log(str1);

        
    }
}

