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

        Debug.Log(str1.Length); // 문자열 길이
        Debug.Log(str1.Trim()); // 앞뒤 공백 제거
        Debug.Log(str1.Trim('*')); // 앞뒤 문자 * 제거

        Debug.Log(str1.Contains('H')); // 대문자 H가 있는지
        Debug.Log(str1.Contains('h')); // 소문자 h가 있는지

        Debug.Log(str1.Contains("Hello")); // Hello가 있는지

        Debug.Log(str1.ToUpper()); ; // 대문자 변환
        Debug.Log(str1.ToLower()); ; // 소문자 변환

        str1 = (str1.Replace("HELLO", "no"));
        Debug.Log(str1);

        
    }
}

