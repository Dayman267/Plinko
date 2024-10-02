using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    private GameObject targetPrefab;
    [SerializeField] private Transform parent;
    [SerializeField] private PinSpawner pinSpawner;  

    private void Awake()
    {
        targetPrefab = Resources.Load<GameObject>("Prefabs/Target");
        
        SpawnTargets();
    }

    private void SpawnTargets()
    {
        int numRows = pinSpawner.NumRows;
        float pinSpacing = pinSpawner.PinSpacing;
        int firstRowCount = pinSpawner.FirstRowCount;
        
        int numTargets = firstRowCount + numRows;
        float totalWidth = (numTargets - 1) * pinSpacing;
        float startXPos = -totalWidth / 2;
        float spawnHeight = -(Mathf.Sqrt(3f/4f*Mathf.Pow(pinSpacing, 2)) * numRows);

        for (int i = 0; i < numTargets; i++)
        {
            float xPos = startXPos + i * pinSpacing;
            Vector2 spawnPosition = new Vector2(xPos, spawnHeight);

            Instantiate(
                targetPrefab, 
                spawnPosition, 
                Quaternion.identity, 
                parent);
        }
    }
}