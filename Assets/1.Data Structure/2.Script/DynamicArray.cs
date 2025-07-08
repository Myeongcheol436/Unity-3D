using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;

public class DynamicArray : MonoBehaviour
{

    //object[] array = new object[3];

    //public List<int> list1 = new List<int>();
    //public List<int> list2 = new List<int>() {1,2,3,4,5};
    //public List<int> list3;


    //void Add(object o)
    //{
    //    var temp = new object[array.Length + 1];
    //    for (int i = 0; i < array.Length; i++)
    //    {
    //        temp[i] = array[i];
    //    }

    //    array = temp;
    //    array[array.Length - 1] = o;
    //}
    public List<int> list1 = new List<int>() { 1, 2, 3 };


    private void Start()
    {
        list1.Add(10);

        for (int i =0; i < 10; i++)
        {
            list1.Add(i);
        }
        list1.Insert(0, 1);

        //    list1.Add(1);
        //    list2.Add(1);
        //    list3.Add(1);

        list1.Remove(5); //�� 5����
        list1.RemoveAt(5); //�ε��� 5����
        list1.RemoveRange(1,5); //�ε��� 1~5�� ����
        list1.Clear(); //���� ����
    }
}