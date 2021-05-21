using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBall : MonoBehaviour
{

    public float jumpPower;
    bool isJump;
    public int itemCount;
    Rigidbody rigid;
    public GameManagerLogic manager;


    // Start is called before the first frame update
    void Awake()
    {
       
        isJump = false;
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Jump") && !isJump)
        {
            isJump = true;
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }
    }
   
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        rigid.AddForce(new Vector3(h,0,v), ForceMode.Impulse);
    }

    //물리 충돌 이벤트
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Floor")
        {
            isJump = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {   
            itemCount++;
            other.gameObject.SetActive(false);
        }

        else if(other.tag == "finish")
        {
            other.gameObject.SetActive(false);
            if (manager.TotalItemCount == itemCount)
            {
                //게임 클리어
                SceneManager.LoadScene("1");


            }
            else
            {
                //게임 다시 시작
                SceneManager.LoadScene("1");
            }
        }
    }
}
