using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject relatedEffect;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            relatedEffect.GetComponent<EffectActions>();
            ActivateEffects();
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
            relatedEffect.GetComponent<EffectActions>().SurroundingBoxLogic();
            break;
            
            default:
            break;
        }
    }
}
