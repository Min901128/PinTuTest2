using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PinTuLocation4X4 : MonoBehaviour
{
    private bool a = false;
    private float x1 = -0.04f, y1 = 0.06f, x2 = 0.03f, y2 = 0.06f, x3 = 0.11f, y3 = 0.06f;
    private float x4 = 0.18f, y4 = 0.06f, x5 = -0.04f, y5 = -0.02f, x6 = 0.03f, y6 = -0.02f;
    private float x7 = 0.11f, y7 = -0.02f, x8 = 0.18f, y8 = -0.02f, x9 = -0.04f, y9 = -0.09f;
    private float x10 = 0.03f, y10 = -0.09f, x11 = 0.11f, y11 = -0.09f, x12 = 0.18f, y12 = -0.09f;
    private float x13 = -0.04f, y13 = -0.16f, x14 = 0.03f, y14 = -0.16f, x15 = 0.11f, y15 = -0.16f;
    private float x16 = 0.18f, y16 = -0.16f;
    private float z = 1.07f;
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
        else if(other.tag == "location4"){
            X = x4;
            Y = y4;
        }
        else if(other.tag == "location5"){
            X = x5;
            Y = y5;
        }
        else if(other.tag == "location6"){
            X = x6;
            Y = y6;
        }
        else if(other.tag == "location7"){
            X = x7;
            Y = y7;
        }
        else if(other.tag == "location8"){
            X = x8;
            Y = y8;
        }
        else if(other.tag == "location9"){
            X = x9;
            Y = y9;
        }
        else if(other.tag == "location10"){
            X = x10;
            Y = y10;
        }
        else if(other.tag == "location11"){
            X = x11;
            Y = y11;
        }
        else if(other.tag == "location12"){
            X = x12;
            Y = y12;
        }
        else if(other.tag == "location13"){
            X = x13;
            Y = y13;
        }
        else if(other.tag == "location14"){
            X = x14;
            Y = y14;
        }
        else if(other.tag == "location15"){
            X = x15;
            Y = y15;
        }
        else{
            X = x16;
            Y = y16;
        }

        Z = z;

        a = true;
    }

    private void Start(){
        
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