using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject relatedEffect;

    public void Interact()
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
