using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Coin_obmen : MonoBehaviour
{
    [SerializeField]

    public int coin;

    [SerializeField]
    public int slizz_green;
    public int slizz_yellow;
    public int slizz_red;

  

    private int sale_coin_g;
    private int sale_coin_y;
    private int sale_coin_r;

    
    private int slizz_g_sale = 10;
    private int slizz_y_sale = 20;
    private int slizz_r_sale = 30;

    [SerializeField]
    public Text coin_text;

    public Text slizz_g;
    public Text slizz_y;
    public Text slizz_r;
    
    [SerializeField]
    public Text Sale_text_g;
    public Text Sale_text_y;
    public Text Sale_text_r;


    private void Start()
    {


        if (PlayerPrefs.HasKey("Sliz_green_g"))
        {
            slizz_green = PlayerPrefs.GetInt("Sliz_green_g");
        }
        if (PlayerPrefs.HasKey("Sliz_yellow_g"))
        {
            slizz_yellow = PlayerPrefs.GetInt("Sliz_yellow_g");
        }
        if (PlayerPrefs.HasKey("Sliz_red_g"))
        {
            slizz_red = PlayerPrefs.GetInt("Sliz_red_g");
        }
    }

    // Update is called once per frame
    void Update()
    {
        

        if (PlayerPrefs.HasKey("Coin"))
        {
            coin = PlayerPrefs.GetInt("Coin");
        }
        coin_text.text = coin.ToString();

        Sale_text_g.text = sale_coin_g.ToString();
        Sale_text_y.text = sale_coin_y.ToString();
        Sale_text_r.text = sale_coin_r.ToString();

        slizz_g.text = slizz_green.ToString();
        slizz_y.text = slizz_yellow.ToString();
        slizz_r.text = slizz_red.ToString();
        
    }

    public void Plus_Sale_Green()
    {
        if(sale_coin_g <= slizz_green - 1)
        {
            sale_coin_g = sale_coin_g + 1;
        }
        
    }
    public void Minus_Sale_Green()
    {
        if(sale_coin_g >= 1)
        {
            sale_coin_g = sale_coin_g - 1;
        }
        
    }

    public void Plus_Sale_Yellow()
    {
        if (sale_coin_y <= slizz_yellow - 1)
        {
            sale_coin_y = sale_coin_y + 1;
        }
    }
    public void Minus_Sale_Yellow()
    {
        if (sale_coin_y >= 1)
        {
            sale_coin_y = sale_coin_y - 1;
        }

    }
    public void Plus_Sale_Red()
    {
        if (sale_coin_r <= slizz_red - 1)
        {
            sale_coin_r = sale_coin_r + 1;
        }
    }
    public void Minus_Sale_Red()
    {
        if (sale_coin_r >= 1)
        {
            sale_coin_r = sale_coin_r - 1;
        }

    }
    public void Sale_s_green()
    {
        
        if (slizz_green >= sale_coin_g)
        {         
            slizz_green = slizz_green - sale_coin_g;
            coin = coin + (slizz_g_sale * sale_coin_g);
            PlayerPrefs.SetInt("Coin", coin);
            PlayerPrefs.SetInt("slizz_green", slizz_yellow);

            if (sale_coin_g >= slizz_green)
            {
                sale_coin_g = slizz_green;
            }

            if (slizz_green == 0)
            {
                sale_coin_g = 0;               
            }
        }
        

    }
    public void Sale_s_yellow()
    {
        if (slizz_yellow >= 1)
        {
            slizz_yellow = slizz_yellow - sale_coin_y;
            coin = coin + (slizz_y_sale * sale_coin_y);
            PlayerPrefs.SetInt("Coin", coin);
            PlayerPrefs.SetInt("slizz_yellow", slizz_yellow);
            if (sale_coin_y >= slizz_yellow)
            {
                sale_coin_y = slizz_yellow;
            }
            if (slizz_yellow == 0)
            {
                sale_coin_y = 0;
            }
        }
    }
    public void Sale_s_red()
    {
        if (slizz_red >= 1)
        {
            slizz_red = slizz_red - sale_coin_r;
            coin = coin + (slizz_r_sale * sale_coin_r);
            PlayerPrefs.SetInt("Coin", coin);
            PlayerPrefs.SetInt("slizz_red", slizz_red);
            if (sale_coin_r >= slizz_red)
            {
                sale_coin_r = slizz_red;
            }
            if (slizz_red == 0)
            {
                sale_coin_r = 0;
            }
        }
    }
}
