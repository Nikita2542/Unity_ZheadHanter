using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slizz_Src : MonoBehaviour
{
    [SerializeReference]
    public int sliz_green;
    public int sliz_yellow;
    public int sliz_red;

    public void Update()
    {
        if (PlayerPrefs.HasKey("slizz_green"))
        {
            sliz_green = PlayerPrefs.GetInt("slizz_green");
        }
        if (PlayerPrefs.HasKey("slizz_yellow"))
        {
            sliz_yellow = PlayerPrefs.GetInt("slizz_yellow");
        }
        if (PlayerPrefs.HasKey("slizz_red"))
        {
            sliz_red = PlayerPrefs.GetInt("slizz_red");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sliz_green")
        {        
            sliz_green = sliz_green + 1;
            Destroy(other.gameObject);
            PlayerPrefs.SetInt("Sliz_green_g", sliz_green);
           

        }
        if (other.gameObject.tag == "Sliz_yellow")
        {

            sliz_yellow = sliz_yellow + 1;
            Destroy(other.gameObject);
            PlayerPrefs.SetInt("Sliz_yellow_g", sliz_yellow);


        }
        if (other.gameObject.tag == "Sliz_red")
        {

            sliz_red = sliz_red + 1;
            Destroy(other.gameObject);
            PlayerPrefs.SetInt("Sliz_red_g", sliz_red);


        }
    }
}
