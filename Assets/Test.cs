using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // numを1で初期化する
        int num = 1;
        // valに代入する値を条件によって変える(三項演算子)
        int val = (num == 1) ? -100 : 100;
        // valの値を表示する
        Debug.Log(val);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
