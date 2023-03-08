using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_Upgrate : MonoBehaviour
{
    public Coin_obmen coin_obmen;

    public Text text_sale_health;
    public Text text_Health;

    public int health_sale = 100;
    public int coin_health;
    public int sale_health = 50;

    






    void Start()
    {
        health_sale = 100;
        sale_health = 50;
        if (PlayerPrefs.HasKey("health_sale"))
        {
            health_sale = PlayerPrefs.GetInt("health_sale");
        }
        if (PlayerPrefs.HasKey("sale_health"))
        {
            sale_health = PlayerPrefs.GetInt("sale_health");

        }



    }

    // Update is called once per frame
    void Update()
    {
        text_sale_health.text = sale_health.ToString();
        text_Health.text = health_sale.ToString();

        if (PlayerPrefs.HasKey("Coin"))
        {
            coin_obmen.coin = PlayerPrefs.GetInt("Coin");
        }

    }
    public void Upgrade_Health_Btn()
    {
        if (coin_obmen.coin >= sale_health)
        {
            coin_obmen.coin = coin_obmen.coin - sale_health;
            sale_health = sale_health * 2;
            health_sale = health_sale + 5;
            PlayerPrefs.SetInt("sale_health", sale_health); // стоимость улучшения
            PlayerPrefs.SetInt("Coin", coin_obmen.coin); // Деньги
            PlayerPrefs.SetInt("health_sale", health_sale); // Здоровье
            
        }
    }
}
