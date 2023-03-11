using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Slider_Damage : MonoBehaviour{

    public int slider_gun;
    public Slider slider_damage;
    public int slider_rate = 10;
    public Slider slider_rate_of_shoot;
    public int slider_shoot_range = 60;
    public Slider slider_shooting_range;
    public void Start()
    {
        if (PlayerPrefs.HasKey("damage_gun"))
        {
            slider_gun = PlayerPrefs.GetInt("damage_gun");
        }
    }
    public void Update()
    {
        slider_shooting_range.value = slider_shoot_range;
        slider_damage.value = slider_gun;
        slider_rate_of_shoot.value = slider_rate;
    }

}
