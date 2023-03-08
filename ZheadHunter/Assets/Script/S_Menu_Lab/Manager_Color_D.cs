using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager_Color_D : MonoBehaviour
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
    Color color = Color.magenta;
    public int Resolf;
    public void ColorWhite1()
    {
        Resolf = 1;
        PlayerPrefs.SetInt("Red", Resolf);
        transform.GetComponent<Renderer>().material.color = Color_White.color;
    }
    public void ColorRed2()
    {
        Resolf = 2;
        PlayerPrefs.SetInt("Red", Resolf);
        transform.GetComponent<Renderer>().material.color = Color_Red.color;
        
    }
    public void Color_Pink3()
    {
        Resolf = 3;
        PlayerPrefs.SetInt("Red", Resolf);
        transform.GetComponent<Renderer>().material.color = Color_Pink.color;
    }
    public void Color_Violet4()
    {
        Resolf = 4;
        PlayerPrefs.SetInt("Red", Resolf);
        transform.GetComponent<Renderer>().material.color = Color_Violet.color;
    }
    public void Color_Purple5()
    {
        Resolf = 5;
        PlayerPrefs.SetInt("Red", Resolf);
        transform.GetComponent<Renderer>().material.color = Color_Purple.color;
    }
    public void Color_Dark_Blue6()
    {
        Resolf = 6;
        PlayerPrefs.SetInt("Red", Resolf);
        transform.GetComponent<Renderer>().material.color = Color_Dark_Blue.color;
    }
    public void Color_Blue7()
    {
        Resolf = 7;
        PlayerPrefs.SetInt("Red", Resolf);
        transform.GetComponent<Renderer>().material.color = Color_Blue.color;
    }
    public void Color_Emerald8()
    {
        Resolf = 8;
        PlayerPrefs.SetInt("Red", Resolf);
        transform.GetComponent<Renderer>().material.color = Color_Emerald.color;
    }
    public void Color_Turquoise9()
    {
        Resolf = 9;
        PlayerPrefs.SetInt("Red", Resolf);
        transform.GetComponent<Renderer>().material.color = Color_Turquoise.color;
    }
    public void Color_Dark_Green10()
    {
        Resolf = 10;
        PlayerPrefs.SetInt("Red", Resolf);
        transform.GetComponent<Renderer>().material.color = Color_Dark_Green.color;
    }
    public void Color_Green11()
    {
        Resolf = 11;
        PlayerPrefs.SetInt("Red", Resolf);
        transform.GetComponent<Renderer>().material.color = Color_Green.color;
    }
    public void Color_Grass12()
    {
        Resolf = 12;
        PlayerPrefs.SetInt("Red", Resolf);
        transform.GetComponent<Renderer>().material.color = Color_Grass.color;
    }
    public void Color_Lime13()
    {
        Resolf = 13;
        PlayerPrefs.SetInt("Red", Resolf);
        transform.GetComponent<Renderer>().material.color = Color_Lime.color;
    }
    public void Color_Yellow14()
    {
        Resolf = 14;
        PlayerPrefs.SetInt("Red", Resolf);
        transform.GetComponent<Renderer>().material.color = Color_Yellow.color;
    }
    public void Color_Lemon15()
    {
        Resolf = 15;
        PlayerPrefs.SetInt("Red", Resolf);
        transform.GetComponent<Renderer>().material.color = Color_Lemon.color;
    }
    public void Color_Orange16()
    {
        Resolf = 16;
        PlayerPrefs.SetInt("Red", Resolf);
        transform.GetComponent<Renderer>().material.color = Color_Orange.color;
    }
    public void Color_Dark_Orange17()
    {
        Resolf = 17;
        PlayerPrefs.SetInt("Red", Resolf);
        transform.GetComponent<Renderer>().material.color = Color_Dark_Orange.color;
    }
    public void Color_Black18()
    {
        Resolf = 18;
        PlayerPrefs.SetInt("Red", Resolf);
        transform.GetComponent<Renderer>().material.color = Color_Black.color;
    }
    public void Color_Gray19()
    {
        Resolf = 19;
        PlayerPrefs.SetInt("Red", Resolf);
        transform.GetComponent<Renderer>().material.color = Color_Gray.color;
    }
    public void Color_Light_Gray20()
    {
        Resolf = 20;
        PlayerPrefs.SetInt("Red", Resolf);
        transform.GetComponent<Renderer>().material.color = Color_Light_Gray.color;
    }
    public void Start()
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
}

