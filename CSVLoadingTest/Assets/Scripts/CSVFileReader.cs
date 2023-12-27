using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CSVFileReader : MonoBehaviour
{
    [SerializeField] TextAsset csvFile; // CSV�t�@�C��
    private List<string[]> csvData = new List<string[]>(); // CSV�t�@�C���̒��g�����郊�X�g
    const int FirstReaderNum = 1;
    int TextCount = 0;

    void Start()
    {
        StringReader reader = new StringReader(csvFile.text); // TextAsset��StringReader�ɕϊ�

        while (reader.Peek() != -1)
        {
            string line = reader.ReadLine(); // 1�s���ǂݍ���
            csvData.Add(line.Split(',')); // csvData���X�g�ɒǉ�����
        }
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            TextCount++;

            // �f�[�^�̕\��
            Debug.Log("���{��F" + csvData[TextCount][0] + ", English�F" + csvData[TextCount][1]);
        }
    }
}
