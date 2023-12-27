using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CSVFileReader : MonoBehaviour
{
    [SerializeField] TextAsset csvFile; // CSVファイル
    private List<string[]> csvData = new List<string[]>(); // CSVファイルの中身を入れるリスト
    const int FirstReaderNum = 1;
    int TextCount = 0;

    void Start()
    {
        StringReader reader = new StringReader(csvFile.text); // TextAssetをStringReaderに変換

        while (reader.Peek() != -1)
        {
            string line = reader.ReadLine(); // 1行ずつ読み込む
            csvData.Add(line.Split(',')); // csvDataリストに追加する
        }
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            TextCount++;

            // データの表示
            Debug.Log("日本語：" + csvData[TextCount][0] + ", English：" + csvData[TextCount][1]);
        }
    }
}
