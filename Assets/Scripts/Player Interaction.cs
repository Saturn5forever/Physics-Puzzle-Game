using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    public GameObject collidedWith;
    private bool inTrigger;

    void Start()
    {
        interactKey.Enable();
        inTrigger = false;
    }
    public InputAction interactKey;

    void Update()
    {
       Debug.Log("TRIGGER");
        if (interactKey.WasPressedThisFrame() && inTrigger == true)
        {
            Debug.Log("PRESSING KEY");
            switch (collidedWith.tag)
            {
                case "Lever":
                collidedWith.GetComponent<Lever>().Interact();
                break;

                default:
                break;
            } 
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        inTrigger = true;
        collidedWith = collision.gameObject;
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        inTrigger = false;
    }
}
