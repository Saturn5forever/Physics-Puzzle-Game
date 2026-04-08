using UnityEngine;

public class Button : MonoBehaviour
{
    bool isOn;
    public GameObject relatedEffect;
    public void Interact()
    {
        switch (relatedEffect.tag)
        {
            case "Door":
            DoorLogic();
            break;

            default:
            break;
        }
    }

    void DoorLogic()
    {
        if(isOn == false)
        {
            relatedEffect.GetComponent<EffectActions>().DoorLogic();
            isOn = true;
        }
        else if(isOn == true)
        {
            relatedEffect.GetComponent<EffectActions>().ClosingDoorLogic();
            isOn = false;
        }
        

    }
}
