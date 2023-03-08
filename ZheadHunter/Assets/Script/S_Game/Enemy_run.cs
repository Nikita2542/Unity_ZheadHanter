using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_run : MonoBehaviour
{
    public Light _lite;
    
    public Speedometr speedometr;
    public GameObject player_Target;
    public float run_enem = 5f;

    public void Update()
    {
        if (_lite.intensity >= 0.9f)
        {
            transform.position = Vector3.MoveTowards(transform.position, player_Target.transform.position, Time.deltaTime * run_enem);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (speedometr.speed_CAR >= 30)
            {
                run_enem = 2;
            }
        }

        
        
    }
}
    
