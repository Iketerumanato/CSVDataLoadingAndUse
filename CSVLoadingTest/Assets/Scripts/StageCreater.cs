using UnityEngine;

public class StageCreater : MonoBehaviour
{
    [SerializeField] GameObject[] FieldCreater;
    [SerializeField] int FieldLayer;
    Vector3 FieldCreaterPos = new(0f, 0f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        for(int FloorNum = 0; FloorNum < FieldLayer; FloorNum++)
        {
            Instantiate(FieldCreater[FloorNum], FieldCreaterPos, Quaternion.identity);
        }
    }
}
