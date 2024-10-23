using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatchCheck : MonoBehaviour
{
    public GameObject Match1;
    public GameObject Match2;
    public GameObject Match3;
    public GameObject Match4;
    public GameObject Match5;
    public GameObject Match6;
    public GameObject Match7;
    public GameObject Match8;
    public GameObject Match9;
    public GameObject Match10;

    public GameObject FinishPanel;

    public TimerForMatch timerForMatch;

    public GameObject RetrunButton;
    string FirstTag;
    string SecondTag;
    string YourTag;

    int count = 0;
    int Finish = 0;
    bool State = false;
    
    float Scale_x = 0.05f, Scale_y = 0.2f, Scale_z = 0.2f;
    float ScaleNew_x = 0.05f, ScaleNew_y = 0.3f, ScaleNew_z = 0.3f;

    GameObject Object01;
    GameObject Object02;

    void  Update(){
        if(Finish == 5){
            FinishPanel.SetActive(true);
            timerForMatch.StopTimer();
            RetrunButton.SetActive(false);
        }
    }

    public void check(GameObject match){
        YourTag = match.tag;

        if(count == 0){
            //紀錄第一個按下的tag
            Object01 = match;
            FirstTag = YourTag;
            match.transform.localScale = new Vector3(ScaleNew_x, ScaleNew_y, ScaleNew_z);
            count++;
        }
        else{
            //記錄第二個按下的tag，並比對兩者是否相同，若相同，Match消失
            Object02 = match;
            SecondTag = YourTag;

            match.transform.localScale = new Vector3(ScaleNew_x, ScaleNew_y, ScaleNew_z);            
            
            if((FirstTag == "1" && SecondTag == "2") || (FirstTag == "2" && SecondTag == "1")){
                State = true;
            }
            else if((FirstTag == "3" && SecondTag == "4") || (FirstTag == "4" && SecondTag == "3")){
                State = true;
            }
            else if((FirstTag == "5" && SecondTag == "6") || (FirstTag == "6" && SecondTag == "5")){
                State = true;
            }
            else if((FirstTag == "7" && SecondTag == "8") || (FirstTag == "8" && SecondTag == "7")){
                State = true;
            }
            else if((FirstTag == "9" && SecondTag == "10") || (FirstTag == "10" && SecondTag == "9")){
                State = true;
            }
            
            StartCoroutine(DelayOneSecond(Object01, Object02));

            count = 0;
        }
    }

    void ReturnToOriginalScale(){
        Match1.transform.localScale = new Vector3(Scale_x, Scale_y, Scale_z);
        Match2.transform.localScale = new Vector3(Scale_x, Scale_y, Scale_z);
        Match3.transform.localScale = new Vector3(Scale_x, Scale_y, Scale_z);
        Match4.transform.localScale = new Vector3(Scale_x, Scale_y, Scale_z);
        Match5.transform.localScale = new Vector3(Scale_x, Scale_y, Scale_z);
        Match6.transform.localScale = new Vector3(Scale_x, Scale_y, Scale_z);
        Match7.transform.localScale = new Vector3(Scale_x, Scale_y, Scale_z);
        Match8.transform.localScale = new Vector3(Scale_x, Scale_y, Scale_z);
        Match9.transform.localScale = new Vector3(Scale_x, Scale_y, Scale_z);
        Match10.transform.localScale = new Vector3(Scale_x, Scale_y, Scale_z);
    }

    IEnumerator DelayOneSecond(GameObject obj1, GameObject obj2)
    {
        // 暫停 1 秒
        yield return new WaitForSeconds(1.0f);
        if(State){
            obj1.SetActive(false);
            obj2.SetActive(false);
            Finish++;
        }
        ReturnToOriginalScale();
        State = false;
    }
}