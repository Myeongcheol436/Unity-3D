using System.Collections.Generic;
using UnityEngine;

public class StudyDictionary : MonoBehaviour
{
    public Dictionary<string, int> persons = new Dictionary<string, int>();

    private void Start()
    {
        persons.Add("철수", 10); //key값은 중복 허용x value 값은 중복 허용o
        persons.Add("영희", 15); //key, value
        persons.Add("영희", 17); //영희가 덮어 써짐
        persons.Add("동수", 17);

        int age = persons["철수"];
        Debug.Log($"철수의 나이는{age}입니다.");

        foreach (var person in persons)
        {
            if (person.Value == 15)
            {
                Debug.Log($"나이가 15인 사람의 이름은 {person.Key}입니다.");
            }

            Debug.Log($"{person.Key}의 나이는 {person.Value}입니다.");

        }

    }
}
