using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideGameObject3X3 : MonoBehaviour
{
    public GameObject PinTu1;
    public GameObject PinTu2;
    public GameObject PinTu3;
    public GameObject PinTu4;
    public GameObject PinTu5;
    public GameObject PinTu6;
    public GameObject PinTu7;
    public GameObject PinTu8;
    public GameObject PinTu9;
    public GameObject Object01;

    private Vector3 PinTu1_OriginalPosition;
    private Vector3 PinTu2_OriginalPosition;
    private Vector3 PinTu3_OriginalPosition;
    private Vector3 PinTu4_OriginalPosition;
    private Vector3 PinTu5_OriginalPosition;
    private Vector3 PinTu6_OriginalPosition;
    private Vector3 PinTu7_OriginalPosition;
    private Vector3 PinTu8_OriginalPosition;
    private Vector3 PinTu9_OriginalPosition;
    
    float timer_f = 0f;
    string s; 
    bool IsChange = false;
    int count = 0;
    
    void Start()
    {
        PinTu1_OriginalPosition = PinTu1.transform.position;
        PinTu2_OriginalPosition = PinTu2.transform.position;
        PinTu3_OriginalPosition = PinTu3.transform.position;
        PinTu4_OriginalPosition = PinTu4.transform.position;
        PinTu5_OriginalPosition = PinTu5.transform.position;
        PinTu6_OriginalPosition = PinTu6.transform.position;
        PinTu7_OriginalPosition = PinTu7.transform.position;
        PinTu8_OriginalPosition = PinTu8.transform.position;
        PinTu9_OriginalPosition = PinTu9.transform.position;
    }

    void Update(){
        timer_f += Time.deltaTime;
        s = timer_f.ToString("F1");

        if(s == "0.4"){
            ReLocation();
        }

        if(count == 9){
            Object01.SetActive(false);
        }
        else{
            if(PinTu1.transform.position != PinTu1_OriginalPosition){
                Debug.Log("1變了");
                IsChange = true;
            }
            if(PinTu2.transform.position != PinTu2_OriginalPosition){
                Debug.Log("2變了");
                IsChange = true;
            }
            if(PinTu3.transform.position != PinTu3_OriginalPosition){
                Debug.Log("3變了");
                IsChange = true;
            }
            if(PinTu4.transform.position != PinTu4_OriginalPosition){
                Debug.Log("4變了");
                IsChange = true;
            }
            if(PinTu5.transform.position != PinTu5_OriginalPosition){
                Debug.Log("5變了");
                IsChange = true;
            }
            if(PinTu6.transform.position != PinTu6_OriginalPosition){
                Debug.Log("6變了");
                IsChange = true;
            }
            if(PinTu7.transform.position != PinTu7_OriginalPosition){
                Debug.Log("7變了");
                IsChange = true;
            }
            if(PinTu8.transform.position != PinTu8_OriginalPosition){
                Debug.Log("8變了");
                IsChange = true;
            }
            if(PinTu9.transform.position != PinTu9_OriginalPosition){
                Debug.Log("9變了");
                IsChange = true;
            }
        }

        Debug.Log("count = " + count);

        if(IsChange){
            Object01.SetActive(true);

            Debug.Log("object出現");
        }

        if(Input.GetMouseButtonUp(0)){
            ReLocation();

            Debug.Log("object消失");
        }

        IsPinTuOut();
    }

    public void CountPlus(){
        count++;
    }

    void ReLocation(){  //更新拼圖的位置，並把Object01關掉
        PinTu1_OriginalPosition = PinTu1.transform.position;
        PinTu2_OriginalPosition = PinTu2.transform.position;
        PinTu3_OriginalPosition = PinTu3.transform.position;
        PinTu4_OriginalPosition = PinTu4.transform.position;
        PinTu5_OriginalPosition = PinTu5.transform.position;
        PinTu6_OriginalPosition = PinTu6.transform.position;
        PinTu7_OriginalPosition = PinTu7.transform.position;
        PinTu8_OriginalPosition = PinTu8.transform.position;
        PinTu9_OriginalPosition = PinTu9.transform.position;
        IsChange = false;
        Object01.SetActive(false);
    }

    void IsPinTuOut(){  //只要有拼圖掉出拼圖板，就把Objecte01關掉
        if((int)PinTu1.transform.position.z > 8 || (int)PinTu2.transform.position.z > 8 || (int)PinTu3.transform.position.z > 8 || (int)PinTu4.transform.position.z > 8
        || (int)PinTu5.transform.position.z > 8 || (int)PinTu6.transform.position.z > 8 || (int)PinTu7.transform.position.z > 8 || (int)PinTu8.transform.position.z > 8 || (int)PinTu9.transform.position.z > 8){
            count = 4;
            IsChange = false;
        }
    }

    void IsPinTuMove(){
        if(PinTu1.transform.position == PinTu1_OriginalPosition && PinTu2.transform.position == PinTu2_OriginalPosition && PinTu3.transform.position == PinTu3_OriginalPosition && PinTu4.transform.position == PinTu4_OriginalPosition
        && PinTu5.transform.position == PinTu5_OriginalPosition && PinTu6.transform.position == PinTu6_OriginalPosition && PinTu7.transform.position == PinTu7_OriginalPosition && PinTu8.transform.position == PinTu8_OriginalPosition && PinTu9.transform.position == PinTu9_OriginalPosition){
            Object01.SetActive(false);
        }
    }
}
