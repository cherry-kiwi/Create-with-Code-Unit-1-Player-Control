using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    void Start()
    {
        
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset; //카메라의 위치를 플레이어의 위치에 할당
    }
}
