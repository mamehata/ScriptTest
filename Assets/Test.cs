using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // �v�f��5�̔z�������������
        string[] points = new string[5];

        // �z��̊e�v�f�ɒl��������
        points[0] = "��";
        points[1] = "��";
        points[2] = "��";
        points[3] = "��";
        points[4] = "��";

        // �z��̗v�f�����ׂĕ\������
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
