using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    //Public floats
    [SerializeField] GameObject _centerOfMass;
    [SerializeField] TextMeshProUGUI _speedText;
    [SerializeField] TextMeshProUGUI _rpmText;
    [SerializeField] float speed;
    [SerializeField] float turnSpeed;
    [SerializeField] float _mph;
    [SerializeField] float _rpm;
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchkey;
    public int inputID;

    [SerializeField] List<WheelCollider> _allWheels;
    [SerializeField] int _wheelsOnGround;

    //private floats
    private float horzontalInput;
    private float verticalIntput;
    private Rigidbody _playerRb;

    private void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
        _playerRb.centerOfMass = _centerOfMass.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        horzontalInput = Input.GetAxis("Horizontal" + inputID);
        verticalIntput = Input.GetAxis("Vertical" + inputID);

        if(IsOnGround())
        {
            _playerRb.AddRelativeForce(Vector3.forward * verticalIntput * speed);
            transform.Rotate(horzontalInput * Time.deltaTime * turnSpeed * Vector3.up);
            _mph = Mathf.Round(_playerRb.velocity.magnitude * 2.237f); // 3.6 for kph
            _speedText.SetText("Speed: " + _mph);
            _rpm = Mathf.Round((_mph % 30) * 40);
            _rpmText.SetText("RPM: " + _rpm);

        }

        if (Input.GetKeyDown(switchkey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }

    bool IsOnGround()
    {
        _wheelsOnGround = 0;
        foreach(WheelCollider _wheel in _allWheels)
        {
            if(_wheel.isGrounded)
            {
                _wheelsOnGround++;
            }
        }
        if(_wheelsOnGround == 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
