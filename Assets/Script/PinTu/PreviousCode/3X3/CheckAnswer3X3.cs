using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckAnswer3X3 : MonoBehaviour
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
    private GameObject Location1;
    private GameObject Location2;
    private GameObject Location3;
    private GameObject Location4;
    private GameObject Location5;
    private GameObject Location6;
    private GameObject Location7;
    private GameObject Location8;
    private GameObject Location9;


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

        Location1 = GameObject.Find("GameObject_Location1");
        Location2 = GameObject.Find("GameObject_Location2");
        Location3 = GameObject.Find("GameObject_Location3");
        Location4 = GameObject.Find("GameObject_Location4");
        Location5 = GameObject.Find("GameObject_Location5");
        Location6 = GameObject.Find("GameObject_Location6");
        Location7 = GameObject.Find("GameObject_Location7");
        Location8 = GameObject.Find("GameObject_Location8");
        Location9 = GameObject.Find("GameObject_Location9");

        Vector3 position1 = PinTu1.transform.position;
        Vector3 position2 = PinTu2.transform.position;
        Vector3 position3 = PinTu3.transform.position;
        Vector3 position4 = PinTu4.transform.position;
        Vector3 position5 = PinTu5.transform.position;
        Vector3 position6 = PinTu6.transform.position;
        Vector3 position7 = PinTu7.transform.position;
        Vector3 position8 = PinTu8.transform.position;
        Vector3 position9 = PinTu9.transform.position;

        //這是幹嘛的?!好像用不到?
        /*Vector3 positionL1 = Location1.transform.position;
        Vector3 positionL2 = Location2.transform.position;
        Vector3 positionL3 = Location3.transform.position;
        Vector3 positionL4 = Location4.transform.position;
        Vector3 positionL5 = Location5.transform.position;
        Vector3 positionL6 = Location6.transform.position;
        Vector3 positionL7 = Location7.transform.position;
        Vector3 positionL8 = Location8.transform.position;
        Vector3 positionL9 = Location9.transform.position;*/

        if(position1.x < position2.x && position1.y > position4.y){
            //Debug.Log("拼圖1正確");
            correct++;
        }
        if(position2.x > position1.x && position2.x < position3.x && position2.y > position5.y){
            //Debug.Log("拼圖2正確");
            correct++;
        }
        if(position3.x > position2.x && position3.y > position6.y){
            //Debug.Log("拼圖3正確");
            correct++;
        }
        if(position4.x < position5.x && position4.y < position1.y && position4.y > position7.y){
            //Debug.Log("拼圖4正確");
            correct++;
        }
        if(position5.x > position4.x && position5.x < position6.x && position5.y > position8.y && position5.y < position2.y){
            //Debug.Log("拼圖5正確");
            correct++;
        }
        if(position6.x > position5.x && position6.y > position9.y && position6.y < position3.y){
            //Debug.Log("拼圖6正確");
            correct++;
        }
        if(position7.x < position8.x && position7.y < position4.y){
            //Debug.Log("拼圖7正確");
            correct++;
        }
        if(position8.x < position9.x && position8.x > position7.x && position8.y < position5.y){
            //Debug.Log("拼圖8正確");
            correct++;
        }
        if(position9.x > position8.x && position9.y < position6.y){
            //Debug.Log("拼圖9正確");
            correct++;
        }
        
        

        if(correct == 9){
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