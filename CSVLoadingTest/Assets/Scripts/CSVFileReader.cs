using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class CSVFileReader : MonoBehaviour
{
    [SerializeField] TextAsset csvFile; // CSVƒtƒ@ƒCƒ‹
    private List<string[]> csvData = new List<string[]>();
    int i = 0;
    public TMP_Text NameText;
    public TMP_Text LogText;

    void Start()
    {
        StringReader reader = new StringReader(csvFile.text);

        while (reader.Peek() != -1)
        {
            string line = reader.ReadLine();
            csvData.Add(line.Split(','));
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            NameText.text = csvData[i][0];
            LogText.text = csvData[i][1];

            if (i < csvData.Count - 1) i++; 
        }
    }
}