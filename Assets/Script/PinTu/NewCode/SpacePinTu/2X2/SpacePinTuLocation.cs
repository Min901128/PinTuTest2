using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpacePinTuLocation : MonoBehaviour
{
    public HideGameObject hideGameObject;

    bool IsEnter = false;
    bool IsCount = false;
    private Rigidbody rb;

    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(IsEnter){
            
            rb.useGravity = true;   //將拼圖rigidbody的重力打勾
            
            rb.isKinematic = false;    //Kinematic取消勾選

            transform.rotation = Quaternion.Euler(0f, 0f, 0f);  //要將其rotation固定
        
        }

        if(rb.useGravity == true  && !IsCount){
            hideGameObject.CountPlus();
            IsCount = true;
        }
    }

    void OnTriggerEnter(Collider other){
        IsEnter = true;
    }
}
