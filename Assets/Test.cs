using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 要素数5の配列を初期化する
        string[] points = new string[5];

        // 配列の各要素に値を代入する
        points[0] = "あ";
        points[1] = "い";
        points[2] = "う";
        points[3] = "え";
        points[4] = "お";

        // 配列の要素をすべて表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
