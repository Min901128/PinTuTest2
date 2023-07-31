using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckAnswer4X4 : MonoBehaviour
{
    private GameObject PinTu1;
    private GameObject PinTu2;
    private GameObject PinTu3;
    private GameObject PinTu4;
    private GameObject PinTu5;
    private GameObject PinTu6;
    private GameObject PinTu7;
    private GameObject PinTu8;
    private GameObject PinTu9;
    private GameObject PinTu10;
    private GameObject PinTu11;
    private GameObject PinTu12;
    private GameObject PinTu13;
    private GameObject PinTu14;
    private GameObject PinTu15;
    private GameObject PinTu16;
    private GameObject Location1;
    private GameObject Location2;
    private GameObject Location3;
    private GameObject Location4;
    private GameObject Location5;
    private GameObject Location6;
    private GameObject Location7;
    private GameObject Location8;
    private GameObject Location9;
    private GameObject Location10;
    private GameObject Location11;
    private GameObject Location12;
    private GameObject Location13;
    private GameObject Location14;
    private GameObject Location15;
    private GameObject Location16;


    //因為原本為不可見，所以無法用find的方式尋找
    public GameObject SuccessPanel;
    public GameObject FailPanel;

    private int correct = 0;

    public void Check(){
        PinTu1 = GameObject.Find("pintu1");
        PinTu2 = GameObject.Find("pintu2");
        PinTu3 = GameObject.Find("pintu3");
        PinTu4 = GameObject.Find("pintu4");
        PinTu5 = GameObject.Find("pintu5");
        PinTu6 = GameObject.Find("pintu6");
        PinTu7 = GameObject.Find("pintu7");
        PinTu8 = GameObject.Find("pintu8");
        PinTu9 = GameObject.Find("pintu9");
        PinTu10 = GameObject.Find("pintu10");
        PinTu11 = GameObject.Find("pintu11");
        PinTu12 = GameObject.Find("pintu12");
        PinTu13 = GameObject.Find("pintu13");
        PinTu14 = GameObject.Find("pintu14");
        PinTu15 = GameObject.Find("pintu15");
        PinTu16 = GameObject.Find("pintu16");

        Location1 = GameObject.Find("GameObject_Location1");
        Location2 = GameObject.Find("GameObject_Location2");
        Location3 = GameObject.Find("GameObject_Location3");
        Location4 = GameObject.Find("GameObject_Location4");
        Location5 = GameObject.Find("GameObject_Location5");
        Location6 = GameObject.Find("GameObject_Location6");
        Location7 = GameObject.Find("GameObject_Location7");
        Location8 = GameObject.Find("GameObject_Location8");
        Location9 = GameObject.Find("GameObject_Location9");
        Location10 = GameObject.Find("GameObject_Location10");
        Location11 = GameObject.Find("GameObject_Location11");
        Location12 = GameObject.Find("GameObject_Location12");
        Location13 = GameObject.Find("GameObject_Location13");
        Location14 = GameObject.Find("GameObject_Location14");
        Location15 = GameObject.Find("GameObject_Location15");
        Location16 = GameObject.Find("GameObject_Location16");

        Vector3 position1 = PinTu1.transform.position;
        Vector3 position2 = PinTu2.transform.position;
        Vector3 position3 = PinTu3.transform.position;
        Vector3 position4 = PinTu4.transform.position;
        Vector3 position5 = PinTu5.transform.position;
        Vector3 position6 = PinTu6.transform.position;
        Vector3 position7 = PinTu7.transform.position;
        Vector3 position8 = PinTu8.transform.position;
        Vector3 position9 = PinTu9.transform.position;
        Vector3 position10 = PinTu10.transform.position;
        Vector3 position11 = PinTu11.transform.position;
        Vector3 position12 = PinTu12.transform.position;
        Vector3 position13 = PinTu13.transform.position;
        Vector3 position14 = PinTu14.transform.position;
        Vector3 position15 = PinTu15.transform.position;
        Vector3 position16 = PinTu16.transform.position;

        if(position1.x < position2.x && position1.y > position5.y){
            //Debug.Log("拼圖1正確");
            correct++;
        }
        if(position2.x > position1.x && position2.x < position3.x && position2.y > position6.y){
            //Debug.Log("拼圖2正確");
            correct++;
        }
        if(position3.x > position2.x && position3.x < position4.x && position3.y > position7.y){
            //Debug.Log("拼圖3正確");
            correct++;
        }
        if(position4.x > position3.x && position4.y > position8.y){
            //Debug.Log("拼圖4正確");
            correct++;
        }
        if(position5.x < position6.x && position5.y > position9.y && position5.y < position1.y){
            //Debug.Log("拼圖5正確");
            correct++;
        }
        if(position6.x > position5.x && position6.x < position7.x && position6.y > position10.y && position6.y < position2.y){
            //Debug.Log("拼圖6正確");
            correct++;
        }
        if(position7.x > position6.x && position7.x < position8.x && position7.y > position11.y && position7.y < position3.y){
            //Debug.Log("拼圖7正確");
            correct++;
        }
        if(position8.x > position7.x && position8.y > position12.y && position8.y < position4.y){
            //Debug.Log("拼圖8正確");
            correct++;
        }
        if(position9.x < position10.x && position9.y < position5.y && position9.y > position13.y){
            //Debug.Log("拼圖9正確");
            correct++;
        }
        if(position10.x > position9.x && position10.x < position11.x && position10.y > position14.y && position10.y < position6.y){
            //Debug.Log("拼圖10正確");
            correct++;
        }
        if(position11.x > position10.x && position11.x < position12.x && position11.y > position15.y && position11.y < position7.y){
            //Debug.Log("拼圖11正確");
            correct++;
        }
        if(position12.x > position11.x && position12.y < position8.y && position12.y > position16.y){
            //Debug.Log("拼圖12正確");
            correct++;
        }
        if(position13.x < position14.x && position13.y < position9.y){
            //Debug.Log("拼圖13正確");
            correct++;
        }
        if(position14.x > position13.x && position14.x < position15.x && position14.y < position10.y){
            //Debug.Log("拼圖14正確");
            correct++;
        }
        if(position15.x > position14.x && position15.x < position16.x && position15.y < position11.y){
            //Debug.Log("拼圖15正確");
            correct++;
        }
        if(position16.x > position15.x && position16.y < position12.y){
            //Debug.Log("拼圖16正確");
            correct++;
        }
        
        

        if(correct == 16){
            Debug.Log("拼圖完全正確，恭喜通關");
            SuccessPanel.SetActive(true);
        }
        else{
            Debug.Log("拼圖不正確，再接再厲");
            FailPanel.SetActive(true);
        }
    }
}