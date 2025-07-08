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
        // 데이터 추가
        // list1.Add(10); // 마지막에 값 10을 list1에 추가됨

        // for (int i = 0; i < 10; i++) // 0 ~ 9까지 값을 list1에 추가
        // {
            // list1.Add(i);
        // }

        // list1.Insert(1, 50); // list1의 1번째 값에 50을 삽입함

        // list1.Remove(5); // 값 5를 제거

        // list1.RemoveAt(5); // 인덱스 5번에 있는 값을 제거

        // list1.RemoveRange(1, 3); // 인덱스 1번부터 3번까지 제거

        // list1.Clear(); // 데이터 모두 제거

        // list1.RemoveAll(x => x > 5); // 현재 List 안에서 x > 5 값은 모두 제거

        // list1.Sort(); // 오름차순 정렬

        //if (list1.Contains(10)) // List에서 10라는 값이 있으면 true
            //Debug.Log("값 10이 존재");
        //else
            //Debug.Log("값 10 없음");

    }
}
