using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckAnswer : MonoBehaviour
{
    private GameObject PinTu1;
    private GameObject PinTu2;
    private GameObject PinTu3;
    private GameObject PinTu4;
    private GameObject Location1;
    private GameObject Location2;
    private GameObject Location3;
    private GameObject Location4;

    //因為原本為不可見，所以無法用find的方式尋找
    public GameObject SuccessPanel;
    public GameObject FailPanel;

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

        Vector3 position1 = PinTu1.transform.position;
        Vector3 position2 = PinTu2.transform.position;
        Vector3 position3 = PinTu3.transform.position;
        Vector3 position4 = PinTu4.transform.position;
        Vector3 positionL1 = Location1.transform.position;
        Vector3 positionL2 = Location2.transform.position;
        Vector3 positionL3 = Location3.transform.position;
        Vector3 positionL4 = Location4.transform.position;
 
        if(position1.x < position2.x && position1.y > position3.y){
            //Debug.Log("拼圖1正確");
            correct++;
        }
        if(position2.x > position1.x && position2.y > position4.y){
            //Debug.Log("拼圖2正確");
            correct++;
        }
        if(position3.x < position4.x && position3.y < position1.y){
            //Debug.Log("拼圖3正確");
            correct++;
        }
        if(position4.x > position3.x && position4.y < position2.y){
            //Debug.Log("拼圖4正確");
            correct++;
        }


        if(correct == 4){
            Debug.Log("拼圖完全正確，恭喜通關");

            SuccessPanel.SetActive(true);
        }
        else{
            Debug.Log("拼圖不正確，再接再厲");

            FailPanel.SetActive(true);
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