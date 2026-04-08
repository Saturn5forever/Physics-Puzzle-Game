using TMPro;
using UnityEngine;

public class LevelCompleteCheck : MonoBehaviour
{
    public string levelKey1 = "Level_1";
    public string levelKey2 = "Level_2";
    public string levelKey3 = "Level_3";
    public string levelKey4 = "Level_4";
    public string levelKey5 = "Level_5";

    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI text3;
    public TextMeshProUGUI text4;
    public TextMeshProUGUI text5;

    public TextMeshProUGUI allCompleteText;


    void Start()
    {
        text1.gameObject.SetActive(false);
        text2.gameObject.SetActive(false);
        text3.gameObject.SetActive(false);
        text4.gameObject.SetActive(false);
        text5.gameObject.SetActive(false);
        allCompleteText.gameObject.SetActive(false);
    }

    void Update()
    {
        if(PlayerPrefs.GetInt(levelKey1, 0) == 1)
        {
            text1.gameObject.SetActive(true);
        }
        if(PlayerPrefs.GetInt(levelKey2, 0) == 1)
        {
            text2.gameObject.SetActive(true);
        }
        if(PlayerPrefs.GetInt(levelKey3, 0) == 1)
        {
            text3.gameObject.SetActive(true);
        }
        if(PlayerPrefs.GetInt(levelKey4, 0) == 1)
        {
            text4.gameObject.SetActive(true);
        }
        if(PlayerPrefs.GetInt(levelKey5, 0) == 1)
        {
            text5.gameObject.SetActive(true);
        }
        if(PlayerPrefs.GetInt(levelKey1, 0) == 1 && PlayerPrefs.GetInt(levelKey2, 0) == 1 && PlayerPrefs.GetInt(levelKey3, 0) == 1 && PlayerPrefs.GetInt(levelKey4) == 1 && PlayerPrefs.GetInt(levelKey5) == 1)
        {
            allCompleteText.gameObject.SetActive(true);
        }
    }


}
