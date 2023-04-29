using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class IsCollider : MonoBehaviour
{
    public Text A;
    private void OnTriggerEnter(Collider other){
        A.text = "與" + other.tag + "發生接觸";
    }
}
