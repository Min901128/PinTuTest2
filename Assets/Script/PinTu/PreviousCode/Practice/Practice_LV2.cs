using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice_LV2 : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;
    public GameObject capsule;
    public GameObject Practice_Level2_FinishPanel;
    public GameObject Hint;

    private Vector3 CubeOriginalPosition;
    private Vector3 SphereOriginalPosition;
    private Vector3 CapsuleOriginalPosition;
 
    bool obj1 = false, obj2 = false, obj3 = false;  //有沒有移動過

    private void Start()
    {
        CubeOriginalPosition = cube.transform.position;
        SphereOriginalPosition = sphere.transform.position;
        CapsuleOriginalPosition = capsule.transform.position;
    }

    private void Update()
    {
        if(cube.transform.position != CubeOriginalPosition){
           obj1 = true;
        }

        if(sphere.transform.position != SphereOriginalPosition){
           obj2 = true;
        }

        if(capsule.transform.position != CapsuleOriginalPosition){
           obj3 = true;
        }

        if(obj1 && obj2 && obj3){
            Practice_Level2_FinishPanel.SetActive(true);
            Hint.SetActive(false);
        }
    }

    public void ReSet(){
        obj1 = false;
        obj2 = false;
        obj3 = false;

        cube.transform.position = CubeOriginalPosition;
        sphere.transform.position = SphereOriginalPosition;
        capsule.transform.position = CapsuleOriginalPosition;
    }
}
