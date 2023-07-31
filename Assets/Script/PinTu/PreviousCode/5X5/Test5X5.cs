using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//測試用程式，用來抓物件位置
public class Test5X5 : MonoBehaviour
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
    public  GameObject Pintu10;
    public  GameObject Pintu11;
    public  GameObject Pintu12;
    public  GameObject Pintu13;
    public  GameObject Pintu14;
    public  GameObject Pintu15;
    public  GameObject Pintu16;
    public  GameObject Pintu17;
    public  GameObject Pintu18;
    public  GameObject Pintu19;
    public  GameObject Pintu20;
    public  GameObject Pintu21;
    public  GameObject Pintu22;
    public  GameObject Pintu23;
    public  GameObject Pintu24;
    public  GameObject Pintu25;

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
        Pintu10 = GameObject.Find("pintu10");
        Pintu11 = GameObject.Find("pintu11");
        Pintu12 = GameObject.Find("pintu12");
        Pintu13 = GameObject.Find("pintu13");
        Pintu14 = GameObject.Find("pintu14");
        Pintu15 = GameObject.Find("pintu15");
        Pintu16 = GameObject.Find("pintu16");
        Pintu17 = GameObject.Find("pintu17");
        Pintu18 = GameObject.Find("pintu18");
        Pintu19 = GameObject.Find("pintu19");
        Pintu20 = GameObject.Find("pintu20");
        Pintu21 = GameObject.Find("pintu21");
        Pintu22 = GameObject.Find("pintu22");
        Pintu23 = GameObject.Find("pintu23");
        Pintu24 = GameObject.Find("pintu24");
        Pintu25 = GameObject.Find("pintu25");
        
        Vector3 position1 = Pintu1.transform.position;
        Vector3 position2 = Pintu2.transform.position; 
        Vector3 position3 = Pintu3.transform.position;
        Vector3 position4 = Pintu4.transform.position;
        Vector3 position5 = Pintu5.transform.position;
        Vector3 position6 = Pintu6.transform.position;
        Vector3 position7 = Pintu7.transform.position;
        Vector3 position8 = Pintu8.transform.position;
        Vector3 position9 = Pintu9.transform.position;
        Vector3 position10 = Pintu10.transform.position;
        Vector3 position11 = Pintu11.transform.position;
        Vector3 position12 = Pintu12.transform.position;
        Vector3 position13 = Pintu13.transform.position;
        Vector3 position14 = Pintu14.transform.position;
        Vector3 position15 = Pintu15.transform.position;
        Vector3 position16 = Pintu16.transform.position;
        Vector3 position17 = Pintu17.transform.position;
        Vector3 position18 = Pintu18.transform.position;
        Vector3 position19 = Pintu19.transform.position;
        Vector3 position20 = Pintu20.transform.position;
        Vector3 position21 = Pintu21.transform.position;
        Vector3 position22 = Pintu22.transform.position;
        Vector3 position23 = Pintu23.transform.position;
        Vector3 position24 = Pintu24.transform.position;
        Vector3 position25 = Pintu25.transform.position;

        // 格式化座標為小數點後兩位的字符串
        string formattedPosition1 = string.Format("({0:F2}, {1:F2}, {2:F2})", position1.x, position1.y, position1.z);
        string formattedPosition2 = string.Format("({0:F2}, {1:F2}, {2:F2})", position2.x, position2.y, position2.z);
        string formattedPosition3 = string.Format("({0:F2}, {1:F2}, {2:F2})", position3.x, position3.y, position3.z);
        string formattedPosition4 = string.Format("({0:F2}, {1:F2}, {2:F2})", position4.x, position4.y, position4.z);
        string formattedPosition5 = string.Format("({0:F2}, {1:F2}, {2:F2})", position5.x, position5.y, position5.z);
        string formattedPosition6 = string.Format("({0:F2}, {1:F2}, {2:F2})", position6.x, position6.y, position6.z);
        string formattedPosition7 = string.Format("({0:F2}, {1:F2}, {2:F2})", position7.x, position7.y, position7.z);
        string formattedPosition8 = string.Format("({0:F2}, {1:F2}, {2:F2})", position8.x, position8.y, position8.z);
        string formattedPosition9 = string.Format("({0:F2}, {1:F2}, {2:F2})", position9.x, position9.y, position9.z);
        string formattedPosition10 = string.Format("({0:F2}, {1:F2}, {2:F2})", position10.x, position10.y, position10.z);
        string formattedPosition11 = string.Format("({0:F2}, {1:F2}, {2:F2})", position11.x, position11.y, position11.z);
        string formattedPosition12 = string.Format("({0:F2}, {1:F2}, {2:F2})", position12.x, position12.y, position12.z);
        string formattedPosition13 = string.Format("({0:F2}, {1:F2}, {2:F2})", position13.x, position13.y, position13.z);
        string formattedPosition14 = string.Format("({0:F2}, {1:F2}, {2:F2})", position14.x, position14.y, position14.z);
        string formattedPosition15 = string.Format("({0:F2}, {1:F2}, {2:F2})", position15.x, position15.y, position15.z);
        string formattedPosition16 = string.Format("({0:F2}, {1:F2}, {2:F2})", position16.x, position16.y, position16.z);
        string formattedPosition17 = string.Format("({0:F2}, {1:F2}, {2:F2})", position17.x, position17.y, position17.z);
        string formattedPosition18 = string.Format("({0:F2}, {1:F2}, {2:F2})", position18.x, position18.y, position18.z);
        string formattedPosition19 = string.Format("({0:F2}, {1:F2}, {2:F2})", position19.x, position19.y, position19.z);
        string formattedPosition20 = string.Format("({0:F2}, {1:F2}, {2:F2})", position20.x, position20.y, position20.z);
        string formattedPosition21 = string.Format("({0:F2}, {1:F2}, {2:F2})", position21.x, position21.y, position21.z);
        string formattedPosition22 = string.Format("({0:F2}, {1:F2}, {2:F2})", position22.x, position22.y, position22.z);
        string formattedPosition23 = string.Format("({0:F2}, {1:F2}, {2:F2})", position23.x, position23.y, position23.z);
        string formattedPosition24 = string.Format("({0:F2}, {1:F2}, {2:F2})", position24.x, position24.y, position24.z);
        string formattedPosition25 = string.Format("({0:F2}, {1:F2}, {2:F2})", position25.x, position25.y, position25.z);

        /*Debug.Log("拼圖1位置: " + position1.x + ", " + position1.y);
        Debug.Log("拼圖2位置: " + position2.x + ", " + position2.y);
        Debug.Log("拼圖3位置: " + position3.x + ", " + position3.y);
        Debug.Log("拼圖4位置: " + position4.x + ", " + position4.y);*/
        
        Debug.Log("拼圖1位置: " + formattedPosition1);
        Debug.Log("拼圖2位置: " + formattedPosition2);
        Debug.Log("拼圖3位置: " + formattedPosition3);
        Debug.Log("拼圖4位置: " + formattedPosition4);
        Debug.Log("拼圖5位置: " + formattedPosition5);
        Debug.Log("拼圖6位置: " + formattedPosition6);
        Debug.Log("拼圖7位置: " + formattedPosition7);
        Debug.Log("拼圖8位置: " + formattedPosition8);
        Debug.Log("拼圖9位置: " + formattedPosition9);
        Debug.Log("拼圖10位置: " + formattedPosition10);
        Debug.Log("拼圖11位置: " + formattedPosition11);
        Debug.Log("拼圖12位置: " + formattedPosition12);
        Debug.Log("拼圖13位置: " + formattedPosition13);
        Debug.Log("拼圖14位置: " + formattedPosition14);
        Debug.Log("拼圖15位置: " + formattedPosition15);
        Debug.Log("拼圖16位置: " + formattedPosition16);
        Debug.Log("拼圖17位置: " + formattedPosition17);
        Debug.Log("拼圖18位置: " + formattedPosition18);
        Debug.Log("拼圖19位置: " + formattedPosition19);
        Debug.Log("拼圖20位置: " + formattedPosition20);
        Debug.Log("拼圖21位置: " + formattedPosition21);
        Debug.Log("拼圖22位置: " + formattedPosition22);
        Debug.Log("拼圖23位置: " + formattedPosition23);
        Debug.Log("拼圖24位置: " + formattedPosition24);
        Debug.Log("拼圖25位置: " + formattedPosition25);
    }
}