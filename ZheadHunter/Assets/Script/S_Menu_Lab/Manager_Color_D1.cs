using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager_Color_D1 : MonoBehaviour
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
    Color color = Color.magenta;
    public int Resolf;
    public void ColorWhite1()
    {
        Resolf = 1;
        PlayerPrefs.SetInt("Red1", Resolf);
        Mat_Wheels.color = Color_White.color;
       
    }
    public void ColorRed2()
    {
        Resolf = 2;
        PlayerPrefs.SetInt("Red1", Resolf);
        Mat_Wheels.color = Color_Red.color;

    }
    public void Color_Pink3()
    {
        Resolf = 3;
        PlayerPrefs.SetInt("Red1", Resolf);
        Mat_Wheels.color = Color_Pink.color;
    }
    public void Color_Violet4()
    {
        Resolf = 4;
        PlayerPrefs.SetInt("Red1", Resolf);
        Mat_Wheels.color = Color_Violet.color;
    }
    public void Color_Purple5()
    {
        Resolf = 5;
        PlayerPrefs.SetInt("Red1", Resolf);
        Mat_Wheels.color = Color_Purple.color;
    }
    public void Color_Dark_Blue6()
    {
        Resolf = 6;
        PlayerPrefs.SetInt("Red1", Resolf);
        Mat_Wheels.color = Color_Dark_Blue.color;
    }
    public void Color_Blue7()
    {
        Resolf = 7;
        PlayerPrefs.SetInt("Red1", Resolf);
        Mat_Wheels.color = Color_Blue.color;
    }
    public void Color_Emerald8()
    {
        Resolf = 8;
        PlayerPrefs.SetInt("Red1", Resolf);
        Mat_Wheels.color = Color_Emerald.color;
    }
    public void Color_Turquoise9()
    {
        Resolf = 9;
        PlayerPrefs.SetInt("Red1", Resolf);
        Mat_Wheels.color = Color_Turquoise.color;
    }
    public void Color_Dark_Green10()
    {
        Resolf = 10;
        PlayerPrefs.SetInt("Red1", Resolf);
        Mat_Wheels.color = Color_Dark_Green.color;
    }
    public void Color_Green11()
    {
        Resolf = 11;
        PlayerPrefs.SetInt("Red1", Resolf);
        Mat_Wheels.color = Color_Green.color;
    }
    public void Color_Grass12()
    {
        Resolf = 12;
        PlayerPrefs.SetInt("Red1", Resolf);
        Mat_Wheels.color = Color_Grass.color;
    }
    public void Color_Lime13()
    {
        Resolf = 13;
        PlayerPrefs.SetInt("Red1", Resolf);
        Mat_Wheels.color = Color_Lime.color;
    }
    public void Color_Yellow14()
    {
        Resolf = 14;
        PlayerPrefs.SetInt("Red1", Resolf);
        Mat_Wheels.color = Color_Yellow.color;
    }
    public void Color_Lemon15()
    {
        Resolf = 15;
        PlayerPrefs.SetInt("Red1", Resolf);
        Mat_Wheels.color = Color_Lemon.color;
    }
    public void Color_Orange16()
    {
        Resolf = 16;
        PlayerPrefs.SetInt("Red1", Resolf);
        Mat_Wheels.color = Color_Orange.color;
    }
    public void Color_Dark_Orange17()
    {
        Resolf = 17;
        PlayerPrefs.SetInt("Red1", Resolf);
        Mat_Wheels.color = Color_Dark_Orange.color;
    }
    public void Color_Black18()
    {
        Resolf = 18;
        PlayerPrefs.SetInt("Red1", Resolf);
        Mat_Wheels.color = Color_Black.color;
    }
    public void Color_Gray19()
    {
        Resolf = 19;
        PlayerPrefs.SetInt("Red1", Resolf);
        Mat_Wheels.color = Color_Gray.color;
    }
    public void Color_Light_Gray20()
    {
        Resolf = 20;
        PlayerPrefs.SetInt("Red1", Resolf);
        Mat_Wheels.color = Color_Light_Gray.color;
    }
    public void Start()
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
}
