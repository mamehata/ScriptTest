using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 変数aを3で初期化する
        int a = 3;
        if (a == 3)
        {
            // 5回処理を繰り返す
            for (int i = 0; i < 5; i++)
            {
                Debug.Log(i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
