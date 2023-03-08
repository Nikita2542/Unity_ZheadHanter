using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_Manager_s : MonoBehaviour
{
    public GameObject Menu_sale;
    public GameObject Color_menu;
    public GameObject Menu_Upgrades;
    
    public GameObject Btn_Sale_Sliz;
    public GameObject Btn_color_menu;
    public GameObject TMI_Upgrades;
    
    public GameObject Back_Main_Menu;
    
    void Start()
    {
        Back_Main_Menu.SetActive(false);

        Btn_Sale_Sliz.SetActive(true);
        Btn_color_menu.SetActive(true);
        TMI_Upgrades.SetActive(true);
        
        Menu_sale.SetActive(false);
        Color_menu.SetActive(false);
        Menu_Upgrades.SetActive(false);
    }

    public void Btn_Sale_sliz()
    {
        Menu_sale.SetActive(true);
        Color_menu.SetActive(false);
        Menu_Upgrades.SetActive(false);

        Btn_Sale_Sliz.SetActive(false);
        Btn_color_menu.SetActive(false);
        TMI_Upgrades.SetActive(false);

        Back_Main_Menu.SetActive(true);
    }
    public void Btn_Color_car()
    {
        Menu_Upgrades.SetActive(false);
        Menu_sale.SetActive(false);
        Color_menu.SetActive(true);
        
        Btn_Sale_Sliz.SetActive(false);
        Btn_color_menu.SetActive(false);
        TMI_Upgrades.SetActive(false);

        Back_Main_Menu.SetActive(true);
    }
    public void Btn_Back_Menu()
    {
        Menu_sale.SetActive(false);
        Color_menu.SetActive(false);
        Menu_Upgrades.SetActive(false);

        Btn_Sale_Sliz.SetActive(true);
        Btn_color_menu.SetActive(true);
        TMI_Upgrades.SetActive(true);
        
        Back_Main_Menu.SetActive(false);
    }

    public void TMI_Upgrades_menu()
    {
        Menu_sale.SetActive(false);
        Color_menu.SetActive(false);
        Menu_Upgrades.SetActive(true);

        Btn_Sale_Sliz.SetActive(false);
        Btn_color_menu.SetActive(false);
        TMI_Upgrades.SetActive(false);

        Back_Main_Menu.SetActive(true);
    }
}
