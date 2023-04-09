using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PinTuLocation : MonoBehaviour
{
    private bool a = false;
    private float x1 = -0.05f, y1 = 0.08f, x2 = 0.18f, y2 = 0.08f, x3 = -0.05f, y3 = -0.15f, x4 = 0.18f, y4 = -0.15f, z = 1.0f;
    private float X, Y, Z;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("與" + other.tag + "發生接觸");
        
        if(other.tag == "location1"){
            X = x1;
            Y = y1;
        }
        else if(other.tag == "location2"){
            X = x2;
            Y = y2;
        }
        else if(other.tag == "location3"){
            X = x3;
            Y = y3;
        }
        else{
            X = x4;
            Y = y4;
        }

        Z = z;

        a = true;
        
    }

    private void Update(){
        if(Input.GetMouseButtonUp(0) && a == true){
            Vector3 position1 = new Vector3(X, Y, Z);
            transform.position = position1;
            transform.rotation = Quaternion.Euler(0.0f,0.0f,0.0f);

            a = false;
            Debug.Log("完成定位");
        }
    }
}