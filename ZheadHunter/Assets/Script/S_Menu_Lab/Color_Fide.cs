using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Color_Fide : MonoBehaviour
{

    public GameObject Color_Picker1;
    public GameObject Color_Neon;
    public GameObject Color_Picker;
    // Start is called before the first frame update
    void Start()
    {
        Color_Picker1.gameObject.SetActive(false);
        Color_Picker.gameObject.SetActive(false);
        Color_Neon.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Color_Car_Interect()
    {
        Color_Picker.gameObject.SetActive(true);
        Color_Picker1.gameObject.SetActive(false);
        Color_Neon.gameObject.SetActive(false);
    }
    public void Color_Car_Interect1()
    {
        Color_Picker1.gameObject.SetActive(true);
        Color_Picker.gameObject.SetActive(false);
        Color_Neon.gameObject.SetActive(false);
    }
    public void Color_Car_Interect2()
    {
        Color_Picker1.gameObject.SetActive(false);
        Color_Picker.gameObject.SetActive(false);
        Color_Neon.gameObject.SetActive(true);
    }
}
