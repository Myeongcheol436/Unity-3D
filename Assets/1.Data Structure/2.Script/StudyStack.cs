using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StudyStack : MonoBehaviour
{
    public Stack<int> stack = new Stack<int>();
    public List<int> list1 = new List<int>();

    public int[] array = new int[3] {1,2,3};
    public int[] array2;

    private void Start()
    {
        //for (int i = 1; i <= 10; i++)
        //{
        //    stack.Push(i);
        //}

        //Debug.Log(stack.Pop()); //마지막으로 들어온것 뽑기, 삭제
        //Debug.Log(stack.Peek()); //그 다음에 뽑힐 대상 확인
        stack = new Stack<int>(array);

        array2 = stack.ToArray();
        list1 = stack.ToList();
    }

}
