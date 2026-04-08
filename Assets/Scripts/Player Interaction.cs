using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    public GameObject collidedWith;
    private bool inTrigger;
    public TextMeshProUGUI interactText;

    void Start()
    {
        interactKey.Enable();
        inTrigger = false;
        interactText.text = "";
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

                case "Button":
                collidedWith.GetComponent<Button>().Interact();
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
        if(collision.gameObject.tag != "Plate")
        {
            interactText.text = "Interact";
        }
        
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        inTrigger = false;
        interactText.text = "";
        
    }
}
