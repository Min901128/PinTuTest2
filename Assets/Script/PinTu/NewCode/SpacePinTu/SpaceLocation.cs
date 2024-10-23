using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpaceLocation : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(gameObject.transform.position.z > 2){  //足夠靠近拼圖板，給予重力
            rb.useGravity = true;   //將拼圖rigidbody的重力打勾
            
            rb.isKinematic = false;    //Kinematic取消勾選

            transform.rotation = Quaternion.Euler(0f, 0f, 0f);  //要將其rotation固定
        }
    }
}
