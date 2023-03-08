using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager_color_carbone : MonoBehaviour
{
    public Material Mat_Wheels;
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
        if (PlayerPrefs.HasKey("Red1"))
        {
            Resolf = PlayerPrefs.GetInt("Red1");
        }



        if (Resolf == 1)
        {
            Mat_Wheels.color = Color_White.color;
        }
        if (Resolf == 2)
        {
            Mat_Wheels.color = Color_Red.color;
        }
        if (Resolf == 3)
        {
            Mat_Wheels.color = Color_Pink.color;
        }
        if (Resolf == 4)
        {
            Mat_Wheels.color = Color_Violet.color;
        }
        if (Resolf == 5)
        {
            Mat_Wheels.color = Color_Purple.color;
        }
        if (Resolf == 6)
        {
            Mat_Wheels.color = Color_Dark_Blue.color;
        }
        if (Resolf == 7)
        {
            Mat_Wheels.color = Color_Blue.color;
        }
        if (Resolf == 8)
        {
            Mat_Wheels.color = Color_Emerald.color;
        }
        if (Resolf == 9)
        {
            Mat_Wheels.color = Color_Turquoise.color;
        }
        if (Resolf == 10)
        {
            Mat_Wheels.color = Color_Dark_Green.color;
        }
        if (Resolf == 11)
        {
            Mat_Wheels.color = Color_Green.color;
        }
        if (Resolf == 12)
        {
            Mat_Wheels.color = Color_Grass.color;
        }
        if (Resolf == 13)
        {
            Mat_Wheels.color = Color_Lime.color;
        }
        if (Resolf == 14)
        {
            Mat_Wheels.color = Color_Yellow.color;
        }
        if (Resolf == 15)
        {
            Mat_Wheels.color = Color_Lemon.color;
        }
        if (Resolf == 16)
        {
            Mat_Wheels.color = Color_Orange.color;
        }
        if (Resolf == 17)
        {
            Mat_Wheels.color = Color_Dark_Orange.color;
        }
        if (Resolf == 18)
        {
            Mat_Wheels.color = Color_Black.color;
        }
        if (Resolf == 19)
        {
            Mat_Wheels.color = Color_Gray.color;
        }
        if (Resolf == 20)
        {
            Mat_Wheels.color = Color_Light_Gray.color;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
