using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HowMather : MonoBehaviour
{
    private void OnEnable()  //подписываемся на событие при включенном объекте
    {
        EventInputMenu.Data += Count;
    }

    private void OnDisable() //отписываемся от событие при отключенном объекте
    {
        EventInputMenu.Data -= Count;
    }

    private void Count(int a, int b, int c)
    {
      Invoke("Counter", 1);  
    }

    private void Counter()
    {
        GetComponent<Text>().text = "Использовано плиток:  " + Calculator.square;
        Calculator.square = 0;
    }
    
}
