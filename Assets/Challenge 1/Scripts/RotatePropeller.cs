using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropeller : MonoBehaviour
{
    public GameObject propeller;

    void Update()
    {
        transform.Rotate(0, 0, 10);
    }
}