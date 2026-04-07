using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public InputAction moveKeys;
    public float moveSpeed;
    Vector2 moveDirection;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveKeys.Enable();
    }
    void FixedUpdate()
    {
        Vector2 moveDirectionRAW = moveKeys.ReadValue<Vector2>().normalized;
        moveDirection = (transform.right * moveDirectionRAW.x) + (transform.up * moveDirectionRAW.y);
        rb.linearVelocity = moveDirection * moveSpeed;

    }

    void Update()
    {
        
    }
}
