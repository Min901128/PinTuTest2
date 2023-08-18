using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceMove : MonoBehaviour
{
    public GameObject PinTu1;
    public GameObject PinTu2;
    public GameObject PinTu3;
    public GameObject PinTu4;

    private Vector3[] Position;

    int PinTuNumber = 0;
    bool IsPress = false;

    void Start(){
        Position = new Vector3[4];
        Position[0] = PinTu1.transform.position;
        Position[1] = PinTu2.transform.position;
        Position[2] = PinTu3.transform.position;
        Position[3] = PinTu4.transform.position;
    }

    void Update(){
        if(Input.GetMouseButtonDown(0)){
            IsPress = true;
        }
        if(Input.GetMouseButtonUp(0)){
            IsPress = false;
            PinTuNumber = 0;
        }

        if(IsPress){
            switch (PinTuNumber)
            {
                case 1:
                    //第一塊拼圖改座標
                    Position[0] = PinTu1.transform.position;
                    break;
                case 2:
                    //第二塊拼圖改座標
                    Position[1] = PinTu2.transform.position;
                    break;
                case 3:
                    //第三塊拼圖改座標
                    Position[2] = PinTu3.transform.position;
                    break;
                case 4:
                    //第四塊拼圖改座標
                    Position[3] = PinTu4.transform.position;
                    break;
                default:
                    //都不動
                    break;
            }
        }

        PinTu1.transform.position = Position[0];
        PinTu2.transform.position = Position[1];
        PinTu3.transform.position = Position[2];
        PinTu4.transform.position = Position[3];

        Debug.Log("PinTuNumber = " + PinTuNumber);
    }

   public void ChangePinTuNumber(int pintunumber){
        PinTuNumber = pintunumber;
   }
}



//分開寫好了(將code掛在每片拼圖上)，不然只要滑鼠按著，大家的座標都會動


//設一個變數儲存現在哪個拼圖塊要動，把程式放在PinTuManager上，每塊拼圖上的ONclick可以更改變數
