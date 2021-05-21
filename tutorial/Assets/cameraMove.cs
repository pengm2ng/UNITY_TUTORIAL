using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    Transform playerTransform;
    Vector3 offset;
    
    // Start is called before the first frame update
    void Awake()
    {
        playerTransform = GameObject.Find("PlayerBall").transform;
        offset = transform.position - playerTransform.position;
    }

    //ī�޶� �̵����� lateUpdate �̿�
    void LateUpdate()
    {
        transform.position = playerTransform.position+offset;        
    }
}
