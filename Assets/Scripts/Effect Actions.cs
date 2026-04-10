using UnityEngine;

public class EffectActions : MonoBehaviour
{
    public void DoorLogic()
    {
        Debug.Log("D.O.O.R.");
        transform.GetChild(0).localPosition = new Vector3 (-2.5f, 0f, 0f);
        transform.GetChild(1).localPosition = new Vector3 (2.5f, 0f, 0f);
    }

    public void ClosingDoorLogic()
    {
        Debug.Log("C.L.O.S.I.N.G. D.O.O.R.");
        transform.GetChild(0).localPosition = new Vector3 (-1.1608f, 0f, 0f);
        transform.GetChild(1).localPosition = new Vector3 (1.1608f, 0f, 0f);
    }

    public void SurroundingBoxLogic()
    {
        Debug.Log("S.U.R.R.O.U.N.D.I.N.G. B.O.X.");
        if(gameObject != null)
        {
            Destroy(gameObject);
        }
        
    }

}
