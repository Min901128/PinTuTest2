using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PinTuLocation5X5 : MonoBehaviour
{
    private bool a = false;
    private float x1 = -0.05f, y1 = 0.06f, x2 = 0.01f, y2 = 0.06f, x3 = 0.07f, y3 = 0.06f, x4 = 0.13f, y4 = 0.06f, x5 = 0.19f, y5 = 0.06f;
    private float x6 = -0.05f, y6 = 0.01f, x7 = 0.01f, y7 = 0.01f, x8 = 0.07f, y8 = 0.01f, x9 = 0.13f, y9 = 0.01f, x10 = 0.19f, y10 = 0.01f;
    private float x11 = -0.05f, y11 = -0.05f, x12 = 0.01f, y12 = -0.05f, x13 = 0.07f, y13 = -0.05f, x14 = 0.13f, y14 = -0.05f, x15 = 0.19f, y15 = -0.05f;
    private float x16 = -0.05f, y16 = -0.11f, x17 = 0.01f, y17 = -0.11f, x18 = 0.07f, y18 = -0.11f, x19 = 0.13f, y19 = -0.11f, x20 = 0.19f, y20 = -0.11f;
    private float x21 = -0.05f, y21 = -0.17f, x22 = 0.01f, y22 = -0.17f, x23 = 0.07f, y23 = -0.17f, x24 = 0.13f, y24 = -0.17f, x25 = 0.19f, y25 = -0.17f;
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
        else if(other.tag == "location16"){
            X = x16;
            Y = y16;
        }
        else if(other.tag == "location17"){
            X = x17;
            Y = y17;
        }
        else if(other.tag == "location18"){
            X = x18;
            Y = y18;
        }
        else if(other.tag == "location19"){
            X = x19;
            Y = y19;
        }
        else if(other.tag == "location20"){
            X = x20;
            Y = y20;
        }
        else if(other.tag == "location21"){
            X = x21;
            Y = y21;
        }
        else if(other.tag == "location22"){
            X = x22;
            Y = y22;
        }else if(other.tag == "location23"){
            X = x23;
            Y = y23;
        }else if(other.tag == "location24"){
            X = x24;
            Y = y24;
        }else if(other.tag == "location25"){
            X = x25;
            Y = y25;
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