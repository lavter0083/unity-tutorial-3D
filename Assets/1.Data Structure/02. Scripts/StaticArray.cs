using UnityEngine;

public class StaticArray : MonoBehaviour
{
    public int Number1 = 30;
    public int Number2 = 33;
    public int Number3 = 35;

    // 자료향 [ ] : 정적 배열
    public int[] array1; // 배열 선언
    public int[] array2 = {1, 2, 3, 4, 5, 6}; // 배열 선언과 초기화
    public int[] array3 = new int[5]; // 배열 선언 및 공간 할당
    public int[] array4 = new int[5] {10, 20, 30, 40, 50}; // 배열 선언 및 공간 할당 + 초기화

    private void Start()
    {
        Debug.Log(array2[1]);
    }
}
