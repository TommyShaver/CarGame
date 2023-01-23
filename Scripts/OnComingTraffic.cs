using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnComingTraffic : MonoBehaviour
{
    [SerializeField] float busSpeed;
 
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * busSpeed);
    }
}
