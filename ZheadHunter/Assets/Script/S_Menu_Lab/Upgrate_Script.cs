using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrate_Script : MonoBehaviour
{

    public Coin_obmen coin_obmen;

    public Text text_sale_dam;
    public Text text_Damagee;

    public Text text_sale_Arm;
    public Text text_sale_Arm_Blue;

    public GameObject Btn_Coin_Sale_Arn;
    public GameObject Btn_Coin_Sale_Arn_Blue;

    public GameObject Image_arm_1Lv;
    public GameObject Image_arm_1Lv_color;

    public GameObject Image_arm_2Lv;
    public GameObject Image_arm_2Lv_color;

    public GameObject Image_arm_3Lv;
    public GameObject Image_arm_3Lv_color;

    public GameObject Image_arm_4Lv;
    public GameObject Image_arm_4Lv_color;

    public GameObject Image_arm_5Lv;
    public GameObject Image_arm_5Lv_color;

    public GameObject Armor_Btn;
  
    public GameObject Armor_Btn_Blue;

    public int Lvl_Arm;
    public int Lvl_Arm_Blue;
    public int sale_Arm = 50;
    public int sale_Arm_Blue = 50;
    public int Arm_player;

    public int chetchik_arm;

    public int damage_gun_sale;
    public int coin_dam;
    public int sale_damage = 50;
    
    void Start()
    {
        chetchik_arm = 1;
        text_sale_Arm_Blue.gameObject.SetActive(false);
        Btn_Coin_Sale_Arn.SetActive(true);
        Btn_Coin_Sale_Arn_Blue.SetActive(false);

        sale_damage = 50;
        Armor_Btn.SetActive(true);
        Armor_Btn_Blue.SetActive(false);
        if (PlayerPrefs.HasKey("damage_gun"))
        {
            damage_gun_sale = PlayerPrefs.GetInt("damage_gun");
        }
        if (PlayerPrefs.HasKey("sale_damage"))
        {
            sale_damage = PlayerPrefs.GetInt("sale_damage");

        }


    }

    // Update is called once per frame
    public void Update()
    {
        //Броня синяя
        if (Lvl_Arm_Blue >= 1)
        {
            Image_arm_1Lv_color.SetActive(true);
        }
        if (Lvl_Arm_Blue >= 2)
        {
            Image_arm_2Lv_color.SetActive(true);         
        }
        if (Lvl_Arm_Blue >= 3)
        {
            Image_arm_3Lv_color.SetActive(true);            
        }
        if (Lvl_Arm_Blue >= 4)
        {
            Image_arm_4Lv_color.SetActive(true);           
        }
        if (Lvl_Arm_Blue >= 5)
        {
            Image_arm_5Lv_color.SetActive(true);           
        }


        //Лвл броня
        if (Lvl_Arm >= 1)
        {
            Image_arm_1Lv.SetActive(true);
            
        }
        if (Lvl_Arm >= 2)
        {
            Image_arm_2Lv.SetActive(true);
        }
        if (Lvl_Arm >= 3)
        {
            Image_arm_3Lv.SetActive(true);
        }
        if (Lvl_Arm >= 4)
        {
            Image_arm_4Lv.SetActive(true);
        }
        if (Lvl_Arm >= 5)
        {
            Image_arm_5Lv.SetActive(true);
        }


        text_sale_dam.text = sale_damage.ToString();
        text_Damagee.text = damage_gun_sale.ToString();
        text_sale_Arm.text = sale_Arm.ToString();
        text_sale_Arm_Blue.text = sale_Arm_Blue.ToString();

        if (PlayerPrefs.HasKey("Coin"))
        {
            coin_obmen.coin = PlayerPrefs.GetInt("Coin");

        }
        if (PlayerPrefs.HasKey("Lvl_Arm"))
        {
            Lvl_Arm = PlayerPrefs.GetInt("Lvl_Arm");

        }


    }

    public void Update_Arm_Btn()
    {
        if(chetchik_arm == 1)
        {
            if (coin_obmen.coin >= sale_Arm)
            {
                coin_obmen.coin = coin_obmen.coin - sale_Arm;
                sale_Arm = sale_Arm * 2;              
                Lvl_Arm = Lvl_Arm + 1;

                PlayerPrefs.SetInt("Lvl_Arm", Lvl_Arm); // Лвл Брони
                PlayerPrefs.SetInt("sale_Arm", sale_Arm); // стоимость улучшения
                PlayerPrefs.SetInt("Coin", coin_obmen.coin); // Деньги
                 
            }
        }
        
    }

    public void Update_Arm_Btn_Blue()
    {
        if (chetchik_arm == 2)
        {
            if (coin_obmen.coin >= sale_Arm_Blue)
            {
                coin_obmen.coin = coin_obmen.coin - sale_Arm_Blue;
                sale_Arm_Blue = sale_Arm_Blue * 2;
                Arm_player = Arm_player + 20;
                Lvl_Arm_Blue = Lvl_Arm_Blue + 1;


                PlayerPrefs.SetInt("Lvl_Arm_Blue", Lvl_Arm_Blue);
                PlayerPrefs.SetInt("sale_Arm_Blue", sale_Arm_Blue); // стоимость улучшения
                PlayerPrefs.SetInt("Coin", coin_obmen.coin); // Деньги
                PlayerPrefs.SetInt("Arm_player", Arm_player); // Броня 
            }
        }
    }
    public void Btn_Armor_Change()
    {
        chetchik_arm = 2;
        Armor_Btn.SetActive(false);
        Armor_Btn_Blue.SetActive(true);
        
        text_sale_Arm.gameObject.SetActive(false);
        text_sale_Arm_Blue.gameObject.SetActive(true);

        Btn_Coin_Sale_Arn.SetActive(false);
        Btn_Coin_Sale_Arn_Blue.SetActive(true);

    }
    public void Btn_Arm_Change() 
    {
        chetchik_arm = 1;
        Armor_Btn.SetActive(true);
        Armor_Btn_Blue.SetActive(false);

        text_sale_Arm.gameObject.SetActive(true);
        text_sale_Arm_Blue.gameObject.SetActive(false);

        Btn_Coin_Sale_Arn.SetActive(true);
        Btn_Coin_Sale_Arn_Blue.SetActive(false);
    }
    public void Upgrade_Damage_Btn()
    {
        if(coin_obmen.coin >= sale_damage)
        {
            coin_obmen.coin = coin_obmen.coin - sale_damage;
            sale_damage = sale_damage * 2;
            damage_gun_sale = damage_gun_sale + 5;
            PlayerPrefs.SetInt("sale_damage", sale_damage); // стоимость улучшения
            PlayerPrefs.SetInt("Coin", coin_obmen.coin); // Деньги
            PlayerPrefs.SetInt("damage_gun_sale", damage_gun_sale); // Урон пушки
        }
        
    }
}
