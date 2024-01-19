using System;
using System.Collections.Generic;
using UnityEngine;

public class StageDataReader : MonoBehaviour
{
    [SerializeField] TextAsset StageDataFile;
    [SerializeField] GameObject FieldBlock;
    [SerializeField] GameObject GimickBlock;
    [SerializeField] int FieldHeight;

    //readonly List<int> FieldCnt = new List<int> { 0, 1, 2, 3, 4 };

    private void Start()
    {
        CreateField(StageDataFile.text, FieldHeight);
    }

    void CreateField(string csvText, int StageLayerHeight)
    {
        string[] rows = csvText.Split('\n');

        for (int beside = 0; beside < rows.Length; beside++)
        {
            string[] cells = rows[beside].Split(',');

            for (int vertical = 0; vertical < cells.Length; vertical++)
            {
                int cellValue = int.Parse(cells[vertical]);

                Vector3 position = new Vector3(vertical, StageLayerHeight, beside);

                // セルの値に応じてオブジェクト生成
                if (cellValue == 1)
                {
                    Instantiate(FieldBlock, position, Quaternion.identity);
                }
                if (cellValue == 2)
                {
                    Instantiate(GimickBlock, position, Quaternion.identity);
                }

            }
        }
    }
}