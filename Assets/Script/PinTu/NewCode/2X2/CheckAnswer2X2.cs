using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckAnswer2X2 : MonoBehaviour
{
    public GameObject P1; //PinTu1
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;
    public GameObject SuccessPanel;
    public GameObject AlmostSuccessPanel;
    public GameObject FailPanel;

    public void check()
    {
        Vector3 Position1 = P1.transform.position;
        Vector3 Position2 = P2.transform.position;
        Vector3 Position3 = P3.transform.position;
        Vector3 Position4 = P4.transform.position;

        int correct = 0;

        if(Position1.x < Position2.x && Position1.y > Position3.y ){
            correct++;
        }
        if(Position2.x > Position1.x && Position2.y > Position4.y){
            correct++;
        }
        if(Position3.x < Position4.x && Position3.y < Position1.y){
            correct++;
        }
        if(Position4.x > Position3.x && Position4.y < Position2.y){
            correct++;
        }

        if(correct == 4){
            //判斷拼圖間的距離有沒有小於0.2
            if((Position2.x - Position1.x) < 0.2 && (Position1.y - Position3.y) < 0.2 && (Position2.y - Position4.y) < 0.2 && (Position4.x - Position3.x) < 0.2){
                Debug.Log("拼圖正確");
                SuccessPanel.SetActive(true);
            }
            else{
                Debug.Log("相對位置對，但距離太遠");
                AlmostSuccessPanel.SetActive(true);
            }
        }
        else{
            Debug.Log("拼圖位置不正確，Correct為:" + correct);
            FailPanel.SetActive(true);
        }
    }
}