using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speedometr : MonoBehaviour
{
    public Rigidbody target;

    public float maxSpeed = 0.0f; // The maximum speed of the target ** IN KM/H **

    

    [Header("UI")]
    public Text speedLabel; // The label that displays the speed;
    

    public float speed_CAR = 0.0f;
    private void Update()
    {
        // 3.6f to convert in kilometers
        // ** The speed must be clamped by the car controller **
        speed_CAR = target.velocity.magnitude * 3.6f;
        
        if (speedLabel != null)
            speedLabel.text = ((int)speed_CAR) + " km/h";
    }
        
}
