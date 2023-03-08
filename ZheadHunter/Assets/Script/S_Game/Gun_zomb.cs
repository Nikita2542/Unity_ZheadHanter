using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gun_zomb : MonoBehaviour
{
    public int damage_gun = 20;
    public float range_gun = 100f;
    public float fireRate = 50f;
    public float Last_TargetForce = 40;  
    public Camera Gun_Camera;
    public ParticleSystem muzzleFlash;
    public GameObject Last_Target;
    private float nextTimeToFire = 0f;

    public void Start()
    {
        if (PlayerPrefs.HasKey("damage_gun_sale"))
        {
            damage_gun = PlayerPrefs.GetInt("damage_gun_sale");
        }              
    }
    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
        }
        PlayerPrefs.SetInt("damage_gun", damage_gun);
    }   
    void Shoot()
    {
        muzzleFlash.Play();       
        RaycastHit hit_gun;      
        if (Physics.Raycast(Gun_Camera.transform.position, Gun_Camera.transform.forward, out hit_gun, range_gun))
        {           
            if (PlayerPrefs.HasKey("damage_gun_sale"))
            {
            damage_gun = PlayerPrefs.GetInt("damage_gun_sale");
            }
            Debug.Log(hit_gun.transform.name);
            Zombie_Enemy zombie_enemy = hit_gun.transform.GetComponent<Zombie_Enemy>();                     
            if (zombie_enemy != null)
            {
                zombie_enemy.TakeDamage_gun(damage_gun);
            }                       
            GameObject Last_TargetGO = Instantiate(Last_Target, hit_gun.point, Quaternion.LookRotation(hit_gun.normal));
            Destroy(Last_TargetGO, 2f);
        }     
    }
}


