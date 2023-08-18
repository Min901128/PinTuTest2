using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideGameObject3X3 : MonoBehaviour
{
    public GameObject Object01;

    int count = 0;
    
    void Update(){
        if(count == 9){
            Object01.SetActive(false);
        }

        Debug.Log("count = " + count);
    }

    public void CountPlus(){
        count++;
    }
}
