using UnityEngine;
using UnityEngine.InputSystem;

public class WorldRotation : MonoBehaviour
{
    public InputAction worldRotationKey;
    public float rotationOffset = 90f;
    public float rotationSpeed = 90f;
    public GameObject player;

    void Start()
    {
        worldRotationKey.Enable();
    }
    void Update()
    {
        if (worldRotationKey.WasPressedThisFrame())
        {
            Debug.Log("Rotating World");
            transform.RotateAround(player.transform.position, transform.forward, rotationOffset);
        }
        
    }
}
