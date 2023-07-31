using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice_LV3_LV4 : MonoBehaviour
{
    public GameObject Practice_Level3_FinishPanel; 
    public GameObject FinishButton;
    public GameObject NextButton;
    public GameObject SuccessImage;
    public GameObject FailImage;
    public GameObject cube;
    private Vector3 CubeOriginalPosition;

    bool IsCollider = false;

    void Start(){
        CubeOriginalPosition = cube.transform.position;
    }

    public void Finish(){
        if(IsCollider == true){
            FinishButton.SetActive(false);
            Practice_Level3_FinishPanel.SetActive(true);
            SuccessImage.SetActive(true);
            FailImage.SetActive(false);
            NextButton.SetActive(true);
        }
        else{
            Practice_Level3_FinishPanel.SetActive(true);
            SuccessImage.SetActive(false);
            FailImage.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other){
        IsCollider = true;
        Debug.Log("IsCollider :" + IsCollider);
    }

    public void ReSet(){
        IsCollider = false;
        cube.transform.position = CubeOriginalPosition;
    }
}
