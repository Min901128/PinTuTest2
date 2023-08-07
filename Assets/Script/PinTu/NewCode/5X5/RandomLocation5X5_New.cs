using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLocation5X5_New : MonoBehaviour
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
    public GameObject PinTu17;
    public GameObject PinTu18;
    public GameObject PinTu19;
    public GameObject PinTu20;
    public GameObject PinTu21;
    public GameObject PinTu22;
    public GameObject PinTu23;
    public GameObject PinTu24;
    public GameObject PinTu25;

    private Vector3[] originalPositions;

    private List<Vector3> PinTuPositions;

    void Start()
    {
        // 紀錄初始位置
        originalPositions = new Vector3[25];
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
        originalPositions[16] = PinTu17.transform.position;
        originalPositions[17] = PinTu18.transform.position;
        originalPositions[18] = PinTu19.transform.position;
        originalPositions[19] = PinTu20.transform.position;
        originalPositions[20] = PinTu21.transform.position;
        originalPositions[21] = PinTu22.transform.position;
        originalPositions[22] = PinTu23.transform.position;
        originalPositions[23] = PinTu24.transform.position;
        originalPositions[24] = PinTu25.transform.position;
        
        List<int> numbers = new List<int>(); // 宣告一個整數列表
        int count = 25;
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
        int P17 = numbers[16];
        int P18 = numbers[17];
        int P19 = numbers[18];
        int P20 = numbers[19];
        int P21 = numbers[20];
        int P22 = numbers[21];
        int P23 = numbers[22];
        int P24 = numbers[23];
        int P25 = numbers[24];

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
        PinTu17.transform.position = originalPositions[P17];
        PinTu18.transform.position = originalPositions[P18];
        PinTu19.transform.position = originalPositions[P19];
        PinTu20.transform.position = originalPositions[P20];
        PinTu21.transform.position = originalPositions[P21];
        PinTu22.transform.position = originalPositions[P22];
        PinTu23.transform.position = originalPositions[P23];
        PinTu24.transform.position = originalPositions[P24];
        PinTu25.transform.position = originalPositions[P25];
    }
}