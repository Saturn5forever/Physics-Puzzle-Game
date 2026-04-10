using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public InputAction moveKeys;
    public float moveSpeed;
    Vector2 moveDirection;
    Rigidbody2D rb;

    public AudioClip hitSound;
    AudioSource audioSource;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveKeys.Enable();
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag != "Box")
        {
            audioSource.PlayOneShot(hitSound, Random.Range(0.3f, 1f));
        }
    }

    void FixedUpdate()
    {
        Vector2 moveDirectionRAW = moveKeys.ReadValue<Vector2>().normalized;
        moveDirection = new Vector2 (moveDirectionRAW.x, moveDirectionRAW.y);
        rb.linearVelocity = moveDirection * moveSpeed * Time.fixedDeltaTime * 100f;

    }
}
