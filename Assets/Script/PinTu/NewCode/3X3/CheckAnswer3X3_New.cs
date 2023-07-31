using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckAnswer3X3_New : MonoBehaviour
{
    public GameObject P1; //PinTu1
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;
    public GameObject P5;
    public GameObject P6;
    public GameObject P7;
    public GameObject P8;
    public GameObject P9;
    public GameObject SuccessPanel;
    public GameObject AlmostSuccessPanel;
    public GameObject FailPanel;

    public void check()
    {
        Vector3 Position1 = P1.transform.position;
        Vector3 Position2 = P2.transform.position;
        Vector3 Position3 = P3.transform.position;
        Vector3 Position4 = P4.transform.position;
        Vector3 Position5 = P5.transform.position;
        Vector3 Position6 = P6.transform.position;
        Vector3 Position7 = P7.transform.position;
        Vector3 Position8 = P8.transform.position;
        Vector3 Position9 = P9.transform.position;

        int correct = 0;

        if(Position1.x < Position2.x && Position1.y > Position4.y ){
            correct++;
        }
        if(Position2.x > Position1.x && Position2.x < Position3.x && Position2.y > Position5.y){
            correct++;
        }
        if(Position3.x > Position2.x && Position3.y > Position6.y){
            correct++;
        }
        if(Position4.x < Position5.x && Position4.y < Position1.y && Position4.y > Position7.y){
            correct++;
        }
        if(Position5.x > Position4.x && Position5.x < Position6.x && Position5.y < Position2.y && Position5.y > Position8.y){
            correct++;
        }
        if(Position6.x > Position5.x && Position6.y < Position3.y && Position6.y > Position9.y){
            correct++;
        }
        if(Position7.x < Position8.x && Position7.y < Position4.y ){
            correct++;
        }
        if(Position8.x > Position7.x && Position8.x < Position9.x && Position8.y < Position5.y){
            correct++;
        }
        if(Position9.x > Position8.x && Position9.y < Position6.y){
            correct++;
        }

        if(correct == 9){
            //判斷拼圖間的距離有沒有小於0.2
            if((Position2.x - Position1.x) < 0.2 && (Position3.x - Position2.x) < 0.2 && (Position5.x - Position4.x) < 0.2 && (Position6.x - Position5.x) < 0.2 && (Position8.x - Position7.x) < 0.2 && (Position9.x - Position8.x) < 0.2 && (Position1.y - Position4.y) < 0.2 && (Position4.y - Position7.y) < 0.2 && (Position2.y - Position5.y) < 0.2 && (Position5.y - Position8.y) < 0.2 && (Position3.y - Position6.y) < 0.2 && (Position6.y - Position9.y) < 0.2){
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