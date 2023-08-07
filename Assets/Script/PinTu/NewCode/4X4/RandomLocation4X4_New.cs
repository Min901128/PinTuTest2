using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLocation4X4_New : MonoBehaviour
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
    public GameObject PinTu10;
    public GameObject PinTu11;
    public GameObject PinTu12;
    public GameObject PinTu13;
    public GameObject PinTu14;
    public GameObject PinTu15;
    public GameObject PinTu16;

    private Vector3[] originalPositions;

    private List<Vector3> PinTuPositions;

    void Start()
    {
        // 紀錄初始位置
        originalPositions = new Vector3[16];
        originalPositions[0] = PinTu1.transform.position;
        originalPositions[1] = PinTu2.transform.position;
        originalPositions[2] = PinTu3.transform.position;
        originalPositions[3] = PinTu4.transform.position;
        originalPositions[4] = PinTu5.transform.position;
        originalPositions[5] = PinTu6.transform.position;
        originalPositions[6] = PinTu7.transform.position;
        originalPositions[7] = PinTu8.transform.position;
        originalPositions[8] = PinTu9.transform.position;
        originalPositions[9] = PinTu10.transform.position;
        originalPositions[10] = PinTu11.transform.position;
        originalPositions[11] = PinTu12.transform.position;
        originalPositions[12] = PinTu13.transform.position;
        originalPositions[13] = PinTu14.transform.position;
        originalPositions[14] = PinTu15.transform.position;
        originalPositions[15] = PinTu16.transform.position;
        
        List<int> numbers = new List<int>(); // 宣告一個整數列表
        int count = 16;
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
        int P10 = numbers[9];
        int P11 = numbers[10];
        int P12 = numbers[11];
        int P13 = numbers[12];
        int P14 = numbers[13];
        int P15 = numbers[14];
        int P16 = numbers[15];

        PinTu1.transform.position = originalPositions[P1];
        PinTu2.transform.position = originalPositions[P2];
        PinTu3.transform.position = originalPositions[P3];
        PinTu4.transform.position = originalPositions[P4];
        PinTu5.transform.position = originalPositions[P5];
        PinTu6.transform.position = originalPositions[P6];
        PinTu7.transform.position = originalPositions[P7];
        PinTu8.transform.position = originalPositions[P8];
        PinTu9.transform.position = originalPositions[P9];
        PinTu10.transform.position = originalPositions[P10];
        PinTu11.transform.position = originalPositions[P11];
        PinTu12.transform.position = originalPositions[P12];
        PinTu13.transform.position = originalPositions[P13];
        PinTu14.transform.position = originalPositions[P14];
        PinTu15.transform.position = originalPositions[P15];
        PinTu16.transform.position = originalPositions[P16];
    }
}