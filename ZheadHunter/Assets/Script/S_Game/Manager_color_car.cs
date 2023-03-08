using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager_color_car : MonoBehaviour
{
    public Image Color_White;
    public Image Color_Red;
    public Image Color_Pink;
    public Image Color_Violet;
    public Image Color_Purple;
    public Image Color_Dark_Blue;
    public Image Color_Blue;
    public Image Color_Emerald;
    public Image Color_Turquoise;
    public Image Color_Dark_Green;
    public Image Color_Green;
    public Image Color_Grass;
    public Image Color_Lime;
    public Image Color_Yellow;
    public Image Color_Lemon;
    public Image Color_Orange;
    public Image Color_Dark_Orange;
    public Image Color_Black;
    public Image Color_Gray;
    public Image Color_Light_Gray;
    
    public int Resolf;
    void Start()
    {
        if (PlayerPrefs.HasKey("Red"))
        {
            Resolf = PlayerPrefs.GetInt("Red");
        }



        if (Resolf == 1)
        {
            transform.GetComponent<Renderer>().material.color = Color_White.color;
        }
        if (Resolf == 2)
        {
            transform.GetComponent<Renderer>().material.color = Color_Red.color;
        }
        if (Resolf == 3)
        {
            transform.GetComponent<Renderer>().material.color = Color_Pink.color;
        }
        if (Resolf == 4)
        {
            transform.GetComponent<Renderer>().material.color = Color_Violet.color;
        }
        if (Resolf == 5)
        {
            transform.GetComponent<Renderer>().material.color = Color_Purple.color;
        }
        if (Resolf == 6)
        {
            transform.GetComponent<Renderer>().material.color = Color_Dark_Blue.color;
        }
        if (Resolf == 7)
        {
            transform.GetComponent<Renderer>().material.color = Color_Blue.color;
        }
        if (Resolf == 8)
        {
            transform.GetComponent<Renderer>().material.color = Color_Emerald.color;
        }
        if (Resolf == 9)
        {
            transform.GetComponent<Renderer>().material.color = Color_Turquoise.color;
        }
        if (Resolf == 10)
        {
            transform.GetComponent<Renderer>().material.color = Color_Dark_Green.color;
        }
        if (Resolf == 11)
        {
            transform.GetComponent<Renderer>().material.color = Color_Green.color;
        }
        if (Resolf == 12)
        {
            transform.GetComponent<Renderer>().material.color = Color_Grass.color;
        }
        if (Resolf == 13)
        {
            transform.GetComponent<Renderer>().material.color = Color_Lime.color;
        }
        if (Resolf == 14)
        {
            transform.GetComponent<Renderer>().material.color = Color_Yellow.color;
        }
        if (Resolf == 15)
        {
            transform.GetComponent<Renderer>().material.color = Color_Lemon.color;
        }
        if (Resolf == 16)
        {
            transform.GetComponent<Renderer>().material.color = Color_Orange.color;
        }
        if (Resolf == 17)
        {
            transform.GetComponent<Renderer>().material.color = Color_Dark_Orange.color;
        }
        if (Resolf == 18)
        {
            transform.GetComponent<Renderer>().material.color = Color_Black.color;
        }
        if (Resolf == 19)
        {
            transform.GetComponent<Renderer>().material.color = Color_Gray.color;
        }
        if (Resolf == 20)
        {
            transform.GetComponent<Renderer>().material.color = Color_Light_Gray.color;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
