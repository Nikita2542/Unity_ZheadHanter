using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zombie_Enemy : MonoBehaviour
{
    public float health_zomb = 100f;
    public GameObject Sliz_Green;
    public GameObject Sliz_Yellow;
    public GameObject Sliz_Red;
    public void TakeDamage_gun(float amount)
    {
        health_zomb -= amount;    
        if(health_zomb<= 0f)
        {
            if (gameObject.tag == "Zombie_green")
            {
                Die();
                GameObject Sliz_Green_Go = Instantiate(Sliz_Green, transform.position, Quaternion.Euler(90, 0, 0));
            }
            if (gameObject.tag == "Zombie_yellow")
            {
                Die();
                GameObject Sliz_Yellow_Go = Instantiate(Sliz_Yellow, transform.position, Quaternion.Euler(90, 0, 0));
            }
            if (gameObject.tag == "Zombie_red")
            {
                Die();
                GameObject Sliz_Red_Go = Instantiate(Sliz_Red, transform.position, Quaternion.Euler(90, 0, 0));
            }


        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
