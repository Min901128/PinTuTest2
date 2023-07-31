using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLocation4X4 : MonoBehaviour
{
    private float x1 = -0.29f, y1 = 0.14f, x2 = -0.17f, y2 = -0.16f, x3 = 0.34f, y3 = 0.14f;
    private float x4 = 0.47f, y4 = -0.16f, x5 = -0.17f, y5 = 0.03f, x6 = -0.29f, y6 = -0.06f;
    private float x7 = 0.47f, y7 = 0.14f, x8 = 0.47f, y8 = 0.03f, x9 = 0.47f, y9 = -0.06f; 
    private float x10 = -0.17f, y10 = 0.14f, x11 = -0.29f, y11 = 0.03f, x12 = 0.34f, y12 = -0.06f;
    private float x13 = -0.17f, y13 = -0.06f, x14 = 0.34f, y14 = -0.16f, x15 = 0.34f, y15 = 0.03f;
    private float x16 = -0.29f, y16 = -0.16f;
    private float Z = 1.07f;

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

    void Start()
    {
        List<int> numbers = new List<int>(); // 宣告一個整數列表
        int count = 16;
        while (numbers.Count < count)
        {
            int number = Random.Range(1, count + 1); // 生成1到9之間的亂數
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

        //P1抽到幾號位置，並定位
        switch (P1)
        {
            case 1:
                Vector3 position = new Vector3(x1, y1, Z);
                PinTu1.transform.position = position;
                break;
            case 2:
                position = new Vector3(x2, y2, Z);
                PinTu1.transform.position = position;
                break;
            case 3:
                position = new Vector3(x3, y3, Z);
                PinTu1.transform.position = position;
                break;
            case 4:
                position = new Vector3(x4, y4, Z);
                PinTu1.transform.position = position;
                break;
            case 5:
                position = new Vector3(x5, y5, Z);
                PinTu1.transform.position = position;
                break;
            case 6:
                position = new Vector3(x6, y6, Z);
                PinTu1.transform.position = position;
                break;
            case 7:
                position = new Vector3(x7, y7, Z);
                PinTu1.transform.position = position;
                break;
            case 8:
                position = new Vector3(x8, y8, Z);
                PinTu1.transform.position = position;
                break;
            case 9:
                position = new Vector3(x9, y9, Z);
                PinTu1.transform.position = position;
                break;
            case 10:
                position = new Vector3(x10, y10, Z);
                PinTu1.transform.position = position;
                break;
            case 11:
                position = new Vector3(x11, y11, Z);
                PinTu1.transform.position = position;
                break;
            case 12:
                position = new Vector3(x12, y12, Z);
                PinTu1.transform.position = position;
                break;
            case 13:
                position = new Vector3(x13, y13, Z);
                PinTu1.transform.position = position;
                break;
            case 14:
                position = new Vector3(x14, y14, Z);
                PinTu1.transform.position = position;
                break;
            case 15:
                position = new Vector3(x15, y15, Z);
                PinTu1.transform.position = position;
                break;
            case 16:
                position = new Vector3(x16, y16, Z);
                PinTu1.transform.position = position;
                break;
        }

        //P2抽到幾號位置，並定位
        switch (P2)
        {
            case 1:
                Vector3 position = new Vector3(x1, y1, Z);
                PinTu2.transform.position = position;
                break;
            case 2:
                position = new Vector3(x2, y2, Z);
                PinTu2.transform.position = position;
                break;
            case 3:
                position = new Vector3(x3, y3, Z);
                PinTu2.transform.position = position;
                break;
            case 4:
                position = new Vector3(x4, y4, Z);
                PinTu2.transform.position = position;
                break;
            case 5:
                position = new Vector3(x5, y5, Z);
                PinTu2.transform.position = position;
                break;
            case 6:
                position = new Vector3(x6, y6, Z);
                PinTu2.transform.position = position;
                break;
            case 7:
                position = new Vector3(x7, y7, Z);
                PinTu2.transform.position = position;
                break;
            case 8:
                position = new Vector3(x8, y8, Z);
                PinTu2.transform.position = position;
                break;
            case 9:
                position = new Vector3(x9, y9, Z);
                PinTu2.transform.position = position;
                break;
            case 10:
                position = new Vector3(x10, y10, Z);
                PinTu2.transform.position = position;
                break;
            case 11:
                position = new Vector3(x11, y11, Z);
                PinTu2.transform.position = position;
                break;
            case 12:
                position = new Vector3(x12, y12, Z);
                PinTu2.transform.position = position;
                break;
            case 13:
                position = new Vector3(x13, y13, Z);
                PinTu2.transform.position = position;
                break;
            case 14:
                position = new Vector3(x14, y14, Z);
                PinTu2.transform.position = position;
                break;
            case 15:
                position = new Vector3(x15, y15, Z);
                PinTu2.transform.position = position;
                break;
            case 16:
                position = new Vector3(x16, y16, Z);
                PinTu2.transform.position = position;
                break;
        }

        //P3抽到幾號位置，並定位
        switch (P3)
        {
            case 1:
                Vector3 position = new Vector3(x1, y1, Z);
                PinTu3.transform.position = position;
                break;
            case 2:
                position = new Vector3(x2, y2, Z);
                PinTu3.transform.position = position;
                break;
            case 3:
                position = new Vector3(x3, y3, Z);
                PinTu3.transform.position = position;
                break;
            case 4:
                position = new Vector3(x4, y4, Z);
                PinTu3.transform.position = position;
                break;
            case 5:
                position = new Vector3(x5, y5, Z);
                PinTu3.transform.position = position;
                break;
            case 6:
                position = new Vector3(x6, y6, Z);
                PinTu3.transform.position = position;
                break;
            case 7:
                position = new Vector3(x7, y7, Z);
                PinTu3.transform.position = position;
                break;
            case 8:
                position = new Vector3(x8, y8, Z);
                PinTu3.transform.position = position;
                break;
            case 9:
                position = new Vector3(x9, y9, Z);
                PinTu3.transform.position = position;
                break;
            case 10:
                position = new Vector3(x10, y10, Z);
                PinTu3.transform.position = position;
                break;
            case 11:
                position = new Vector3(x11, y11, Z);
                PinTu3.transform.position = position;
                break;
            case 12:
                position = new Vector3(x12, y12, Z);
                PinTu3.transform.position = position;
                break;
            case 13:
                position = new Vector3(x13, y13, Z);
                PinTu3.transform.position = position;
                break;
            case 14:
                position = new Vector3(x14, y14, Z);
                PinTu3.transform.position = position;
                break;
            case 15:
                position = new Vector3(x15, y15, Z);
                PinTu3.transform.position = position;
                break;
            case 16:
                position = new Vector3(x16, y16, Z);
                PinTu3.transform.position = position;
                break;
        }

        //P4抽到幾號位置，並定位
        switch (P4)
        {
            case 1:
                Vector3 position = new Vector3(x1, y1, Z);
                PinTu4.transform.position = position;
                break;
            case 2:
                position = new Vector3(x2, y2, Z);
                PinTu4.transform.position = position;
                break;
            case 3:
                position = new Vector3(x3, y3, Z);
                PinTu4.transform.position = position;
                break;
            case 4:
                position = new Vector3(x4, y4, Z);
                PinTu4.transform.position = position;
                break;
            case 5:
                position = new Vector3(x5, y5, Z);
                PinTu4.transform.position = position;
                break;
            case 6:
                position = new Vector3(x6, y6, Z);
                PinTu4.transform.position = position;
                break;
            case 7:
                position = new Vector3(x7, y7, Z);
                PinTu4.transform.position = position;
                break;
            case 8:
                position = new Vector3(x8, y8, Z);
                PinTu4.transform.position = position;
                break;
            case 9:
                position = new Vector3(x9, y9, Z);
                PinTu4.transform.position = position;
                break;
            case 10:
                position = new Vector3(x10, y10, Z);
                PinTu4.transform.position = position;
                break;
            case 11:
                position = new Vector3(x11, y11, Z);
                PinTu4.transform.position = position;
                break;
            case 12:
                position = new Vector3(x12, y12, Z);
                PinTu4.transform.position = position;
                break;
            case 13:
                position = new Vector3(x13, y13, Z);
                PinTu4.transform.position = position;
                break;
            case 14:
                position = new Vector3(x14, y14, Z);
                PinTu4.transform.position = position;
                break;
            case 15:
                position = new Vector3(x15, y15, Z);
                PinTu4.transform.position = position;
                break;
            case 16:
                position = new Vector3(x16, y16, Z);
                PinTu4.transform.position = position;
                break;
        }

        switch (P5)
        {
            case 1:
                Vector3 position = new Vector3(x1, y1, Z);
                PinTu5.transform.position = position;
                break;
            case 2:
                position = new Vector3(x2, y2, Z);
                PinTu5.transform.position = position;
                break;
            case 3:
                position = new Vector3(x3, y3, Z);
                PinTu5.transform.position = position;
                break;
            case 4:
                position = new Vector3(x4, y4, Z);
                PinTu5.transform.position = position;
                break;
            case 5:
                position = new Vector3(x5, y5, Z);
                PinTu5.transform.position = position;
                break;
            case 6:
                position = new Vector3(x6, y6, Z);
                PinTu5.transform.position = position;
                break;
            case 7:
                position = new Vector3(x7, y7, Z);
                PinTu5.transform.position = position;
                break;
            case 8:
                position = new Vector3(x8, y8, Z);
                PinTu5.transform.position = position;
                break;
            case 9:
                position = new Vector3(x9, y9, Z);
                PinTu5.transform.position = position;
                break;
            case 10:
                position = new Vector3(x10, y10, Z);
                PinTu5.transform.position = position;
                break;
            case 11:
                position = new Vector3(x11, y11, Z);
                PinTu5.transform.position = position;
                break;
            case 12:
                position = new Vector3(x12, y12, Z);
                PinTu5.transform.position = position;
                break;
            case 13:
                position = new Vector3(x13, y13, Z);
                PinTu5.transform.position = position;
                break;
            case 14:
                position = new Vector3(x14, y14, Z);
                PinTu5.transform.position = position;
                break;
            case 15:
                position = new Vector3(x15, y15, Z);
                PinTu5.transform.position = position;
                break;
            case 16:
                position = new Vector3(x16, y16, Z);
                PinTu5.transform.position = position;
                break;
        }

        switch (P6)
        {
            case 1:
                Vector3 position = new Vector3(x1, y1, Z);
                PinTu6.transform.position = position;
                break;
            case 2:
                position = new Vector3(x2, y2, Z);
                PinTu6.transform.position = position;
                break;
            case 3:
                position = new Vector3(x3, y3, Z);
                PinTu6.transform.position = position;
                break;
            case 4:
                position = new Vector3(x4, y4, Z);
                PinTu6.transform.position = position;
                break;
            case 5:
                position = new Vector3(x5, y5, Z);
                PinTu6.transform.position = position;
                break;
            case 6:
                position = new Vector3(x6, y6, Z);
                PinTu6.transform.position = position;
                break;
            case 7:
                position = new Vector3(x7, y7, Z);
                PinTu6.transform.position = position;
                break;
            case 8:
                position = new Vector3(x8, y8, Z);
                PinTu6.transform.position = position;
                break;
            case 9:
                position = new Vector3(x9, y9, Z);
                PinTu6.transform.position = position;
                break;
            case 10:
                position = new Vector3(x10, y10, Z);
                PinTu6.transform.position = position;
                break;
            case 11:
                position = new Vector3(x11, y11, Z);
                PinTu6.transform.position = position;
                break;
            case 12:
                position = new Vector3(x12, y12, Z);
                PinTu6.transform.position = position;
                break;
            case 13:
                position = new Vector3(x13, y13, Z);
                PinTu6.transform.position = position;
                break;
            case 14:
                position = new Vector3(x14, y14, Z);
                PinTu6.transform.position = position;
                break;
            case 15:
                position = new Vector3(x15, y15, Z);
                PinTu6.transform.position = position;
                break;
            case 16:
                position = new Vector3(x16, y16, Z);
                PinTu6.transform.position = position;
                break;
        }

        switch (P7)
        {
            case 1:
                Vector3 position = new Vector3(x1, y1, Z);
                PinTu7.transform.position = position;
                break;
            case 2:
                position = new Vector3(x2, y2, Z);
                PinTu7.transform.position = position;
                break;
            case 3:
                position = new Vector3(x3, y3, Z);
                PinTu7.transform.position = position;
                break;
            case 4:
                position = new Vector3(x4, y4, Z);
                PinTu7.transform.position = position;
                break;
            case 5:
                position = new Vector3(x5, y5, Z);
                PinTu7.transform.position = position;
                break;
            case 6:
                position = new Vector3(x6, y6, Z);
                PinTu7.transform.position = position;
                break;
            case 7:
                position = new Vector3(x7, y7, Z);
                PinTu7.transform.position = position;
                break;
            case 8:
                position = new Vector3(x8, y8, Z);
                PinTu7.transform.position = position;
                break;
            case 9:
                position = new Vector3(x9, y9, Z);
                PinTu7.transform.position = position;
                break;
            case 10:
                position = new Vector3(x10, y10, Z);
                PinTu7.transform.position = position;
                break;
            case 11:
                position = new Vector3(x11, y11, Z);
                PinTu7.transform.position = position;
                break;
            case 12:
                position = new Vector3(x12, y12, Z);
                PinTu7.transform.position = position;
                break;
            case 13:
                position = new Vector3(x13, y13, Z);
                PinTu7.transform.position = position;
                break;
            case 14:
                position = new Vector3(x14, y14, Z);
                PinTu7.transform.position = position;
                break;
            case 15:
                position = new Vector3(x15, y15, Z);
                PinTu7.transform.position = position;
                break;
            case 16:
                position = new Vector3(x16, y16, Z);
                PinTu7.transform.position = position;
                break;
        }

        switch (P8)
        {
            case 1:
                Vector3 position = new Vector3(x1, y1, Z);
                PinTu8.transform.position = position;
                break;
            case 2:
                position = new Vector3(x2, y2, Z);
                PinTu8.transform.position = position;
                break;
            case 3:
                position = new Vector3(x3, y3, Z);
                PinTu8.transform.position = position;
                break;
            case 4:
                position = new Vector3(x4, y4, Z);
                PinTu8.transform.position = position;
                break;
            case 5:
                position = new Vector3(x5, y5, Z);
                PinTu8.transform.position = position;
                break;
            case 6:
                position = new Vector3(x6, y6, Z);
                PinTu8.transform.position = position;
                break;
            case 7:
                position = new Vector3(x7, y7, Z);
                PinTu8.transform.position = position;
                break;
            case 8:
                position = new Vector3(x8, y8, Z);
                PinTu8.transform.position = position;
                break;
            case 9:
                position = new Vector3(x9, y9, Z);
                PinTu8.transform.position = position;
                break;
            case 10:
                position = new Vector3(x10, y10, Z);
                PinTu8.transform.position = position;
                break;
            case 11:
                position = new Vector3(x11, y11, Z);
                PinTu8.transform.position = position;
                break;
            case 12:
                position = new Vector3(x12, y12, Z);
                PinTu8.transform.position = position;
                break;
            case 13:
                position = new Vector3(x13, y13, Z);
                PinTu8.transform.position = position;
                break;
            case 14:
                position = new Vector3(x14, y14, Z);
                PinTu8.transform.position = position;
                break;
            case 15:
                position = new Vector3(x15, y15, Z);
                PinTu8.transform.position = position;
                break;
            case 16:
                position = new Vector3(x16, y16, Z);
                PinTu8.transform.position = position;
                break;
        }

        switch (P9)
        {
            case 1:
                Vector3 position = new Vector3(x1, y1, Z);
                PinTu9.transform.position = position;
                break;
            case 2:
                position = new Vector3(x2, y2, Z);
                PinTu9.transform.position = position;
                break;
            case 3:
                position = new Vector3(x3, y3, Z);
                PinTu9.transform.position = position;
                break;
            case 4:
                position = new Vector3(x4, y4, Z);
                PinTu9.transform.position = position;
                break;
            case 5:
                position = new Vector3(x5, y5, Z);
                PinTu9.transform.position = position;
                break;
            case 6:
                position = new Vector3(x6, y6, Z);
                PinTu9.transform.position = position;
                break;
            case 7:
                position = new Vector3(x7, y7, Z);
                PinTu9.transform.position = position;
                break;
            case 8:
                position = new Vector3(x8, y8, Z);
                PinTu9.transform.position = position;
                break;
            case 9:
                position = new Vector3(x9, y9, Z);
                PinTu9.transform.position = position;
                break;
            case 10:
                position = new Vector3(x10, y10, Z);
                PinTu9.transform.position = position;
                break;
            case 11:
                position = new Vector3(x11, y11, Z);
                PinTu9.transform.position = position;
                break;
            case 12:
                position = new Vector3(x12, y12, Z);
                PinTu9.transform.position = position;
                break;
            case 13:
                position = new Vector3(x13, y13, Z);
                PinTu9.transform.position = position;
                break;
            case 14:
                position = new Vector3(x14, y14, Z);
                PinTu9.transform.position = position;
                break;
            case 15:
                position = new Vector3(x15, y15, Z);
                PinTu9.transform.position = position;
                break;
            case 16:
                position = new Vector3(x16, y16, Z);
                PinTu9.transform.position = position;
                break;
        }

        switch (P10)
        {
            case 1:
                Vector3 position = new Vector3(x1, y1, Z);
                PinTu10.transform.position = position;
                break;
            case 2:
                position = new Vector3(x2, y2, Z);
                PinTu10.transform.position = position;
                break;
            case 3:
                position = new Vector3(x3, y3, Z);
                PinTu10.transform.position = position;
                break;
            case 4:
                position = new Vector3(x4, y4, Z);
                PinTu10.transform.position = position;
                break;
            case 5:
                position = new Vector3(x5, y5, Z);
                PinTu10.transform.position = position;
                break;
            case 6:
                position = new Vector3(x6, y6, Z);
                PinTu10.transform.position = position;
                break;
            case 7:
                position = new Vector3(x7, y7, Z);
                PinTu10.transform.position = position;
                break;
            case 8:
                position = new Vector3(x8, y8, Z);
                PinTu10.transform.position = position;
                break;
            case 9:
                position = new Vector3(x9, y9, Z);
                PinTu10.transform.position = position;
                break;
            case 10:
                position = new Vector3(x10, y10, Z);
                PinTu10.transform.position = position;
                break;
            case 11:
                position = new Vector3(x11, y11, Z);
                PinTu10.transform.position = position;
                break;
            case 12:
                position = new Vector3(x12, y12, Z);
                PinTu10.transform.position = position;
                break;
            case 13:
                position = new Vector3(x13, y13, Z);
                PinTu10.transform.position = position;
                break;
            case 14:
                position = new Vector3(x14, y14, Z);
                PinTu10.transform.position = position;
                break;
            case 15:
                position = new Vector3(x15, y15, Z);
                PinTu10.transform.position = position;
                break;
            case 16:
                position = new Vector3(x16, y16, Z);
                PinTu10.transform.position = position;
                break;
        }

        switch (P11)
        {
            case 1:
                Vector3 position = new Vector3(x1, y1, Z);
                PinTu11.transform.position = position;
                break;
            case 2:
                position = new Vector3(x2, y2, Z);
                PinTu11.transform.position = position;
                break;
            case 3:
                position = new Vector3(x3, y3, Z);
                PinTu11.transform.position = position;
                break;
            case 4:
                position = new Vector3(x4, y4, Z);
                PinTu11.transform.position = position;
                break;
            case 5:
                position = new Vector3(x5, y5, Z);
                PinTu11.transform.position = position;
                break;
            case 6:
                position = new Vector3(x6, y6, Z);
                PinTu11.transform.position = position;
                break;
            case 7:
                position = new Vector3(x7, y7, Z);
                PinTu11.transform.position = position;
                break;
            case 8:
                position = new Vector3(x8, y8, Z);
                PinTu11.transform.position = position;
                break;
            case 9:
                position = new Vector3(x9, y9, Z);
                PinTu11.transform.position = position;
                break;
            case 10:
                position = new Vector3(x10, y10, Z);
                PinTu11.transform.position = position;
                break;
            case 11:
                position = new Vector3(x11, y11, Z);
                PinTu11.transform.position = position;
                break;
            case 12:
                position = new Vector3(x12, y12, Z);
                PinTu11.transform.position = position;
                break;
            case 13:
                position = new Vector3(x13, y13, Z);
                PinTu11.transform.position = position;
                break;
            case 14:
                position = new Vector3(x14, y14, Z);
                PinTu11.transform.position = position;
                break;
            case 15:
                position = new Vector3(x15, y15, Z);
                PinTu11.transform.position = position;
                break;
            case 16:
                position = new Vector3(x16, y16, Z);
                PinTu11.transform.position = position;
                break;
        }

        switch (P11)
        {
            case 1:
                Vector3 position = new Vector3(x1, y1, Z);
                PinTu11.transform.position = position;
                break;
            case 2:
                position = new Vector3(x2, y2, Z);
                PinTu11.transform.position = position;
                break;
            case 3:
                position = new Vector3(x3, y3, Z);
                PinTu11.transform.position = position;
                break;
            case 4:
                position = new Vector3(x4, y4, Z);
                PinTu11.transform.position = position;
                break;
            case 5:
                position = new Vector3(x5, y5, Z);
                PinTu11.transform.position = position;
                break;
            case 6:
                position = new Vector3(x6, y6, Z);
                PinTu11.transform.position = position;
                break;
            case 7:
                position = new Vector3(x7, y7, Z);
                PinTu11.transform.position = position;
                break;
            case 8:
                position = new Vector3(x8, y8, Z);
                PinTu11.transform.position = position;
                break;
            case 9:
                position = new Vector3(x9, y9, Z);
                PinTu11.transform.position = position;
                break;
            case 10:
                position = new Vector3(x10, y10, Z);
                PinTu11.transform.position = position;
                break;
            case 11:
                position = new Vector3(x11, y11, Z);
                PinTu11.transform.position = position;
                break;
            case 12:
                position = new Vector3(x12, y12, Z);
                PinTu11.transform.position = position;
                break;
            case 13:
                position = new Vector3(x13, y13, Z);
                PinTu11.transform.position = position;
                break;
            case 14:
                position = new Vector3(x14, y14, Z);
                PinTu11.transform.position = position;
                break;
            case 15:
                position = new Vector3(x15, y15, Z);
                PinTu11.transform.position = position;
                break;
            case 16:
                position = new Vector3(x16, y16, Z);
                PinTu11.transform.position = position;
                break;
        }

        switch (P12)
        {
            case 1:
                Vector3 position = new Vector3(x1, y1, Z);
                PinTu12.transform.position = position;
                break;
            case 2:
                position = new Vector3(x2, y2, Z);
                PinTu12.transform.position = position;
                break;
            case 3:
                position = new Vector3(x3, y3, Z);
                PinTu12.transform.position = position;
                break;
            case 4:
                position = new Vector3(x4, y4, Z);
                PinTu12.transform.position = position;
                break;
            case 5:
                position = new Vector3(x5, y5, Z);
                PinTu12.transform.position = position;
                break;
            case 6:
                position = new Vector3(x6, y6, Z);
                PinTu12.transform.position = position;
                break;
            case 7:
                position = new Vector3(x7, y7, Z);
                PinTu12.transform.position = position;
                break;
            case 8:
                position = new Vector3(x8, y8, Z);
                PinTu12.transform.position = position;
                break;
            case 9:
                position = new Vector3(x9, y9, Z);
                PinTu12.transform.position = position;
                break;
            case 10:
                position = new Vector3(x10, y10, Z);
                PinTu12.transform.position = position;
                break;
            case 11:
                position = new Vector3(x11, y11, Z);
                PinTu12.transform.position = position;
                break;
            case 12:
                position = new Vector3(x12, y12, Z);
                PinTu12.transform.position = position;
                break;
            case 13:
                position = new Vector3(x13, y13, Z);
                PinTu12.transform.position = position;
                break;
            case 14:
                position = new Vector3(x14, y14, Z);
                PinTu12.transform.position = position;
                break;
            case 15:
                position = new Vector3(x15, y15, Z);
                PinTu12.transform.position = position;
                break;
            case 16:
                position = new Vector3(x16, y16, Z);
                PinTu12.transform.position = position;
                break;
        }

        switch (P13)
        {
            case 1:
                Vector3 position = new Vector3(x1, y1, Z);
                PinTu13.transform.position = position;
                break;
            case 2:
                position = new Vector3(x2, y2, Z);
                PinTu13.transform.position = position;
                break;
            case 3:
                position = new Vector3(x3, y3, Z);
                PinTu13.transform.position = position;
                break;
            case 4:
                position = new Vector3(x4, y4, Z);
                PinTu13.transform.position = position;
                break;
            case 5:
                position = new Vector3(x5, y5, Z);
                PinTu13.transform.position = position;
                break;
            case 6:
                position = new Vector3(x6, y6, Z);
                PinTu13.transform.position = position;
                break;
            case 7:
                position = new Vector3(x7, y7, Z);
                PinTu13.transform.position = position;
                break;
            case 8:
                position = new Vector3(x8, y8, Z);
                PinTu13.transform.position = position;
                break;
            case 9:
                position = new Vector3(x9, y9, Z);
                PinTu13.transform.position = position;
                break;
            case 10:
                position = new Vector3(x10, y10, Z);
                PinTu13.transform.position = position;
                break;
            case 11:
                position = new Vector3(x11, y11, Z);
                PinTu13.transform.position = position;
                break;
            case 12:
                position = new Vector3(x12, y12, Z);
                PinTu13.transform.position = position;
                break;
            case 13:
                position = new Vector3(x13, y13, Z);
                PinTu13.transform.position = position;
                break;
            case 14:
                position = new Vector3(x14, y14, Z);
                PinTu13.transform.position = position;
                break;
            case 15:
                position = new Vector3(x15, y15, Z);
                PinTu13.transform.position = position;
                break;
            case 16:
                position = new Vector3(x16, y16, Z);
                PinTu13.transform.position = position;
                break;
        }

        switch (P14)
        {
            case 1:
                Vector3 position = new Vector3(x1, y1, Z);
                PinTu14.transform.position = position;
                break;
            case 2:
                position = new Vector3(x2, y2, Z);
                PinTu14.transform.position = position;
                break;
            case 3:
                position = new Vector3(x3, y3, Z);
                PinTu14.transform.position = position;
                break;
            case 4:
                position = new Vector3(x4, y4, Z);
                PinTu14.transform.position = position;
                break;
            case 5:
                position = new Vector3(x5, y5, Z);
                PinTu14.transform.position = position;
                break;
            case 6:
                position = new Vector3(x6, y6, Z);
                PinTu14.transform.position = position;
                break;
            case 7:
                position = new Vector3(x7, y7, Z);
                PinTu14.transform.position = position;
                break;
            case 8:
                position = new Vector3(x8, y8, Z);
                PinTu14.transform.position = position;
                break;
            case 9:
                position = new Vector3(x9, y9, Z);
                PinTu14.transform.position = position;
                break;
            case 10:
                position = new Vector3(x10, y10, Z);
                PinTu14.transform.position = position;
                break;
            case 11:
                position = new Vector3(x11, y11, Z);
                PinTu14.transform.position = position;
                break;
            case 12:
                position = new Vector3(x12, y12, Z);
                PinTu14.transform.position = position;
                break;
            case 13:
                position = new Vector3(x13, y13, Z);
                PinTu14.transform.position = position;
                break;
            case 14:
                position = new Vector3(x14, y14, Z);
                PinTu14.transform.position = position;
                break;
            case 15:
                position = new Vector3(x15, y15, Z);
                PinTu14.transform.position = position;
                break;
            case 16:
                position = new Vector3(x16, y16, Z);
                PinTu14.transform.position = position;
                break;
        }

        switch (P15)
        {
            case 1:
                Vector3 position = new Vector3(x1, y1, Z);
                PinTu15.transform.position = position;
                break;
            case 2:
                position = new Vector3(x2, y2, Z);
                PinTu15.transform.position = position;
                break;
            case 3:
                position = new Vector3(x3, y3, Z);
                PinTu15.transform.position = position;
                break;
            case 4:
                position = new Vector3(x4, y4, Z);
                PinTu15.transform.position = position;
                break;
            case 5:
                position = new Vector3(x5, y5, Z);
                PinTu15.transform.position = position;
                break;
            case 6:
                position = new Vector3(x6, y6, Z);
                PinTu15.transform.position = position;
                break;
            case 7:
                position = new Vector3(x7, y7, Z);
                PinTu15.transform.position = position;
                break;
            case 8:
                position = new Vector3(x8, y8, Z);
                PinTu15.transform.position = position;
                break;
            case 9:
                position = new Vector3(x9, y9, Z);
                PinTu15.transform.position = position;
                break;
            case 10:
                position = new Vector3(x10, y10, Z);
                PinTu15.transform.position = position;
                break;
            case 11:
                position = new Vector3(x11, y11, Z);
                PinTu15.transform.position = position;
                break;
            case 12:
                position = new Vector3(x12, y12, Z);
                PinTu15.transform.position = position;
                break;
            case 13:
                position = new Vector3(x13, y13, Z);
                PinTu15.transform.position = position;
                break;
            case 14:
                position = new Vector3(x14, y14, Z);
                PinTu15.transform.position = position;
                break;
            case 15:
                position = new Vector3(x15, y15, Z);
                PinTu15.transform.position = position;
                break;
            case 16:
                position = new Vector3(x16, y16, Z);
                PinTu15.transform.position = position;
                break;
        }

        switch (P16)
        {
            case 1:
                Vector3 position = new Vector3(x1, y1, Z);
                PinTu16.transform.position = position;
                break;
            case 2:
                position = new Vector3(x2, y2, Z);
                PinTu16.transform.position = position;
                break;
            case 3:
                position = new Vector3(x3, y3, Z);
                PinTu16.transform.position = position;
                break;
            case 4:
                position = new Vector3(x4, y4, Z);
                PinTu16.transform.position = position;
                break;
            case 5:
                position = new Vector3(x5, y5, Z);
                PinTu16.transform.position = position;
                break;
            case 6:
                position = new Vector3(x6, y6, Z);
                PinTu16.transform.position = position;
                break;
            case 7:
                position = new Vector3(x7, y7, Z);
                PinTu16.transform.position = position;
                break;
            case 8:
                position = new Vector3(x8, y8, Z);
                PinTu16.transform.position = position;
                break;
            case 9:
                position = new Vector3(x9, y9, Z);
                PinTu16.transform.position = position;
                break;
            case 10:
                position = new Vector3(x10, y10, Z);
                PinTu16.transform.position = position;
                break;
            case 11:
                position = new Vector3(x11, y11, Z);
                PinTu16.transform.position = position;
                break;
            case 12:
                position = new Vector3(x12, y12, Z);
                PinTu16.transform.position = position;
                break;
            case 13:
                position = new Vector3(x13, y13, Z);
                PinTu16.transform.position = position;
                break;
            case 14:
                position = new Vector3(x14, y14, Z);
                PinTu16.transform.position = position;
                break;
            case 15:
                position = new Vector3(x15, y15, Z);
                PinTu16.transform.position = position;
                break;
            case 16:
                position = new Vector3(x16, y16, Z);
                PinTu16.transform.position = position;
                break;
        }
    }
}
