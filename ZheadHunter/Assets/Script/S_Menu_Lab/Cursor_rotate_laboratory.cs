using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.Events;

//Скрипт отвечает за вращение мышины 
public class Cursor_rotate_laboratory : MonoBehaviour
{
    public GameObject Car_rotate;
    RectTransform Rect_21;
    public Vector2 turn;
    public float sensitivity = 3f;
    void Start()
    {
        Rect_21 = GetComponent<RectTransform>();
    }

    
    void Update()
    {
        if (RectTransformUtility.RectangleContainsScreenPoint(Rect_21, Input.mousePosition))
        {
            
            if (Input.GetMouseButton(0))
            {
                turn.x += Input.GetAxis("Mouse X") * sensitivity;
                Car_rotate.transform.localRotation = Quaternion.Euler(0, -turn.x, 0);
                
                Cursor.lockState = CursorLockMode.Locked; //Блокировка курсора
            }
            else
            {
                Cursor.lockState = CursorLockMode.None; //Разблокировка курсора
                return;
            }
        }
      


    }
}
