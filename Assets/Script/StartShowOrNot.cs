using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartShowOrNot : MonoBehaviour
{
    public GameObject StartPanel;

    int count = 0;

    public void ShowOrNot(){
        count++;

        if(count % 2 == 0){ //VideoNotShow
            StartPanel.SetActive(true);
        }
        else{
            StartPanel.SetActive(false);
        }
    }
}
