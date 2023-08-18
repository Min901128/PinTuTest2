using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpacePinTuRandomLocation3X3 : MonoBehaviour
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

    private Vector3[] originalPositions;

    private Quaternion[] rotationAngles;

    private List<Vector3> PinTuPositions;

    void Start()
    {
        // 紀錄初始位置
        originalPositions = new Vector3[9];
        originalPositions[0] = PinTu1.transform.position;
        originalPositions[1] = PinTu2.transform.position;
        originalPositions[2] = PinTu3.transform.position;
        originalPositions[3] = PinTu4.transform.position;
        originalPositions[4] = PinTu5.transform.position;
        originalPositions[5] = PinTu6.transform.position;
        originalPositions[6] = PinTu7.transform.position;
        originalPositions[7] = PinTu8.transform.position;
        originalPositions[8] = PinTu9.transform.position;
        
        List<int> numbers = new List<int>(); // 宣告一個整數列表
        int count = 9;
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
        int P5 = numbers[4];
        int P6 = numbers[5];
        int P7 = numbers[6];
        int P8 = numbers[7];
        int P9 = numbers[8];

        //紀錄旋轉角度
        rotationAngles = new Quaternion[9];
        rotationAngles[0] = Quaternion.Euler(0f, -45f, 0f);
        rotationAngles[1] = Quaternion.Euler(0f, 90f, 0f);
        rotationAngles[2] = Quaternion.Euler(0f, -120f, 0f);
        rotationAngles[3] = Quaternion.Euler(0f, -10f, 0f);
        rotationAngles[4] = Quaternion.Euler(0f, 40f, 0f);
        rotationAngles[5] = Quaternion.Euler(0f, -70f, 0f);
        rotationAngles[6] = Quaternion.Euler(0f, -145f, 0f);
        rotationAngles[7] = Quaternion.Euler(0f, 120f, 0f);
        rotationAngles[8] = Quaternion.Euler(0f, -110f, 0f);



        PinTu1.transform.position = originalPositions[P1];
        PinTu2.transform.position = originalPositions[P2];
        PinTu3.transform.position = originalPositions[P3];
        PinTu4.transform.position = originalPositions[P4];
        PinTu5.transform.position = originalPositions[P5];
        PinTu6.transform.position = originalPositions[P6];
        PinTu7.transform.position = originalPositions[P7];
        PinTu8.transform.position = originalPositions[P8];
        PinTu9.transform.position = originalPositions[P9];



        PinTu1.transform.rotation = rotationAngles[P1];
        PinTu2.transform.rotation = rotationAngles[P2];
        PinTu3.transform.rotation = rotationAngles[P3];
        PinTu4.transform.rotation = rotationAngles[P4];
        PinTu5.transform.rotation = rotationAngles[P5];
        PinTu6.transform.rotation = rotationAngles[P6];
        PinTu7.transform.rotation = rotationAngles[P7];
        PinTu8.transform.rotation = rotationAngles[P8];
        PinTu9.transform.rotation = rotationAngles[P9];
    }
}