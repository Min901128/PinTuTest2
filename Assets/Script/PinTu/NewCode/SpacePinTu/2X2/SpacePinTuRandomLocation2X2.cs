using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpacePinTuRandomLocation2X2 : MonoBehaviour
{
    public GameObject PinTu1;
    public GameObject PinTu2;
    public GameObject PinTu3;
    public GameObject PinTu4;

    private Vector3[] originalPositions;

    private Quaternion[] rotationAngles;

    private List<Vector3> PinTuPositions;

    void Start()
    {
        // 紀錄初始位置
        originalPositions = new Vector3[4];
        originalPositions[0] = PinTu1.transform.position;
        originalPositions[1] = PinTu2.transform.position;
        originalPositions[2] = PinTu3.transform.position;
        originalPositions[3] = PinTu4.transform.position;
        
        List<int> numbers = new List<int>(); // 宣告一個整數列表
        int count = 4;
        while (numbers.Count < count)
        {
            int number = Random.Range(0, count); // 生成0到3之間的亂數
            if (!numbers.Contains(number)) // 如果列表中不存在該數字
            {
                numbers.Add(number); // 將該數字加入列表
            }
        }

        // 拼圖取隨機位置
        int P1 = numbers[0];
        int P2 = numbers[1];
        int P3 = numbers[2];
        int P4 = numbers[3];


        //紀錄旋轉角度
        rotationAngles = new Quaternion[4];
        rotationAngles[0] = Quaternion.Euler(0f, -45f, 0f);
        rotationAngles[1] = Quaternion.Euler(0f, -80f, 0f);
        rotationAngles[2] = Quaternion.Euler(0f, 45f, 0f);
        rotationAngles[3] = Quaternion.Euler(0f, 60f, 0f);



        PinTu1.transform.position = originalPositions[P1];
        PinTu2.transform.position = originalPositions[P2];
        PinTu3.transform.position = originalPositions[P3];
        PinTu4.transform.position = originalPositions[P4];

        PinTu1.transform.rotation = rotationAngles[P1];
        PinTu2.transform.rotation = rotationAngles[P2];
        PinTu3.transform.rotation = rotationAngles[P3];
        PinTu4.transform.rotation = rotationAngles[P4];
    }
}