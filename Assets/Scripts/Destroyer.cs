
using UnityEngine;
using System.Collections;
public class Destroyer : MonoBehaviour
{
    private RectTransform Rect;
    private void Start()
    {
        Rect = GetComponent<RectTransform>();
        CleanFloor();
    }
   
    private void CleanFloor()
    {
        print(Rect.position.x + " " +  Screen.height/2);
        if (Rect.position.x < -9.8f || Rect.position.x > 9.8f || Rect.position.y < -6.1f ||
            Rect.position.y > 6.1f)
           Destroy(gameObject);
    }

   
    
}
