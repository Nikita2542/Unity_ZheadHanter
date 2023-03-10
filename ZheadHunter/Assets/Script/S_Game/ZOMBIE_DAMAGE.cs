using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ZOMBIE_DAMAGE : MonoBehaviour
{
    public Armor_pl_Lvl Armor_Pl;
    public GameObject player_car;
    //public Transform respawnpoint;
    public float health_player = 100f;
    public float maxHealth = 100f;
    public float pointIncreasePersecond; // через скок секунд улучшается здоровье
    public GameObject zombi_enemy;
    public int damage_enemy = 10;
    public Slider slider_player;
    public Speedometr speedometr;
    public GameObject Game_over;
    private float nextTimeToFire = 0f;
    public float fireRate = 1f;
    
    private void Start()
    {
     health_player = 100;
     maxHealth = 100;
        pointIncreasePersecond = 4f;

    Game_over.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {

        if (Armor_Pl.Armor_Value <= 0)
        {
            if (other.gameObject.tag == "Zombie_green" && Time.time >= nextTimeToFire)
            {
                nextTimeToFire = Time.time + 1f / fireRate;
                if (speedometr.speed_CAR <= 60)
                {
                    health_player = health_player - damage_enemy;
                }
            }
            if (other.gameObject.tag == "Zombie_yellow" && Time.time >= nextTimeToFire)
            {
                nextTimeToFire = Time.time + 1f / fireRate;

                if (speedometr.speed_CAR <= 60)
                {
                    health_player = health_player - damage_enemy;
                }
            }
            if (other.gameObject.tag == "Zombie_red" && Time.time >= nextTimeToFire)
            {
                nextTimeToFire = Time.time + 1f / fireRate;

                if (speedometr.speed_CAR <= 60)
                {
                    health_player = health_player - damage_enemy;
                }
            }
        }

    }
    private void Update()
    {

        if (health_player < 100)
        {
           Invoke("Health_regeneration", 3);
        }


            slider_player.value = health_player;

       

        if (health_player <= 0)
        {

            Game_over.SetActive(true);
            Destroy(player_car);
            //player_car.transform.position = respawnpoint.position;
        }

       
    }

    public void Health_regeneration()
    {
       
        
        health_player += pointIncreasePersecond * Time.deltaTime;









        if (health_player > maxHealth)
        {
            health_player = 100;
        }
    }
} 

