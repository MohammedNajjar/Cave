using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    // Start is called before the first frame update
    /// <summary>
    /// Multiply  input 2 number and output 1  all int
    /// for (1-10)
    /// </summary>

    void Start()
    {
        for (int a = 1; a <= 10; a++)
        {
            int sum = Multiply(5, a);
            Debug.Log("5 * " + a + "=" + sum);
        }
    }


    int Multiply(int a, int b)
    {
        return a * b;

    }
}
