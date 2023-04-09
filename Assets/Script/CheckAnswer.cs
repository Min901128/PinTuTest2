using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckAnswer : MonoBehaviour
{
    public GameObject PinTu1;
    public GameObject PinTu2;
    public GameObject PinTu3;
    public GameObject PinTu4;
    public GameObject Location1;
    public GameObject Location2;
    public GameObject Location3;
    public GameObject Location4;

    //public GameObject SuccessPanel;

    private int correct = 0;

    public void FindPosition(){
        PinTu1 = GameObject.Find("pintu1");
        PinTu2 = GameObject.Find("pintu2");
        PinTu3 = GameObject.Find("pintu3");
        PinTu4 = GameObject.Find("pintu4");
        Location1 = GameObject.Find("GameObject_Location1");
        Location2 = GameObject.Find("GameObject_Location2");
        Location3 = GameObject.Find("GameObject_Location3");
        Location4 = GameObject.Find("GameObject_Location4");

    //    SuccessPanel = GameObject.Find("Panel_success");

        Vector3 position1 = PinTu1.transform.position;
        Vector3 position2 = PinTu2.transform.position;
        Vector3 position3 = PinTu3.transform.position;
        Vector3 position4 = PinTu4.transform.position;
        Vector3 positionL1 = Location1.transform.position;
        Vector3 positionL2 = Location2.transform.position;
        Vector3 positionL3 = Location3.transform.position;
        Vector3 positionL4 = Location4.transform.position;

        if(position1.x < 0 && position1.y > 0){
            //Debug.Log("拼圖1正確");
            correct++;
        }
        if(position2.x > 0 && position2.y > 0){
            //Debug.Log("拼圖2正確");
            correct++;
        }
        if(position3.x < 0 && position3.y < 0){
            //Debug.Log("拼圖3正確");
            correct++;
        }
        if(position4.x > 0 && position4.y < 0){
            //Debug.Log("拼圖4正確");
            correct++;
        }


        if(correct == 4){
            Debug.Log("拼圖完全正確，恭喜通關");

            //SuccessPanel.SetActive(true);
        }
        else{
            Debug.Log("拼圖不正確，再接再厲");
        }
        
        /*Debug.Log("pintu1 position: " + position1);
        Debug.Log("pintu2 position: " + position2);
        Debug.Log("pintu3 position: " + position3);
        Debug.Log("pintu4 position: " + position4);
        Debug.Log("Location1 position: " + positionL1);
        Debug.Log("Location2 position: " + positionL2);
        Debug.Log("Location3 position: " + positionL3);
        Debug.Log("Location4 position: " + positionL4);*/
    }
}