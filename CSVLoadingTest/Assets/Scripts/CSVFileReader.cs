using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class CSVFileReader : MonoBehaviour
{
    [SerializeField] TextAsset csvFile; // CSVƒtƒ@ƒCƒ‹
    private List<string[]> csvData = new List<string[]>();
    int TextNum = 0;
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
            NameText.text = csvData[TextNum][0];
            LogText.text = csvData[TextNum][1];

            if (TextNum < csvData.Count - 1) TextNum++; 
        }
    }
}