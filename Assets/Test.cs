using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // �z�������������
        int[] points = {30, 20, 50, 10, 80, 15, 60, 100, 45, 150, 200, 1};

        // �z��̗v�f���̂Ԃ񂾂��������J��Ԃ�
        for (int i = 0; i < points.Length; i++)
        {
            // �z��̗v�f��50�ȏ�̏ꍇ
            if (points[i] >= 50)
            {
                // �z��̗v�f��\������
                Debug.Log(points[i]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
