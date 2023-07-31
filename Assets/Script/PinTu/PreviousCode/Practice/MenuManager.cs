using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class MenuManager : MonoBehaviour
{
    public GameObject PinTuChoose;
    public GameObject Start_Panel;

    private const string IsStartShow = "IsStartShow";

    void Start(){
        bool situation = Convert.ToBoolean(PlayerPrefs.GetInt("IsStartShow"));
        Start_Panel .SetActive(situation);
        PinTuChoose.SetActive(!situation);
        PlayerPrefs.SetInt("IsStartShow", 1);
        PlayerPrefs.Save();
    }
}