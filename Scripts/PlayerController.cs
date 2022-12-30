using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Public floats
    public float speed = 5.0f;
    public float turnSpeed;
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchkey;
    public int inputID;

    //private floats
    private float horzontalInput;
    private float verticalIntput;
    
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        //Player contorl input
        horzontalInput = Input.GetAxis("Horizontal" + inputID);
        verticalIntput = Input.GetAxis("Vertical" + inputID);
       
        // Need the thing to move
        //transform.Translate(0, 0, 1); (a way to change things in world.)

        transform.Translate(speed * Time.deltaTime * verticalIntput * Vector3.forward);
        transform.Rotate(horzontalInput * Time.deltaTime * turnSpeed * Vector3.up);

        if(Input.GetKeyDown(switchkey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
        
        
    }
}
