using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction moveAction;
    public InputAction fireAction;
    private Vector2 _moveInput;
    public GameObject projectilePrefab;
    public float moveSpeed = 10.0f;
    public float rangeXBounds = 10.0f;
    void OnEnable()
    {    
        moveAction.Enable();
        fireAction.Enable();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Keep the player in bounds
        if (transform.position.x < -rangeXBounds)
        {
            transform.position = new Vector3(-rangeXBounds, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > rangeXBounds)
        {
            transform.position = new Vector3(rangeXBounds, transform.position.y, transform.position.z);
        }
        else
        {
            _moveInput = moveAction.ReadValue<Vector2>();
            transform.Translate(Vector3.right * (_moveInput.x * moveSpeed * Time.deltaTime));    
        }

        if (fireAction.triggered)
        {
            //Launch a projectile from the player
            GameObject projectile = Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
