using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class test0503 : MonoBehaviour
{
    public GameObject Sphere;

    private bool IsTouch = false;

    Vector3 position = new Vector3(0, 0, 0);
    private void OnTriggerEnter(Collider other){
        //Sphere.SetActive(false);
        IsTouch = true;
    }

    void Update(){
        if(IsTouch && Input.GetMouseButtonUp(0)){
            transform.position = position;
        }
    }
}
