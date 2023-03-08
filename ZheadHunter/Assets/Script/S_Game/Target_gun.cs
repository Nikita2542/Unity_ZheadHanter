using UnityEngine;

public class Target_gun : MonoBehaviour

{
    
   
    public GameObject[] enem_zomb_g = new GameObject[1];
    public GameObject[] enem_zomb_y = new GameObject[1];
    public GameObject[] enem_zomb_r = new GameObject[1];

    public GameObject[] slizz_g = new GameObject[1];
    public GameObject[] slizz_y = new GameObject[1];
    public GameObject[] slizz_r = new GameObject[1];

 
    public int zomb_enemy_g;
    public int zomb_enemy_y;
    public int zomb_enemy_r;
    
   


    public void Start()
    {
        slizz_g[0].SetActive(false);
        slizz_y[0].SetActive(false);
        slizz_r[0].SetActive(false);
    }
   
    
    
    
}