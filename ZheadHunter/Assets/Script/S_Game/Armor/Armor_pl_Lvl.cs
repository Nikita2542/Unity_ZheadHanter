using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor_pl_Lvl : MonoBehaviour
{
    public Speedometr speedometr;
    public ZOMBIE_DAMAGE zombie_damage;

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

    public int Lvl_Armor;
    public int Lvl_Armor_Blue;

    public int Armor_Value = 0;

    public int damage_zomb_Green = 10;
    public int damage_zomb_Yellow = 20;
    public int damage_zomb_Red = 30;

    private float nextTimeToFire = 0f;
    public float fireRate = 1f;
    void Start()
    {
        if (PlayerPrefs.HasKey("Lvl_Arm"))
        {
            Lvl_Armor = PlayerPrefs.GetInt("Lvl_Arm");

        }
        if (PlayerPrefs.HasKey("Lvl_Arm_Blue"))
        {
            Lvl_Armor_Blue = PlayerPrefs.GetInt("Lvl_Arm_Blue");

        }
        //Ћвл брон€
        if (Lvl_Armor >= 1)
        {
            Image_arm_1Lv.SetActive(true);
        }
        if (Lvl_Armor >= 2)
        {
            Image_arm_2Lv.SetActive(true);
        }
        if (Lvl_Armor >= 3)
        {
            Image_arm_3Lv.SetActive(true);
        }
        if (Lvl_Armor >= 4)
        {
            Image_arm_4Lv.SetActive(true);
        }
        if (Lvl_Armor >= 5)
        {
            Image_arm_5Lv.SetActive(true);
        }

        //Ѕрон€ син€€
        if (Lvl_Armor_Blue >= 1)
        {
            Armor_Value += 20;
            Image_arm_1Lv_color.SetActive(true);
        }
        if (Lvl_Armor_Blue >= 2)
        {
            Armor_Value += 20;
            Image_arm_2Lv_color.SetActive(true);
        }
        if (Lvl_Armor_Blue >= 3)
        {
            Armor_Value += 20;
            Image_arm_3Lv_color.SetActive(true);
        }
        if (Lvl_Armor_Blue >= 4)
        {
            Armor_Value += 20;
            Image_arm_4Lv_color.SetActive(true);
        }
        if (Lvl_Armor_Blue >= 5)
        {
            Armor_Value += 20;
            Image_arm_5Lv_color.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {


        if (Armor_Value < 20)
        {
            Image_arm_1Lv_color.SetActive(false);
        }
        if (Armor_Value < 40)
        {
            Image_arm_2Lv_color.SetActive(false);
        }
        if (Armor_Value < 60)
        {
            Image_arm_3Lv_color.SetActive(false);
        }
        if (Armor_Value < 80)
        {
            Image_arm_4Lv_color.SetActive(false);
        }
        if (Armor_Value < 100)
        {
            Image_arm_5Lv_color.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Zombie_green"  && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
        

            if (speedometr.speed_CAR <= 60)
            {
                Armor_Value = Armor_Value - damage_zomb_Green;
            }


        }
        if (other.gameObject.tag == "Zombie_yellow" && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
           
            if (speedometr.speed_CAR <= 60)
            {
                
                
                    Armor_Value = Armor_Value - damage_zomb_Yellow;
                
            }
        }
        if (other.gameObject.tag == "Zombie_red" && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;

            if (speedometr.speed_CAR <= 60)
            {
                
                
                    Armor_Value = Armor_Value - damage_zomb_Red;
                
            }
        }
    }
}
