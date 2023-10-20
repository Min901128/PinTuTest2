using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchRandom : MonoBehaviour
{
    public GameObject Match1;
    public GameObject Match2;
    public GameObject Match3;
    public GameObject Match4;
    public GameObject Match5;
    public GameObject Match6;
    public GameObject Match7;
    public GameObject Match8;
    public GameObject Match9;
    public GameObject Match10;

    private Vector3[] originalPositions;

    private List<Vector3> PinTuPositions;

    void Start()
    {
        // 紀錄初始位置
        originalPositions = new Vector3[10];
        originalPositions[0] = Match1.transform.position;
        originalPositions[1] = Match2.transform.position;
        originalPositions[2] = Match3.transform.position;
        originalPositions[3] = Match4.transform.position;
        originalPositions[4] = Match5.transform.position;
        originalPositions[5] = Match6.transform.position;
        originalPositions[6] = Match7.transform.position;
        originalPositions[7] = Match8.transform.position;
        originalPositions[8] = Match9.transform.position;
        originalPositions[9] = Match10.transform.position;
        
        List<int> numbers = new List<int>(); // 宣告一個整數列表
        int count = 10;
        while (numbers.Count < count)
        {
            int number = Random.Range(0, count); // 生成0到10之間的亂數
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

        Match1.transform.position = originalPositions[P1];
        Match2.transform.position = originalPositions[P2];
        Match3.transform.position = originalPositions[P3];
        Match4.transform.position = originalPositions[P4];
        Match5.transform.position = originalPositions[P5];
        Match6.transform.position = originalPositions[P6];
        Match7.transform.position = originalPositions[P7];
        Match8.transform.position = originalPositions[P8];
        Match9.transform.position = originalPositions[P9];
        Match10.transform.position = originalPositions[P10];
    }
}