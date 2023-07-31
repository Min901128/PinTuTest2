using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoRotation2X2 : MonoBehaviour
{
    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;


    // 在Update()中，將P1物件的旋轉值設為Vector3.zero，這樣P1物件就不會有任何旋轉
    void Update()
    {
        P1.transform.rotation = Quaternion.identity;
        P2.transform.rotation = Quaternion.identity;
        P3.transform.rotation = Quaternion.identity;
        P4.transform.rotation = Quaternion.identity;
    }
}
