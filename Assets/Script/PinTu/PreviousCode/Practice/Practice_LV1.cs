using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Practice_LV1 : MonoBehaviour
{
    public Text Hint;
    public GameObject Hint_GameObj;
    public GameObject Practice_Level1_FinishPanel;

    int count = 1;

    public void JudgeIsPress(GameObject Button){
        Hint_GameObj.SetActive(false);
        if(Button.tag == count.ToString()){
            count++;
            Button.SetActive(false);
        }
        else{
            Hint_GameObj.SetActive(true);
            Hint.text = "請按照順序點擊!!";
        }
    }

    void Update(){
        if(count == 6){
            Practice_Level1_FinishPanel.SetActive(true);
        }
    }

    public void ReSet(){
        count = 1;
    }
}
