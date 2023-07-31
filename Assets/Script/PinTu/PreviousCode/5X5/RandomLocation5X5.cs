using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLocation5X5 : MonoBehaviour
{
    private float x1 = -0.29f, y1 = 0.22f, x2 = -0.29f, y2 = 0.14f, x3 = -0.29f, y3 = 0.07f, x4 = -0.29f, y4 = -0.01f, x5 = -0.29f, y5 = -0.08f, x6 = -0.29f, y6 = -0.16f;
    private float x7 = -0.18f, y7 = 0.22f, x8 = -0.18f, y8 = 0.14f, x9 = -0.18f, y9 = 0.07f, x10 = -0.18f, y10 = -0.01f, x11 = -0.18f, y11 = -0.08f, x12 = -0.18f, y12 = -0.16f; 
    private float x13 = 0.31f, y13 = 0.22f, x14 = 0.31f, y14 = 0.14f, x15 = 0.31f, y15 = 0.07f, x16 = 0.31f, y16 = -0.01f, x17 = 0.31f, y17 = -0.08f, x18 = 0.31f, y18 = -0.16f; 
    private float x19 = 0.41f, y19 = 0.29f, x20 = 0.41f, y20 = 0.22f, x21 = 0.41f, y21 = 0.14f, x22 = 0.41f, y22 = 0.07f, x23 = 0.41f, y23 = -0.01f, x24 = 0.41f, y24 = -0.08f, x25 = 0.41f, y25 = -0.16f;
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
    public GameObject PinTu17;
    public GameObject PinTu18;
    public GameObject PinTu19;
    public GameObject PinTu20;
    public GameObject PinTu21;
    public GameObject PinTu22;
    public GameObject PinTu23;
    public GameObject PinTu24;
    public GameObject PinTu25;

    void Start()
    {
        List<int> numbers = new List<int>(); // 宣告一個整數列表
        int count = 25;
        while (numbers.Count < count)
        {
            int number = Random.Range(1, count + 1); // 生成1到25之間的亂數
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
            case 17:
                position = new Vector3(x17, y17, Z);
                PinTu1.transform.position = position;
                break;
            case 18:
                position = new Vector3(x18, y18, Z);
                PinTu1.transform.position = position;
                break;
            case 19:
                position = new Vector3(x19, y19, Z);
                PinTu1.transform.position = position;
                break;
            case 20:
                position = new Vector3(x20, y20, Z);
                PinTu1.transform.position = position;
                break;
            case 21:
                position = new Vector3(x21, y21, Z);
                PinTu1.transform.position = position;
                break;
            case 22:
                position = new Vector3(x22, y22, Z);
                PinTu1.transform.position = position;
                break;
            case 23:
                position = new Vector3(x23, y23, Z);
                PinTu1.transform.position = position;
                break;
            case 24:
                position = new Vector3(x24, y24, Z);
                PinTu1.transform.position = position;
                break;
            case 25:
                position = new Vector3(x25, y25, Z);
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
            case 17:
                position = new Vector3(x17, y17, Z);
                PinTu2.transform.position = position;
                break;
            case 18:
                position = new Vector3(x18, y18, Z);
                PinTu2.transform.position = position;
                break;
            case 19:
                position = new Vector3(x19, y19, Z);
                PinTu2.transform.position = position;
                break;
            case 20:
                position = new Vector3(x20, y20, Z);
                PinTu2.transform.position = position;
                break;
            case 21:
                position = new Vector3(x21, y21, Z);
                PinTu2.transform.position = position;
                break;
            case 22:
                position = new Vector3(x22, y22, Z);
                PinTu2.transform.position = position;
                break;
            case 23:
                position = new Vector3(x23, y23, Z);
                PinTu2.transform.position = position;
                break;
            case 24:
                position = new Vector3(x24, y24, Z);
                PinTu2.transform.position = position;
                break;
            case 25:
                position = new Vector3(x25, y25, Z);
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
            case 17:
                position = new Vector3(x17, y17, Z);
                PinTu3.transform.position = position;
                break;
            case 18:
                position = new Vector3(x18, y18, Z);
                PinTu3.transform.position = position;
                break;
            case 19:
                position = new Vector3(x19, y19, Z);
                PinTu3.transform.position = position;
                break;
            case 20:
                position = new Vector3(x20, y20, Z);
                PinTu3.transform.position = position;
                break;
            case 21:
                position = new Vector3(x21, y21, Z);
                PinTu3.transform.position = position;
                break;
            case 22:
                position = new Vector3(x22, y22, Z);
                PinTu3.transform.position = position;
                break;
            case 23:
                position = new Vector3(x23, y23, Z);
                PinTu3.transform.position = position;
                break;
            case 24:
                position = new Vector3(x24, y24, Z);
                PinTu3.transform.position = position;
                break;
            case 25:
                position = new Vector3(x25, y25, Z);
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
            case 17:
                position = new Vector3(x17, y17, Z);
                PinTu4.transform.position = position;
                break;
            case 18:
                position = new Vector3(x18, y18, Z);
                PinTu4.transform.position = position;
                break;
            case 19:
                position = new Vector3(x19, y19, Z);
                PinTu4.transform.position = position;
                break;
            case 20:
                position = new Vector3(x20, y20, Z);
                PinTu4.transform.position = position;
                break;
            case 21:
                position = new Vector3(x21, y21, Z);
                PinTu4.transform.position = position;
                break;
            case 22:
                position = new Vector3(x22, y22, Z);
                PinTu4.transform.position = position;
                break;
            case 23:
                position = new Vector3(x23, y23, Z);
                PinTu4.transform.position = position;
                break;
            case 24:
                position = new Vector3(x24, y24, Z);
                PinTu4.transform.position = position;
                break;
            case 25:
                position = new Vector3(x25, y25, Z);
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
            case 17:
                position = new Vector3(x17, y17, Z);
                PinTu5.transform.position = position;
                break;
            case 18:
                position = new Vector3(x18, y18, Z);
                PinTu5.transform.position = position;
                break;
            case 19:
                position = new Vector3(x19, y19, Z);
                PinTu5.transform.position = position;
                break;
            case 20:
                position = new Vector3(x20, y20, Z);
                PinTu5.transform.position = position;
                break;
            case 21:
                position = new Vector3(x21, y21, Z);
                PinTu5.transform.position = position;
                break;
            case 22:
                position = new Vector3(x22, y22, Z);
                PinTu5.transform.position = position;
                break;
            case 23:
                position = new Vector3(x23, y23, Z);
                PinTu5.transform.position = position;
                break;
            case 24:
                position = new Vector3(x24, y24, Z);
                PinTu5.transform.position = position;
                break;
            case 25:
                position = new Vector3(x25, y25, Z);
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
            case 17:
                position = new Vector3(x17, y17, Z);
                PinTu6.transform.position = position;
                break;
            case 18:
                position = new Vector3(x18, y18, Z);
                PinTu6.transform.position = position;
                break;
            case 19:
                position = new Vector3(x19, y19, Z);
                PinTu6.transform.position = position;
                break;
            case 20:
                position = new Vector3(x20, y20, Z);
                PinTu6.transform.position = position;
                break;
            case 21:
                position = new Vector3(x21, y21, Z);
                PinTu6.transform.position = position;
                break;
            case 22:
                position = new Vector3(x22, y22, Z);
                PinTu6.transform.position = position;
                break;
            case 23:
                position = new Vector3(x23, y23, Z);
                PinTu6.transform.position = position;
                break;
            case 24:
                position = new Vector3(x24, y24, Z);
                PinTu6.transform.position = position;
                break;
            case 25:
                position = new Vector3(x25, y25, Z);
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
            case 17:
                position = new Vector3(x17, y17, Z);
                PinTu7.transform.position = position;
                break;
            case 18:
                position = new Vector3(x18, y18, Z);
                PinTu7.transform.position = position;
                break;
            case 19:
                position = new Vector3(x19, y19, Z);
                PinTu7.transform.position = position;
                break;
            case 20:
                position = new Vector3(x20, y20, Z);
                PinTu7.transform.position = position;
                break;
            case 21:
                position = new Vector3(x21, y21, Z);
                PinTu7.transform.position = position;
                break;
            case 22:
                position = new Vector3(x22, y22, Z);
                PinTu7.transform.position = position;
                break;
            case 23:
                position = new Vector3(x23, y23, Z);
                PinTu7.transform.position = position;
                break;
            case 24:
                position = new Vector3(x24, y24, Z);
                PinTu7.transform.position = position;
                break;
            case 25:
                position = new Vector3(x25, y25, Z);
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
            case 17:
                position = new Vector3(x17, y17, Z);
                PinTu8.transform.position = position;
                break;
            case 18:
                position = new Vector3(x18, y18, Z);
                PinTu8.transform.position = position;
                break;
            case 19:
                position = new Vector3(x19, y19, Z);
                PinTu8.transform.position = position;
                break;
            case 20:
                position = new Vector3(x20, y20, Z);
                PinTu8.transform.position = position;
                break;
            case 21:
                position = new Vector3(x21, y21, Z);
                PinTu8.transform.position = position;
                break;
            case 22:
                position = new Vector3(x22, y22, Z);
                PinTu8.transform.position = position;
                break;
            case 23:
                position = new Vector3(x23, y23, Z);
                PinTu8.transform.position = position;
                break;
            case 24:
                position = new Vector3(x24, y24, Z);
                PinTu8.transform.position = position;
                break;
            case 25:
                position = new Vector3(x25, y25, Z);
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
            case 17:
                position = new Vector3(x17, y17, Z);
                PinTu9.transform.position = position;
                break;
            case 18:
                position = new Vector3(x18, y18, Z);
                PinTu9.transform.position = position;
                break;
            case 19:
                position = new Vector3(x19, y19, Z);
                PinTu9.transform.position = position;
                break;
            case 20:
                position = new Vector3(x20, y20, Z);
                PinTu9.transform.position = position;
                break;
            case 21:
                position = new Vector3(x21, y21, Z);
                PinTu9.transform.position = position;
                break;
            case 22:
                position = new Vector3(x22, y22, Z);
                PinTu9.transform.position = position;
                break;
            case 23:
                position = new Vector3(x23, y23, Z);
                PinTu9.transform.position = position;
                break;
            case 24:
                position = new Vector3(x24, y24, Z);
                PinTu9.transform.position = position;
                break;
            case 25:
                position = new Vector3(x25, y25, Z);
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
            case 17:
                position = new Vector3(x17, y17, Z);
                PinTu10.transform.position = position;
                break;
            case 18:
                position = new Vector3(x18, y18, Z);
                PinTu10.transform.position = position;
                break;
            case 19:
                position = new Vector3(x19, y19, Z);
                PinTu10.transform.position = position;
                break;
            case 20:
                position = new Vector3(x20, y20, Z);
                PinTu10.transform.position = position;
                break;
            case 21:
                position = new Vector3(x21, y21, Z);
                PinTu10.transform.position = position;
                break;
            case 22:
                position = new Vector3(x22, y22, Z);
                PinTu10.transform.position = position;
                break;
            case 23:
                position = new Vector3(x23, y23, Z);
                PinTu10.transform.position = position;
                break;
            case 24:
                position = new Vector3(x24, y24, Z);
                PinTu10.transform.position = position;
                break;
            case 25:
                position = new Vector3(x25, y25, Z);
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
            case 17:
                position = new Vector3(x17, y17, Z);
                PinTu11.transform.position = position;
                break;
            case 18:
                position = new Vector3(x18, y18, Z);
                PinTu11.transform.position = position;
                break;
            case 19:
                position = new Vector3(x19, y19, Z);
                PinTu11.transform.position = position;
                break;
            case 20:
                position = new Vector3(x20, y20, Z);
                PinTu11.transform.position = position;
                break;
            case 21:
                position = new Vector3(x21, y21, Z);
                PinTu11.transform.position = position;
                break;
            case 22:
                position = new Vector3(x22, y22, Z);
                PinTu11.transform.position = position;
                break;
            case 23:
                position = new Vector3(x23, y23, Z);
                PinTu11.transform.position = position;
                break;
            case 24:
                position = new Vector3(x24, y24, Z);
                PinTu11.transform.position = position;
                break;
            case 25:
                position = new Vector3(x25, y25, Z);
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
            case 17:
                position = new Vector3(x17, y17, Z);
                PinTu12.transform.position = position;
                break;
            case 18:
                position = new Vector3(x18, y18, Z);
                PinTu12.transform.position = position;
                break;
            case 19:
                position = new Vector3(x19, y19, Z);
                PinTu12.transform.position = position;
                break;
            case 20:
                position = new Vector3(x20, y20, Z);
                PinTu12.transform.position = position;
                break;
            case 21:
                position = new Vector3(x21, y21, Z);
                PinTu12.transform.position = position;
                break;
            case 22:
                position = new Vector3(x22, y22, Z);
                PinTu12.transform.position = position;
                break;
            case 23:
                position = new Vector3(x23, y23, Z);
                PinTu12.transform.position = position;
                break;
            case 24:
                position = new Vector3(x24, y24, Z);
                PinTu12.transform.position = position;
                break;
            case 25:
                position = new Vector3(x25, y25, Z);
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
            case 17:
                position = new Vector3(x17, y17, Z);
                PinTu13.transform.position = position;
                break;
            case 18:
                position = new Vector3(x18, y18, Z);
                PinTu13.transform.position = position;
                break;
            case 19:
                position = new Vector3(x19, y19, Z);
                PinTu13.transform.position = position;
                break;
            case 20:
                position = new Vector3(x20, y20, Z);
                PinTu13.transform.position = position;
                break;
            case 21:
                position = new Vector3(x21, y21, Z);
                PinTu13.transform.position = position;
                break;
            case 22:
                position = new Vector3(x22, y22, Z);
                PinTu13.transform.position = position;
                break;
            case 23:
                position = new Vector3(x23, y23, Z);
                PinTu13.transform.position = position;
                break;
            case 24:
                position = new Vector3(x24, y24, Z);
                PinTu13.transform.position = position;
                break;
            case 25:
                position = new Vector3(x25, y25, Z);
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
            case 17:
                position = new Vector3(x17, y17, Z);
                PinTu14.transform.position = position;
                break;
            case 18:
                position = new Vector3(x18, y18, Z);
                PinTu14.transform.position = position;
                break;
            case 19:
                position = new Vector3(x19, y19, Z);
                PinTu14.transform.position = position;
                break;
            case 20:
                position = new Vector3(x20, y20, Z);
                PinTu14.transform.position = position;
                break;
            case 21:
                position = new Vector3(x21, y21, Z);
                PinTu14.transform.position = position;
                break;
            case 22:
                position = new Vector3(x22, y22, Z);
                PinTu14.transform.position = position;
                break;
            case 23:
                position = new Vector3(x23, y23, Z);
                PinTu14.transform.position = position;
                break;
            case 24:
                position = new Vector3(x24, y24, Z);
                PinTu14.transform.position = position;
                break;
            case 25:
                position = new Vector3(x25, y25, Z);
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
            case 17:
                position = new Vector3(x17, y17, Z);
                PinTu15.transform.position = position;
                break;
            case 18:
                position = new Vector3(x18, y18, Z);
                PinTu15.transform.position = position;
                break;
            case 19:
                position = new Vector3(x19, y19, Z);
                PinTu15.transform.position = position;
                break;
            case 20:
                position = new Vector3(x20, y20, Z);
                PinTu15.transform.position = position;
                break;
            case 21:
                position = new Vector3(x21, y21, Z);
                PinTu15.transform.position = position;
                break;
            case 22:
                position = new Vector3(x22, y22, Z);
                PinTu15.transform.position = position;
                break;
            case 23:
                position = new Vector3(x23, y23, Z);
                PinTu15.transform.position = position;
                break;
            case 24:
                position = new Vector3(x24, y24, Z);
                PinTu15.transform.position = position;
                break;
            case 25:
                position = new Vector3(x25, y25, Z);
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
            case 17:
                position = new Vector3(x17, y17, Z);
                PinTu16.transform.position = position;
                break;
            case 18:
                position = new Vector3(x18, y18, Z);
                PinTu16.transform.position = position;
                break;
            case 19:
                position = new Vector3(x19, y19, Z);
                PinTu16.transform.position = position;
                break;
            case 20:
                position = new Vector3(x20, y20, Z);
                PinTu16.transform.position = position;
                break;
            case 21:
                position = new Vector3(x21, y21, Z);
                PinTu16.transform.position = position;
                break;
            case 22:
                position = new Vector3(x22, y22, Z);
                PinTu16.transform.position = position;
                break;
            case 23:
                position = new Vector3(x23, y23, Z);
                PinTu16.transform.position = position;
                break;
            case 24:
                position = new Vector3(x24, y24, Z);
                PinTu16.transform.position = position;
                break;
            case 25:
                position = new Vector3(x25, y25, Z);
                PinTu16.transform.position = position;
                break;
        }

        switch (P17)
        {
            case 1:
                Vector3 position = new Vector3(x1, y1, Z);
                PinTu17.transform.position = position;
                break;
            case 2:
                position = new Vector3(x2, y2, Z);
                PinTu17.transform.position = position;
                break;
            case 3:
                position = new Vector3(x3, y3, Z);
                PinTu17.transform.position = position;
                break;
            case 4:
                position = new Vector3(x4, y4, Z);
                PinTu17.transform.position = position;
                break;
            case 5:
                position = new Vector3(x5, y5, Z);
                PinTu17.transform.position = position;
                break;
            case 6:
                position = new Vector3(x6, y6, Z);
                PinTu17.transform.position = position;
                break;
            case 7:
                position = new Vector3(x7, y7, Z);
                PinTu17.transform.position = position;
                break;
            case 8:
                position = new Vector3(x8, y8, Z);
                PinTu17.transform.position = position;
                break;
            case 9:
                position = new Vector3(x9, y9, Z);
                PinTu17.transform.position = position;
                break;
            case 10:
                position = new Vector3(x10, y10, Z);
                PinTu17.transform.position = position;
                break;
            case 11:
                position = new Vector3(x11, y11, Z);
                PinTu17.transform.position = position;
                break;
            case 12:
                position = new Vector3(x12, y12, Z);
                PinTu17.transform.position = position;
                break;
            case 13:
                position = new Vector3(x13, y13, Z);
                PinTu17.transform.position = position;
                break;
            case 14:
                position = new Vector3(x14, y14, Z);
                PinTu17.transform.position = position;
                break;
            case 15:
                position = new Vector3(x15, y15, Z);
                PinTu17.transform.position = position;
                break;
            case 16:
                position = new Vector3(x16, y16, Z);
                PinTu17.transform.position = position;
                break;
            case 17:
                position = new Vector3(x17, y17, Z);
                PinTu17.transform.position = position;
                break;
            case 18:
                position = new Vector3(x18, y18, Z);
                PinTu17.transform.position = position;
                break;
            case 19:
                position = new Vector3(x19, y19, Z);
                PinTu17.transform.position = position;
                break;
            case 20:
                position = new Vector3(x20, y20, Z);
                PinTu17.transform.position = position;
                break;
            case 21:
                position = new Vector3(x21, y21, Z);
                PinTu17.transform.position = position;
                break;
            case 22:
                position = new Vector3(x22, y22, Z);
                PinTu17.transform.position = position;
                break;
            case 23:
                position = new Vector3(x23, y23, Z);
                PinTu17.transform.position = position;
                break;
            case 24:
                position = new Vector3(x24, y24, Z);
                PinTu17.transform.position = position;
                break;
            case 25:
                position = new Vector3(x25, y25, Z);
                PinTu17.transform.position = position;
                break;
        }

        switch (P18)
        {
            case 1:
                Vector3 position = new Vector3(x1, y1, Z);
                PinTu18.transform.position = position;
                break;
            case 2:
                position = new Vector3(x2, y2, Z);
                PinTu18.transform.position = position;
                break;
            case 3:
                position = new Vector3(x3, y3, Z);
                PinTu18.transform.position = position;
                break;
            case 4:
                position = new Vector3(x4, y4, Z);
                PinTu18.transform.position = position;
                break;
            case 5:
                position = new Vector3(x5, y5, Z);
                PinTu18.transform.position = position;
                break;
            case 6:
                position = new Vector3(x6, y6, Z);
                PinTu18.transform.position = position;
                break;
            case 7:
                position = new Vector3(x7, y7, Z);
                PinTu18.transform.position = position;
                break;
            case 8:
                position = new Vector3(x8, y8, Z);
                PinTu18.transform.position = position;
                break;
            case 9:
                position = new Vector3(x9, y9, Z);
                PinTu18.transform.position = position;
                break;
            case 10:
                position = new Vector3(x10, y10, Z);
                PinTu18.transform.position = position;
                break;
            case 11:
                position = new Vector3(x11, y11, Z);
                PinTu18.transform.position = position;
                break;
            case 12:
                position = new Vector3(x12, y12, Z);
                PinTu18.transform.position = position;
                break;
            case 13:
                position = new Vector3(x13, y13, Z);
                PinTu18.transform.position = position;
                break;
            case 14:
                position = new Vector3(x14, y14, Z);
                PinTu18.transform.position = position;
                break;
            case 15:
                position = new Vector3(x15, y15, Z);
                PinTu18.transform.position = position;
                break;
            case 16:
                position = new Vector3(x16, y16, Z);
                PinTu18.transform.position = position;
                break;
            case 17:
                position = new Vector3(x17, y17, Z);
                PinTu18.transform.position = position;
                break;
            case 18:
                position = new Vector3(x18, y18, Z);
                PinTu18.transform.position = position;
                break;
            case 19:
                position = new Vector3(x19, y19, Z);
                PinTu18.transform.position = position;
                break;
            case 20:
                position = new Vector3(x20, y20, Z);
                PinTu18.transform.position = position;
                break;
            case 21:
                position = new Vector3(x21, y21, Z);
                PinTu18.transform.position = position;
                break;
            case 22:
                position = new Vector3(x22, y22, Z);
                PinTu18.transform.position = position;
                break;
            case 23:
                position = new Vector3(x23, y23, Z);
                PinTu18.transform.position = position;
                break;
            case 24:
                position = new Vector3(x24, y24, Z);
                PinTu18.transform.position = position;
                break;
            case 25:
                position = new Vector3(x25, y25, Z);
                PinTu18.transform.position = position;
                break;
        }

        switch (P19)
        {
            case 1:
                Vector3 position = new Vector3(x1, y1, Z);
                PinTu19.transform.position = position;
                break;
            case 2:
                position = new Vector3(x2, y2, Z);
                PinTu19.transform.position = position;
                break;
            case 3:
                position = new Vector3(x3, y3, Z);
                PinTu19.transform.position = position;
                break;
            case 4:
                position = new Vector3(x4, y4, Z);
                PinTu19.transform.position = position;
                break;
            case 5:
                position = new Vector3(x5, y5, Z);
                PinTu19.transform.position = position;
                break;
            case 6:
                position = new Vector3(x6, y6, Z);
                PinTu19.transform.position = position;
                break;
            case 7:
                position = new Vector3(x7, y7, Z);
                PinTu19.transform.position = position;
                break;
            case 8:
                position = new Vector3(x8, y8, Z);
                PinTu19.transform.position = position;
                break;
            case 9:
                position = new Vector3(x9, y9, Z);
                PinTu19.transform.position = position;
                break;
            case 10:
                position = new Vector3(x10, y10, Z);
                PinTu19.transform.position = position;
                break;
            case 11:
                position = new Vector3(x11, y11, Z);
                PinTu19.transform.position = position;
                break;
            case 12:
                position = new Vector3(x12, y12, Z);
                PinTu19.transform.position = position;
                break;
            case 13:
                position = new Vector3(x13, y13, Z);
                PinTu19.transform.position = position;
                break;
            case 14:
                position = new Vector3(x14, y14, Z);
                PinTu19.transform.position = position;
                break;
            case 15:
                position = new Vector3(x15, y15, Z);
                PinTu19.transform.position = position;
                break;
            case 16:
                position = new Vector3(x16, y16, Z);
                PinTu19.transform.position = position;
                break;
            case 17:
                position = new Vector3(x17, y17, Z);
                PinTu19.transform.position = position;
                break;
            case 18:
                position = new Vector3(x18, y18, Z);
                PinTu19.transform.position = position;
                break;
            case 19:
                position = new Vector3(x19, y19, Z);
                PinTu19.transform.position = position;
                break;
            case 20:
                position = new Vector3(x20, y20, Z);
                PinTu19.transform.position = position;
                break;
            case 21:
                position = new Vector3(x21, y21, Z);
                PinTu19.transform.position = position;
                break;
            case 22:
                position = new Vector3(x22, y22, Z);
                PinTu19.transform.position = position;
                break;
            case 23:
                position = new Vector3(x23, y23, Z);
                PinTu19.transform.position = position;
                break;
            case 24:
                position = new Vector3(x24, y24, Z);
                PinTu19.transform.position = position;
                break;
            case 25:
                position = new Vector3(x25, y25, Z);
                PinTu19.transform.position = position;
                break;
        }

        switch (P20)
        {
            case 1:
                Vector3 position = new Vector3(x1, y1, Z);
                PinTu20.transform.position = position;
                break;
            case 2:
                position = new Vector3(x2, y2, Z);
                PinTu20.transform.position = position;
                break;
            case 3:
                position = new Vector3(x3, y3, Z);
                PinTu20.transform.position = position;
                break;
            case 4:
                position = new Vector3(x4, y4, Z);
                PinTu20.transform.position = position;
                break;
            case 5:
                position = new Vector3(x5, y5, Z);
                PinTu20.transform.position = position;
                break;
            case 6:
                position = new Vector3(x6, y6, Z);
                PinTu20.transform.position = position;
                break;
            case 7:
                position = new Vector3(x7, y7, Z);
                PinTu20.transform.position = position;
                break;
            case 8:
                position = new Vector3(x8, y8, Z);
                PinTu20.transform.position = position;
                break;
            case 9:
                position = new Vector3(x9, y9, Z);
                PinTu20.transform.position = position;
                break;
            case 10:
                position = new Vector3(x10, y10, Z);
                PinTu20.transform.position = position;
                break;
            case 11:
                position = new Vector3(x11, y11, Z);
                PinTu20.transform.position = position;
                break;
            case 12:
                position = new Vector3(x12, y12, Z);
                PinTu20.transform.position = position;
                break;
            case 13:
                position = new Vector3(x13, y13, Z);
                PinTu20.transform.position = position;
                break;
            case 14:
                position = new Vector3(x14, y14, Z);
                PinTu20.transform.position = position;
                break;
            case 15:
                position = new Vector3(x15, y15, Z);
                PinTu20.transform.position = position;
                break;
            case 16:
                position = new Vector3(x16, y16, Z);
                PinTu20.transform.position = position;
                break;
            case 17:
                position = new Vector3(x17, y17, Z);
                PinTu20.transform.position = position;
                break;
            case 18:
                position = new Vector3(x18, y18, Z);
                PinTu20.transform.position = position;
                break;
            case 19:
                position = new Vector3(x19, y19, Z);
                PinTu20.transform.position = position;
                break;
            case 20:
                position = new Vector3(x20, y20, Z);
                PinTu20.transform.position = position;
                break;
            case 21:
                position = new Vector3(x21, y21, Z);
                PinTu20.transform.position = position;
                break;
            case 22:
                position = new Vector3(x22, y22, Z);
                PinTu20.transform.position = position;
                break;
            case 23:
                position = new Vector3(x23, y23, Z);
                PinTu20.transform.position = position;
                break;
            case 24:
                position = new Vector3(x24, y24, Z);
                PinTu20.transform.position = position;
                break;
            case 25:
                position = new Vector3(x25, y25, Z);
                PinTu20.transform.position = position;
                break;
        }

        switch (P21)
        {
            case 1:
                Vector3 position = new Vector3(x1, y1, Z);
                PinTu21.transform.position = position;
                break;
            case 2:
                position = new Vector3(x2, y2, Z);
                PinTu21.transform.position = position;
                break;
            case 3:
                position = new Vector3(x3, y3, Z);
                PinTu21.transform.position = position;
                break;
            case 4:
                position = new Vector3(x4, y4, Z);
                PinTu21.transform.position = position;
                break;
            case 5:
                position = new Vector3(x5, y5, Z);
                PinTu21.transform.position = position;
                break;
            case 6:
                position = new Vector3(x6, y6, Z);
                PinTu21.transform.position = position;
                break;
            case 7:
                position = new Vector3(x7, y7, Z);
                PinTu21.transform.position = position;
                break;
            case 8:
                position = new Vector3(x8, y8, Z);
                PinTu21.transform.position = position;
                break;
            case 9:
                position = new Vector3(x9, y9, Z);
                PinTu21.transform.position = position;
                break;
            case 10:
                position = new Vector3(x10, y10, Z);
                PinTu21.transform.position = position;
                break;
            case 11:
                position = new Vector3(x11, y11, Z);
                PinTu21.transform.position = position;
                break;
            case 12:
                position = new Vector3(x12, y12, Z);
                PinTu21.transform.position = position;
                break;
            case 13:
                position = new Vector3(x13, y13, Z);
                PinTu21.transform.position = position;
                break;
            case 14:
                position = new Vector3(x14, y14, Z);
                PinTu21.transform.position = position;
                break;
            case 15:
                position = new Vector3(x15, y15, Z);
                PinTu21.transform.position = position;
                break;
            case 16:
                position = new Vector3(x16, y16, Z);
                PinTu21.transform.position = position;
                break;
            case 17:
                position = new Vector3(x17, y17, Z);
                PinTu21.transform.position = position;
                break;
            case 18:
                position = new Vector3(x18, y18, Z);
                PinTu21.transform.position = position;
                break;
            case 19:
                position = new Vector3(x19, y19, Z);
                PinTu21.transform.position = position;
                break;
            case 20:
                position = new Vector3(x20, y20, Z);
                PinTu21.transform.position = position;
                break;
            case 21:
                position = new Vector3(x21, y21, Z);
                PinTu21.transform.position = position;
                break;
            case 22:
                position = new Vector3(x22, y22, Z);
                PinTu21.transform.position = position;
                break;
            case 23:
                position = new Vector3(x23, y23, Z);
                PinTu21.transform.position = position;
                break;
            case 24:
                position = new Vector3(x24, y24, Z);
                PinTu21.transform.position = position;
                break;
            case 25:
                position = new Vector3(x25, y25, Z);
                PinTu21.transform.position = position;
                break;
        }

        switch (P22)
        {
            case 1:
                Vector3 position = new Vector3(x1, y1, Z);
                PinTu22.transform.position = position;
                break;
            case 2:
                position = new Vector3(x2, y2, Z);
                PinTu22.transform.position = position;
                break;
            case 3:
                position = new Vector3(x3, y3, Z);
                PinTu22.transform.position = position;
                break;
            case 4:
                position = new Vector3(x4, y4, Z);
                PinTu22.transform.position = position;
                break;
            case 5:
                position = new Vector3(x5, y5, Z);
                PinTu22.transform.position = position;
                break;
            case 6:
                position = new Vector3(x6, y6, Z);
                PinTu22.transform.position = position;
                break;
            case 7:
                position = new Vector3(x7, y7, Z);
                PinTu22.transform.position = position;
                break;
            case 8:
                position = new Vector3(x8, y8, Z);
                PinTu22.transform.position = position;
                break;
            case 9:
                position = new Vector3(x9, y9, Z);
                PinTu22.transform.position = position;
                break;
            case 10:
                position = new Vector3(x10, y10, Z);
                PinTu22.transform.position = position;
                break;
            case 11:
                position = new Vector3(x11, y11, Z);
                PinTu22.transform.position = position;
                break;
            case 12:
                position = new Vector3(x12, y12, Z);
                PinTu22.transform.position = position;
                break;
            case 13:
                position = new Vector3(x13, y13, Z);
                PinTu22.transform.position = position;
                break;
            case 14:
                position = new Vector3(x14, y14, Z);
                PinTu22.transform.position = position;
                break;
            case 15:
                position = new Vector3(x15, y15, Z);
                PinTu22.transform.position = position;
                break;
            case 16:
                position = new Vector3(x16, y16, Z);
                PinTu22.transform.position = position;
                break;
            case 17:
                position = new Vector3(x17, y17, Z);
                PinTu22.transform.position = position;
                break;
            case 18:
                position = new Vector3(x18, y18, Z);
                PinTu22.transform.position = position;
                break;
            case 19:
                position = new Vector3(x19, y19, Z);
                PinTu22.transform.position = position;
                break;
            case 20:
                position = new Vector3(x20, y20, Z);
                PinTu22.transform.position = position;
                break;
            case 21:
                position = new Vector3(x21, y21, Z);
                PinTu22.transform.position = position;
                break;
            case 22:
                position = new Vector3(x22, y22, Z);
                PinTu22.transform.position = position;
                break;
            case 23:
                position = new Vector3(x23, y23, Z);
                PinTu22.transform.position = position;
                break;
            case 24:
                position = new Vector3(x24, y24, Z);
                PinTu22.transform.position = position;
                break;
            case 25:
                position = new Vector3(x25, y25, Z);
                PinTu22.transform.position = position;
                break;
        }

        switch (P23)
        {
            case 1:
                Vector3 position = new Vector3(x1, y1, Z);
                PinTu23.transform.position = position;
                break;
            case 2:
                position = new Vector3(x2, y2, Z);
                PinTu23.transform.position = position;
                break;
            case 3:
                position = new Vector3(x3, y3, Z);
                PinTu23.transform.position = position;
                break;
            case 4:
                position = new Vector3(x4, y4, Z);
                PinTu23.transform.position = position;
                break;
            case 5:
                position = new Vector3(x5, y5, Z);
                PinTu23.transform.position = position;
                break;
            case 6:
                position = new Vector3(x6, y6, Z);
                PinTu23.transform.position = position;
                break;
            case 7:
                position = new Vector3(x7, y7, Z);
                PinTu23.transform.position = position;
                break;
            case 8:
                position = new Vector3(x8, y8, Z);
                PinTu23.transform.position = position;
                break;
            case 9:
                position = new Vector3(x9, y9, Z);
                PinTu23.transform.position = position;
                break;
            case 10:
                position = new Vector3(x10, y10, Z);
                PinTu23.transform.position = position;
                break;
            case 11:
                position = new Vector3(x11, y11, Z);
                PinTu23.transform.position = position;
                break;
            case 12:
                position = new Vector3(x12, y12, Z);
                PinTu23.transform.position = position;
                break;
            case 13:
                position = new Vector3(x13, y13, Z);
                PinTu23.transform.position = position;
                break;
            case 14:
                position = new Vector3(x14, y14, Z);
                PinTu23.transform.position = position;
                break;
            case 15:
                position = new Vector3(x15, y15, Z);
                PinTu23.transform.position = position;
                break;
            case 16:
                position = new Vector3(x16, y16, Z);
                PinTu23.transform.position = position;
                break;
            case 17:
                position = new Vector3(x17, y17, Z);
                PinTu23.transform.position = position;
                break;
            case 18:
                position = new Vector3(x18, y18, Z);
                PinTu23.transform.position = position;
                break;
            case 19:
                position = new Vector3(x19, y19, Z);
                PinTu23.transform.position = position;
                break;
            case 20:
                position = new Vector3(x20, y20, Z);
                PinTu23.transform.position = position;
                break;
            case 21:
                position = new Vector3(x21, y21, Z);
                PinTu23.transform.position = position;
                break;
            case 22:
                position = new Vector3(x22, y22, Z);
                PinTu23.transform.position = position;
                break;
            case 23:
                position = new Vector3(x23, y23, Z);
                PinTu23.transform.position = position;
                break;
            case 24:
                position = new Vector3(x24, y24, Z);
                PinTu23.transform.position = position;
                break;
            case 25:
                position = new Vector3(x25, y25, Z);
                PinTu23.transform.position = position;
                break;
        }

        switch (P24)
        {
            case 1:
                Vector3 position = new Vector3(x1, y1, Z);
                PinTu24.transform.position = position;
                break;
            case 2:
                position = new Vector3(x2, y2, Z);
                PinTu24.transform.position = position;
                break;
            case 3:
                position = new Vector3(x3, y3, Z);
                PinTu24.transform.position = position;
                break;
            case 4:
                position = new Vector3(x4, y4, Z);
                PinTu24.transform.position = position;
                break;
            case 5:
                position = new Vector3(x5, y5, Z);
                PinTu24.transform.position = position;
                break;
            case 6:
                position = new Vector3(x6, y6, Z);
                PinTu24.transform.position = position;
                break;
            case 7:
                position = new Vector3(x7, y7, Z);
                PinTu24.transform.position = position;
                break;
            case 8:
                position = new Vector3(x8, y8, Z);
                PinTu24.transform.position = position;
                break;
            case 9:
                position = new Vector3(x9, y9, Z);
                PinTu24.transform.position = position;
                break;
            case 10:
                position = new Vector3(x10, y10, Z);
                PinTu24.transform.position = position;
                break;
            case 11:
                position = new Vector3(x11, y11, Z);
                PinTu24.transform.position = position;
                break;
            case 12:
                position = new Vector3(x12, y12, Z);
                PinTu24.transform.position = position;
                break;
            case 13:
                position = new Vector3(x13, y13, Z);
                PinTu24.transform.position = position;
                break;
            case 14:
                position = new Vector3(x14, y14, Z);
                PinTu24.transform.position = position;
                break;
            case 15:
                position = new Vector3(x15, y15, Z);
                PinTu24.transform.position = position;
                break;
            case 16:
                position = new Vector3(x16, y16, Z);
                PinTu24.transform.position = position;
                break;
            case 17:
                position = new Vector3(x17, y17, Z);
                PinTu24.transform.position = position;
                break;
            case 18:
                position = new Vector3(x18, y18, Z);
                PinTu24.transform.position = position;
                break;
            case 19:
                position = new Vector3(x19, y19, Z);
                PinTu24.transform.position = position;
                break;
            case 20:
                position = new Vector3(x20, y20, Z);
                PinTu24.transform.position = position;
                break;
            case 21:
                position = new Vector3(x21, y21, Z);
                PinTu24.transform.position = position;
                break;
            case 22:
                position = new Vector3(x22, y22, Z);
                PinTu24.transform.position = position;
                break;
            case 23:
                position = new Vector3(x23, y23, Z);
                PinTu24.transform.position = position;
                break;
            case 24:
                position = new Vector3(x24, y24, Z);
                PinTu24.transform.position = position;
                break;
            case 25:
                position = new Vector3(x25, y25, Z);
                PinTu24.transform.position = position;
                break;
        }

        switch (P25)
        {
            case 1:
                Vector3 position = new Vector3(x1, y1, Z);
                PinTu25.transform.position = position;
                break;
            case 2:
                position = new Vector3(x2, y2, Z);
                PinTu25.transform.position = position;
                break;
            case 3:
                position = new Vector3(x3, y3, Z);
                PinTu25.transform.position = position;
                break;
            case 4:
                position = new Vector3(x4, y4, Z);
                PinTu25.transform.position = position;
                break;
            case 5:
                position = new Vector3(x5, y5, Z);
                PinTu25.transform.position = position;
                break;
            case 6:
                position = new Vector3(x6, y6, Z);
                PinTu25.transform.position = position;
                break;
            case 7:
                position = new Vector3(x7, y7, Z);
                PinTu25.transform.position = position;
                break;
            case 8:
                position = new Vector3(x8, y8, Z);
                PinTu25.transform.position = position;
                break;
            case 9:
                position = new Vector3(x9, y9, Z);
                PinTu25.transform.position = position;
                break;
            case 10:
                position = new Vector3(x10, y10, Z);
                PinTu25.transform.position = position;
                break;
            case 11:
                position = new Vector3(x11, y11, Z);
                PinTu25.transform.position = position;
                break;
            case 12:
                position = new Vector3(x12, y12, Z);
                PinTu25.transform.position = position;
                break;
            case 13:
                position = new Vector3(x13, y13, Z);
                PinTu25.transform.position = position;
                break;
            case 14:
                position = new Vector3(x14, y14, Z);
                PinTu25.transform.position = position;
                break;
            case 15:
                position = new Vector3(x15, y15, Z);
                PinTu25.transform.position = position;
                break;
            case 16:
                position = new Vector3(x16, y16, Z);
                PinTu25.transform.position = position;
                break;
            case 17:
                position = new Vector3(x17, y17, Z);
                PinTu25.transform.position = position;
                break;
            case 18:
                position = new Vector3(x18, y18, Z);
                PinTu25.transform.position = position;
                break;
            case 19:
                position = new Vector3(x19, y19, Z);
                PinTu25.transform.position = position;
                break;
            case 20:
                position = new Vector3(x20, y20, Z);
                PinTu25.transform.position = position;
                break;
            case 21:
                position = new Vector3(x21, y21, Z);
                PinTu25.transform.position = position;
                break;
            case 22:
                position = new Vector3(x22, y22, Z);
                PinTu25.transform.position = position;
                break;
            case 23:
                position = new Vector3(x23, y23, Z);
                PinTu25.transform.position = position;
                break;
            case 24:
                position = new Vector3(x24, y24, Z);
                PinTu25.transform.position = position;
                break;
            case 25:
                position = new Vector3(x25, y25, Z);
                PinTu25.transform.position = position;
                break;
        }
    }
}
