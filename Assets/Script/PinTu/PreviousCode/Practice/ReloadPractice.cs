using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadPractice : MonoBehaviour
{
    public GameObject obj;
    private const string IsStartShow = "IsStartShow";

    private void Start()
    {
        // 在加载新场景时保持 obj 的状态
        DontDestroyOnLoad(obj);
    }

    public void ReloadScene()
    {
        /*PlayerPrefs.SetInt("IsStartShow", 0);
        PlayerPrefs.Save();*/
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("Hi");
    }

    private void Update()
    {
        // 检查场景是否重新加载，然后根据需要隐藏 obj
        if (SceneManager.GetActiveScene().name == "Menu")
        {
            obj.SetActive(false);
        }
        else
        {
            obj.SetActive(true);
        }
    }
}