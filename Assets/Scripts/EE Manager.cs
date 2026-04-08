using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class EEManager : MonoBehaviour
{
    public InputAction key1;
    public InputAction key2;
    public InputAction key3;
    public InputAction key4;
    public InputAction key5;
    public InputAction key6;
    public InputAction key7;

    public TextMeshProUGUI EEText;

    void Start()
    {
        key1.Enable();
        key2.Enable();
        key3.Enable();
        key4.Enable();
        key5.Enable();
        key6.Enable();
        key7.Enable();

        EEText.gameObject.SetActive(false);
    }

    void Update()
    {
        if(key1.IsPressed() && key2.IsPressed() && key3.IsPressed() && key4.IsPressed() && key5.IsPressed() && key6.IsPressed() && key7.IsPressed())
        {
            EEText.gameObject.SetActive(true);
        }
    }
}
