using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // 第一引数と第二引数と第三引数の値を足した値を返す関数
    int Add (int a, int b, int c)
    {
        // 第一引数と第二引数と第三引数の値を足して、変数dに代入する
        int d = a + b + c;
        // 変数dを呼び出し元の関数に返す
        return d;
    }
    // Start is called before the first frame update
    void Start()
    {
        // Add関数に「3」と「6」と「8」の引数を渡し、返り値をnum変数に代入する
        int num = Add (3, 6, 8);
        // numを表示する
        Debug.Log(num);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
