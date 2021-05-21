using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public float rotationSpeed;
    public float rotationAngle;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed* Time.deltaTime, Space.World);
    }

    
}
