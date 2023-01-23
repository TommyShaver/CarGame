using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxFloaT : MonoBehaviour
{
    private const float blockSpeed = 2.0f;
  
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * blockSpeed);
    }
}
