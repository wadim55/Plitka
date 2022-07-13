using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InputMenu : MonoBehaviour
{
    [SerializeField] private Text Delta, Angel, Offset, Result;
    private int delta, angel, offset;


    
   public void ChangeData()
   {
       if (Delta.text != "") delta = int.Parse(Delta.text);
       if (Angel.text != "") angel = int.Parse(Angel.text);
       if (Offset.text != "") offset = int.Parse(Offset.text);
       print(delta + " " + offset + " " + angel);
     EventInputMenu.ChangeData(delta, offset, angel);
    }
    
}
