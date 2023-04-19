using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//測試用程式，用來抓物件位置
public class test : MonoBehaviour
{

    public  GameObject Pintu1;
    public  GameObject Pintu2;
    public  GameObject Pintu3;
    public  GameObject Pintu4;


    // Start is called before the first frame update
    void Start()
    {
        Pintu1 = GameObject.Find("pintu1");
        Pintu2 = GameObject.Find("pintu2");
        Pintu3 = GameObject.Find("pintu3");
        Pintu4 = GameObject.Find("pintu4");
        
        Vector3 position1 = Pintu1.transform.position;
        Vector3 position2 = Pintu2.transform.position; 
        Vector3 position3 = Pintu3.transform.position;
        Vector3 position4 = Pintu4.transform.position;

        /*Debug.Log("拼圖1位置: " + position1.x + ", " + position1.y);
        Debug.Log("拼圖2位置: " + position2.x + ", " + position2.y);
        Debug.Log("拼圖3位置: " + position3.x + ", " + position3.y);
        Debug.Log("拼圖4位置: " + position4.x + ", " + position4.y);*/
        
        Debug.Log("拼圖1位置: " + position1);
        Debug.Log("拼圖2位置: " + position2);
        Debug.Log("拼圖3位置: " + position3);
        Debug.Log("拼圖4位置: " + position4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
