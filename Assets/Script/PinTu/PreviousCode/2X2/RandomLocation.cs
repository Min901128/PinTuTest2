using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLocation : MonoBehaviour
{
    private float x1 = -0.3f, y1 = 0.2f, x2 = -0.3f, y2 = -0.1f, x3 = 0.4f, y3 = 0.2f, x4 = 0.4f, y4 = -0.1f, Z = 1.0f;
    public GameObject PinTu1;
    public GameObject PinTu2;
    public GameObject PinTu3;
    public GameObject PinTu4;

    void Start()
    {
        List<int> numbers = new List<int>(); // 宣告一個整數列表
        int count = 4;
        while (numbers.Count < count)
        {
            int number = Random.Range(1, count + 1); // 生成1到4之間的亂數
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
        }
    }
}
