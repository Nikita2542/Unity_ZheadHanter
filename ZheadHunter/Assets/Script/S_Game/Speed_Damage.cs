using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speed_Damage : MonoBehaviour
{
    public Speedometr speedometr;
    
    public int health_car = 100;
    public GameObject car_Enemy;
    
    public Slider slider_car;
    public void TakeHit(int collisionDamage_car)
    {
        if (speedometr.speed_CAR >= 60)
        {
            
            health_car = health_car - collisionDamage_car;
            slider_car.value = health_car;
        }   
        
    }
    
    public void Update()
    {if(health_car == 0)
        {
            car_Enemy.SetActive(false);
        }
        slider_car.value = health_car;
    }
}
