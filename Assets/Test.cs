using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // 「Hello」に続けて引数の文字列を表示する関数
    void HelloName (int number)
    {
        Debug.Log("Hello, " + number);
    }
    // Start is called before the first frame update
    void Start()
    {
        // HelloName関数に「Unity」という引数を渡す
        HelloName (50);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
