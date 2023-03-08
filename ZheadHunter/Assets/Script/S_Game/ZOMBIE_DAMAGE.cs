using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ZOMBIE_DAMAGE : MonoBehaviour
{
    public GameObject player_car;
    //public Transform respawnpoint;
    public int health_player = 100;
    public GameObject zombi_enemy;
    public int damage_enemy = 10;
    public Slider slider_player;
    public Speedometr speedometr;
    public GameObject Game_over;

    private void Start()
    {
        Game_over.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Zombie")
        {
            if (speedometr.speed_CAR <= 60)
            {
                health_player = health_player - damage_enemy;
            }
        }
    }
    private void Update()
    {
        
        
            slider_player.value = health_player;
        
        
        if(health_player <= 0)
        {
            
            Game_over.SetActive(true);
            Destroy(player_car);
            //player_car.transform.position = respawnpoint.position;
        }
    }
}
