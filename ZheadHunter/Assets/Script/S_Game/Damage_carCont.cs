using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage_carCont : MonoBehaviour
{
    public int collisionDamage_car = 50;
    public string collisionTag_car;

    private void OnCollisionEnter(Collision collis)
    {
        if (collis.gameObject.tag == collisionTag_car)
        {
            Speed_Damage speed_damage = collis.gameObject.GetComponent<Speed_Damage>();
            speed_damage.TakeHit(collisionDamage_car);

        }
    }

}
