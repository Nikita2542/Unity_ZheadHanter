using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ligth_Fonar : MonoBehaviour
{
    public Light light_Fonar;
    public float intensiv = 0;
    public int dd = 0;
    
    public void Start()
    {
        
        light_Fonar = GetComponent<Light>();
        intensiv = 0;
    }
    public void Update()
    {

        if (Input.GetKeyDown("e"))
        {
            if (light_Fonar.intensity == 0)
            {
                light_Fonar.intensity = intensiv = 3;
            }
            else
            {
                light_Fonar.intensity = 0;
            }


        }
        
       

        
        
        
            
        
    }
    public void Fonar_Ligth()
    {

        light_Fonar.intensity = intensiv = 3;
    }
}
