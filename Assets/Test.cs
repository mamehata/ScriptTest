using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // �uHello�v�ɑ����Ĉ����̕������\������֐�
    void HelloName (string name)
    {
        Debug.Log("Hello, " + name);
    }
    // Start is called before the first frame update
    void Start()
    {
        // HelloName�֐��ɁuUnity�v�Ƃ���������n��
        HelloName ("Unity");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
