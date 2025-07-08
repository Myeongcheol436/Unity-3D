using UnityEngine;

public class StaticArray : MonoBehaviour
{
    int[] array1;
    int[] array2 = {10, 20, 30, 40, 50}; //qoduf tjsdjsr
    int[] array3 = new int[5];
    int[] array4 = new int[5] { 10, 20, 30, 40, 50 };

    
    private void Start()
    {
        int number = array2[3];
        int[] array5;
        array1 = new int[5];
    }
}
