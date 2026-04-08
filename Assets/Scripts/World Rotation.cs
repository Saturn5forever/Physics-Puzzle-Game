using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class WorldRotation : MonoBehaviour
{
    public InputAction worldRotationKey;
    public float rotationOffset = 90f;
    public float rotationSpeed = 30f;
    public GameObject player;
    public Transform pivotPoint;
    private bool shouldRotate;

    public float targetRotation;

    void Start()
    {
        worldRotationKey.Enable();
    }
    void Update()
    {
        if (worldRotationKey.WasPressedThisFrame())
        {
            shouldRotate = true;
            worldRotationKey.Disable();
            targetRotation = transform.eulerAngles.z + rotationOffset;
        }
        if (shouldRotate)
        {
            float angle = Mathf.MoveTowardsAngle(transform.eulerAngles.z, targetRotation, rotationSpeed * Time.deltaTime);
            transform.eulerAngles = new Vector3(0, 0, angle);

            if(angle == targetRotation)
            {
                shouldRotate = false;
                worldRotationKey.Enable();
            }


        }
        
    }  
}