using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2FollowPlayer : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private Vector3 offset2 = new Vector3(0, 2.5f, 1);

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset2;
    }
}
