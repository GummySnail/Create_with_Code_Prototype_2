using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private readonly float _topBound = 30;
    private readonly float _lowBound = -10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > _topBound || transform.position.z < _lowBound) {
            Debug.Log("Game Over");
            Destroy(gameObject); 
        }
    }
}
