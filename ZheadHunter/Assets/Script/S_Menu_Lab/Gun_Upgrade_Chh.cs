using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Gun_Upgrade_Chh : MonoBehaviour
{
    public GameObject Gun_Open_1;
    public int Gun1;
    void Start()
    {
        Gun_Open_1.SetActive(false);
        if (PlayerPrefs.HasKey("Gun1"))
        {
            Gun1 = PlayerPrefs.GetInt("Gun1");

        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Gun1 == 1)
        {
            Gun_Open_1.SetActive(true);
        }
        if (Gun1 == 0)
        {
            Gun_Open_1.SetActive(false);
        }
            
        
    }

    public void Open_Gun_1()
    {
        Gun1 = 1;
        Gun_Open_1.SetActive(true);
        PlayerPrefs.SetInt("Gun1", Gun1);
    }


    public void Upgrade_Gun()
    {
        
        SceneManager.LoadScene(2);
    }
    public void Upgrade_Menu()
    {
        SceneManager.LoadScene(1);
    }

}
