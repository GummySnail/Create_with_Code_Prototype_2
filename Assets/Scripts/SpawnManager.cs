using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public InputAction spawnAction;
    private readonly float _spawnRangeX = 20;
    private readonly float _spawnPositionZ = 20;
    private readonly float _startDelay = 2.0f;
    private readonly float _spawnInterval = 1.5f;

    void OnEnable()
    {
        spawnAction.Enable();
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimal), _startDelay, _spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        float randomPositionX = Random.Range(-_spawnRangeX, _spawnRangeX);
        Vector3 animalSpawnPosition = new Vector3(randomPositionX, 0, _spawnPositionZ);
        Instantiate(animalPrefabs[animalIndex], animalSpawnPosition,  animalPrefabs[animalIndex].transform.rotation);
    }
}
