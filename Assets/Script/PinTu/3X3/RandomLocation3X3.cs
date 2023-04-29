using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLocation3X3 : MonoBehaviour
{
    private float x1 = -0.35f, y1 = 0.15f, x2 = -0.2f, y2 = 0.15f, x3 = -0.35f, y3 = 0.0f;
    private float x4 = -0.2f, y4 = 0.0f, x5 = -0.2f, y5 = -0.15f, x6 = 0.35f, y6 = 0.15f;
    private float x7 = 0.5f, y7 = 0.15f, x8 = 0.35f, y8 = 0.0f, x9 = 0.5f, y9 = 0.0f; 
    private float Z = 1.0f;

    public GameObject PinTu1;
    public GameObject PinTu2;
    public GameObject PinTu3;
    public GameObject PinTu4;
    public GameObject PinTu5;
    public GameObject PinTu6;
    public GameObject PinTu7;
    public GameObject PinTu8;
    public GameObject PinTu9;

    void Start()
    {
        List<int> numbers = new List<int>(); // 宣告一個整數列表
        int count = 9;
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
        }
    }
}
