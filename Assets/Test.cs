using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 配列を初期化する
        int[] points = {30, 20, 50, 10, 80, 15, 60, 100, 45, 150, 200, 1};

        // 配列の要素数のぶんだけ処理を繰り返す
        for (int i = 0; i < points.Length; i++)
        {
            // 配列の要素が50以上の場合
            if (points[i] >= 50)
            {
                // 配列の要素を表示する
                Debug.Log(points[i]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
