using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//測試用程式，用來抓物件位置
public class Test3X3 : MonoBehaviour
{

    public  GameObject Pintu1;
    public  GameObject Pintu2;
    public  GameObject Pintu3;
    public  GameObject Pintu4;
    public  GameObject Pintu5;
    public  GameObject Pintu6;
    public  GameObject Pintu7;
    public  GameObject Pintu8;
    public  GameObject Pintu9;

    void Start()
    {
        Pintu1 = GameObject.Find("pintu1");
        Pintu2 = GameObject.Find("pintu2");
        Pintu3 = GameObject.Find("pintu3");
        Pintu4 = GameObject.Find("pintu4");
        Pintu5 = GameObject.Find("pintu5");
        Pintu6 = GameObject.Find("pintu6");
        Pintu7 = GameObject.Find("pintu7");
        Pintu8 = GameObject.Find("pintu8");
        Pintu9 = GameObject.Find("pintu9");
        
        Vector3 position1 = Pintu1.transform.position;
        Vector3 position2 = Pintu2.transform.position; 
        Vector3 position3 = Pintu3.transform.position;
        Vector3 position4 = Pintu4.transform.position;
        Vector3 position5 = Pintu5.transform.position;
        Vector3 position6 = Pintu6.transform.position;
        Vector3 position7 = Pintu7.transform.position;
        Vector3 position8 = Pintu8.transform.position;
        Vector3 position9 = Pintu9.transform.position;

        /*Debug.Log("拼圖1位置: " + position1.x + ", " + position1.y);
        Debug.Log("拼圖2位置: " + position2.x + ", " + position2.y);
        Debug.Log("拼圖3位置: " + position3.x + ", " + position3.y);
        Debug.Log("拼圖4位置: " + position4.x + ", " + position4.y);*/
        
        Debug.Log("拼圖1位置: " + position1);
        Debug.Log("拼圖2位置: " + position2);
        Debug.Log("拼圖3位置: " + position3);
        Debug.Log("拼圖4位置: " + position4);
        Debug.Log("拼圖5位置: " + position5);
        Debug.Log("拼圖6位置: " + position6);
        Debug.Log("拼圖7位置: " + position7);
        Debug.Log("拼圖8位置: " + position8);
        Debug.Log("拼圖9位置: " + position9);
    }
}