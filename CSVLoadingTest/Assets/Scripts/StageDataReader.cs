using System.Collections.Generic;
using UnityEngine;

public class StageDataReader : MonoBehaviour
{
    [SerializeField] TextAsset StageDataFile;
    [SerializeField] GameObject[] StageBlocks;
    [SerializeField] int FieldHeight;

    enum StageCellNum
    {
        none,//0
        field,//1
        gimick//2
    }

    enum StageBlockNum
    {
        Field,//0
        Gimick//1
    }

    private void Start()
    {
        CreateField(StageDataFile.text, FieldHeight);

        //for (int i = 0; i < StageLayerNum; i++)
        //{
        //    CreateField(StageDataFile[i].text, FieldHeight[i]);
        //}
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

                Vector3 position = new(vertical, StageLayerHeight, beside);

                // セルの値に応じてオブジェクト生成
                if (cellValue == (int)StageCellNum.field)
                {
                    Instantiate(StageBlocks[(int)StageBlockNum.Field], position, Quaternion.identity);
                }
                if (cellValue == (int)StageCellNum.gimick)
                {
                    Instantiate(StageBlocks[(int)StageBlockNum.Gimick], position, Quaternion.identity);
                }

            }
        }
    }
}