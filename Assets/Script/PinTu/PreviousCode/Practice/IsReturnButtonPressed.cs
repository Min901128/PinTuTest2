using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class IsReturnButtonPressed : MonoBehaviour
{
    public GameObject StartPanel;
    public GameObject VideoButton;
    public GameObject PinTUChoosePanel;
    private const string IsPressed = "IsPressed";
    void Start()
    {
        bool situation = Convert.ToBoolean(PlayerPrefs.GetInt("IsPressed"));
        Debug.Log("IsPressed is " + situation);

        if(situation){
            //當上一頁按下後會做的事
            StartPanel.SetActive(false);
            VideoButton.SetActive(false);
            PinTUChoosePanel.SetActive(true);

            PlayerPrefs.SetInt("IsPressed", 0);
            PlayerPrefs.Save();
        }
    }

    public void ButtonBeenPressed(){
        PlayerPrefs.SetInt("IsPressed", 1);
        PlayerPrefs.Save();
    }
}
