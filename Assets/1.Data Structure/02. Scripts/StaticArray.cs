using UnityEngine;

public class StaticArray : MonoBehaviour
{
    public int Number1 = 30;
    public int Number2 = 33;
    public int Number3 = 35;

    // �ڷ��� [ ] : ���� �迭
    public int[] array1; // �迭 ����
    public int[] array2 = {1, 2, 3, 4, 5, 6}; // �迭 ����� �ʱ�ȭ
    public int[] array3 = new int[5]; // �迭 ���� �� ���� �Ҵ�
    public int[] array4 = new int[5] {10, 20, 30, 40, 50}; // �迭 ���� �� ���� �Ҵ� + �ʱ�ȭ

    private void Start()
    {
        Debug.Log(array2[1]);
    }
}
