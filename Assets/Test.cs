using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // �������Ƒ������Ƒ�O�����̒l�𑫂����l��Ԃ��֐�
    int Add (int a, int b, int c)
    {
        // �������Ƒ������Ƒ�O�����̒l�𑫂��āA�ϐ�d�ɑ������
        int d = a + b + c;
        // �ϐ�d���Ăяo�����̊֐��ɕԂ�
        return d;
    }
    // Start is called before the first frame update
    void Start()
    {
        // Add�֐��Ɂu3�v�Ɓu6�v�Ɓu8�v�̈�����n���A�Ԃ�l��num�ϐ��ɑ������
        int num = Add (3, 6, 8);
        // num��\������
        Debug.Log(num);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
