using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    private GameObject ballPrefab;
    [SerializeField] private Transform parent;

    [SerializeField] private float spawnWidth;
    [SerializeField] private float spawnHeight;

    private void Awake()
    {
        ballPrefab = Resources.Load<GameObject>("Prefabs/Ball");
    }

    public void SpawnBall()
    {
        float xPos = Random.Range(-spawnWidth, spawnWidth);
        Vector2 spawnPosition = new Vector2(xPos, spawnHeight);

        Instantiate(
            ballPrefab, 
            spawnPosition, 
            Quaternion.identity, 
            parent);
    }
}