using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject relatedEffect;
    public AudioClip pressurePlateSound;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            audioSource.PlayOneShot(pressurePlateSound);
            relatedEffect.GetComponent<EffectActions>();
            ActivateEffects();
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            relatedEffect.GetComponent<EffectActions>().ClosingDoorLogic();
        }
    }

    void ActivateEffects()
    {
        switch (relatedEffect.tag)
        {
            case "Door":
            relatedEffect.GetComponent<EffectActions>().DoorLogic();
            break;

            case "SurroundBox":
            if(relatedEffect != null)
            {
                relatedEffect.GetComponent<EffectActions>().SurroundingBoxLogic();
            }
            
            break;
            
            default:
            break;
        }
    }
}
