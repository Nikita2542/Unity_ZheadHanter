using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun2_Zomb : MonoBehaviour
{
    public int damage_gun2 = 20;
    public float range_gun = 10f;
    public float fireRate = 50f;
    public float Last_TargetForce = 40;
    public Camera Gun_Camera;
    public ParticleSystem muzzleFlash;
    public GameObject Last_Target;
    private float nextTimeToFire = 0f;
    
    public AudioSource Audi_surce;

    public void Start()
    {
        
        
        if (PlayerPrefs.HasKey("damage_gun2_sale"))
        {
            damage_gun2 = PlayerPrefs.GetInt("damage_gun2_sale");
        }
    }
    private void Update()
    {
        Audi_surce.mute = true;
        muzzleFlash.Stop();
        if (Input.GetButton("Fire1")){
            Audi_surce.mute = false;
            muzzleFlash.Play();
        }
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
        }
        PlayerPrefs.SetInt("damage_gun2", damage_gun2);
    }
    void Shoot()
    {
        
        
        RaycastHit hit_gun;
        if (Physics.Raycast(Gun_Camera.transform.position, Gun_Camera.transform.forward, out hit_gun, range_gun))
        {
            if (PlayerPrefs.HasKey("damage_gun2_sale"))
            {
                damage_gun2 = PlayerPrefs.GetInt("damage_gun2_sale");
            }
            Debug.Log(hit_gun.transform.name);
            Zombie_Enemy zombie_enemy = hit_gun.transform.GetComponent<Zombie_Enemy>();
            if (zombie_enemy != null)
            {
                zombie_enemy.TakeDamage_gun(damage_gun2);
            }
            GameObject Last_TargetGO = Instantiate(Last_Target, hit_gun.point, Quaternion.LookRotation(hit_gun.normal));
            Destroy(Last_TargetGO, 2f);
        }
    }
}
