using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    void Start()
    {
        Invoke("Calculate",0.2f);
    }
    private void Calculate()
    {
        Calculator.square += 1;
    }
}
