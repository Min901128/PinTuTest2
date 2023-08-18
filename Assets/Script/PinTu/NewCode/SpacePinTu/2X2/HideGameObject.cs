using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideGameObject : MonoBehaviour
{
    public GameObject Object01;

    int count = 0;

    void Update(){
        if(count == 4){
            Object01.SetActive(false);
        }

        Debug.Log("count = " + count);
    }

    public void CountPlus(){
        count++;
    }
}
