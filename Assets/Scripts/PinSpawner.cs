using UnityEngine;

public class PinSpawner : MonoBehaviour
{
    private GameObject pinPrefab;
    [SerializeField] private int numRows;
    [SerializeField] private float pinSpacing;
    [SerializeField] private int firstRowCount;
    [SerializeField] private Transform parent;

    public int NumRows => numRows;
    public float PinSpacing => pinSpacing;

    public int FirstRowCount => firstRowCount;

    void Awake()
    {
        pinPrefab = Resources.Load<GameObject>("Prefabs/Pin");
        SpawnPins();
    }

    void SpawnPins()
    {
        for (int row = 0; row < numRows; row++)
        {
            int pinsInRow = firstRowCount + row;
            
            float rowOffset = (pinsInRow - 1) * pinSpacing / 2;

            for (int i = 0; i < pinsInRow; i++)
            {
                float xPos = i * pinSpacing - rowOffset;
                float yPos = -row * pinSpacing * Mathf.Sqrt(3) / 2;

                Vector3 spawnPosition = new Vector2(xPos, yPos);
                Instantiate(
                    pinPrefab, 
                    spawnPosition, 
                    Quaternion.identity, 
                    parent);
            }
        }
    }
}