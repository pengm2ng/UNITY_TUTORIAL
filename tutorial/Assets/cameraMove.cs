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

    //카메라 이동에는 lateUpdate 이용
    void LateUpdate()
    {
        transform.position = playerTransform.position+offset;        
    }
}
