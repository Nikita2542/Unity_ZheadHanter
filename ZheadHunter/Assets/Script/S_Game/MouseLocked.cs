using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLocked : MonoBehaviour
{
    RectTransform Rect_22;
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Rect_22 = GetComponent<RectTransform>();
       
    }
    private void Update()
    {
        if (RectTransformUtility.RectangleContainsScreenPoint(Rect_22, Input.mousePosition))
        {
            Cursor.lockState = CursorLockMode.Locked; //Блокировка курсора
            Cursor.visible = false;
        }
        Cursor.lockState = CursorLockMode.None;
        if (Input.GetKey("y"))
        {
            Cursor.lockState = CursorLockMode.None; //Блокировка курсора
            Cursor.visible = true;
        }
    }
}

  
    
