using UnityEngine;

public class StudyString : MonoBehaviour
{
    public string str1 = "Hello World";
    public string[] str2 = new string[3] { "Hello", "Unity", "World" };

    private void Start()
    {
        //Debug.Log(str1.Trim('l')); //앞뒤 l제거
        //Debug.Log(str1.Contains("Hello"));

        //Debug.Log(str1.ToUpper());
        //Debug.Log(str1.ToLower());

        //str1 = str1.Replace("World", "Unity");
        //Debug.Log(str1);

        string text = "Apple, Banana, Orange";

        string[] fruits = text.Split(',');

        foreach (var fruit in fruits)
        {
            Debug.Log(fruit);
        }
    }
}
