using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // �uHello�v�ɑ����Ĉ����̕������\������֐�
    void HelloName (int number)
    {
        Debug.Log("Hello, " + number);
    }
    // Start is called before the first frame update
    void Start()
    {
        // HelloName�֐��ɁuUnity�v�Ƃ���������n��
        HelloName (50);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
