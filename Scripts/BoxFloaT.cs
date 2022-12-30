using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxFloaT : MonoBehaviour
{
    public float blockSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * blockSpeed);
    }
}
