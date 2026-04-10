using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject relatedEffect;

    public AudioClip leverSound;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void Interact()
    {
        audioSource.PlayOneShot(leverSound);

        switch (relatedEffect.tag)
        {
            case "Door":
            relatedEffect.GetComponent<EffectActions>().DoorLogic();
            break;
        
            case "SurroundBox":
            relatedEffect.GetComponent<EffectActions>().SurroundingBoxLogic();
            break;

            default:
            break;

        }
    }
}
