using System.IO.Compression;
using TMPro;
using UnityEngine;

public class PulsatingText : MonoBehaviour
{
    public float pulseSpeed = 45f;
    public float minSize = 45f;
    public float maxSize = 65f;

    public TextMeshProUGUI pulseText;
    private float textSize;
    private bool textIsLarge = false;

    void Start()
    {
        pulseText.fontSize = minSize;
    }

    void Update()
    {
        if (!textIsLarge)
        {
            textSize = Mathf.MoveTowards(pulseText.fontSize, maxSize, pulseSpeed * Time.deltaTime);
            pulseText.fontSize = textSize;

            if(pulseText.fontSize == maxSize)
            {
                textIsLarge = true;
            }
        }

        if (textIsLarge)
        {
            textSize = Mathf.MoveTowards(pulseText.fontSize, minSize, pulseSpeed * Time.deltaTime);
            pulseText.fontSize = textSize;

            if(pulseText.fontSize == minSize)
            {
                textIsLarge = false;
            }
        }
        
    }
}
