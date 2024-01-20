using UnityEngine;

public class StageCreater : MonoBehaviour
{
    [SerializeField] GameObject[] FieldCreater;
    [SerializeField] int FieldLayerNum;
    Vector3 FieldCreaterPos = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        for(int FloorNum = 0; FloorNum < FieldLayerNum; FloorNum++)
        {
            var parent = this.transform;
            Instantiate(FieldCreater[FloorNum], FieldCreaterPos, Quaternion.identity, parent);
        }
    }
}
