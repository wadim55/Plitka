using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] private GameObject plitka;
    [SerializeField] private GameObject Floor;
    private float XPos = -1000, StartXPos = -1000, YPos = -700; //Angel = 0 , Offset = 10, Delta = 15;
    private GameObject[,] InstFloor = new GameObject[15,20]; 
    
    private void OnEnable()  //подписываемся на событие при включенном объекте
    {
        EventInputMenu.Data += CreateFloor;
    }

    private void OnDisable() //отписываемся от событие при отключенном объекте
    {
        EventInputMenu.Data -= CreateFloor;
    }
    
    
    private void CreateFloor(int Delta, int Offset, int Angel)    
    {
        for (var i = 0; i < 15; i++)
        {
            for (var j = 0; j < 20; j++)
            {
               Destroy(InstFloor[i,j]);
            }
        }

        if (Offset > 60) Offset = 0;
        StartXPos = -1000;
        StartXPos += Offset;
        XPos = StartXPos;
        YPos += 100 + Delta;
        
        Floor.GetComponent<RectTransform>().localRotation = Quaternion.Euler(0,0,0);
        YPos = -700;
        for (var i = 0; i < 15; i++)
        {
            for (var j = 0; j < 20; j++)
            {
                var duplicate = Instantiate(plitka);
                InstFloor[i, j] = duplicate;
                duplicate.transform.parent = Floor.transform;
                duplicate.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                duplicate.GetComponent<RectTransform>().localPosition = new Vector3(XPos, YPos, 0);
                XPos += 100 + Delta;
            }
          
            StartXPos += Offset;
            XPos = StartXPos;
            YPos += 100 + Delta;
        }
        Floor.GetComponent<RectTransform>().localRotation = Quaternion.Euler(0,0,Angel);
    }
    
}
