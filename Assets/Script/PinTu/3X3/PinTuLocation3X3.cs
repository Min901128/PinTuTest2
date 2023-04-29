using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PinTuLocation3X3 : MonoBehaviour
{
    private bool a = false;
    private float x1 = -0.03f, y1 = 0.05f, x2 = 0.07f, y2 = 0.05f, x3 = 0.17f, y3 = 0.05f;
    private float x4 = -0.03f, y4 = -0.05f, x5 = 0.07f, y5 = -0.05f, x6 = 0.17f, y6 = -0.05f;
    private float x7 = -0.03f, y7 = -0.15f, x8 = 0.07f, y8 = -0.15f, x9 = 0.17f, y9 = -0.15f;
    private float z = 1.0f;
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
        else{
            X = x9;
            Y = y9;
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
            if(tag == "PinTu1"){
                transform.rotation = Quaternion.Euler(0.0f,0.0f,-270f);
            }
            else if(tag == "PinTu2"){
                transform.rotation = Quaternion.Euler(0.0f,0.0f,180f);
            }
            else if(tag == "PinTu3"){
                transform.rotation = Quaternion.Euler(0.0f,0.0f,0.0f);
            }
            else if(tag == "PinTu4"){
                transform.rotation = Quaternion.Euler(0.0f,0.0f,-90f);
            }
            else if(tag == "PinTu5"){
                transform.rotation = Quaternion.Euler(0.0f,0.0f,0.0f);
            }
            else if(tag == "PinTu6"){
                transform.rotation = Quaternion.Euler(0.0f,0.0f,90f);
            }
            else if(tag == "PinTu7"){
                transform.rotation = Quaternion.Euler(0.0f,0.0f,180f);
            }
            else if(tag == "PinTu8"){
                transform.rotation = Quaternion.Euler(0.0f,0.0f,0.0f);
            }
            else{

            }
            
            

            a = false;
            Debug.Log("完成定位");
        }
    }
}