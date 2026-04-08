using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{   public Button nextLevelButton;
    public Button restartButton;
    public bool levelComplete;

    void Start()
    {
        nextLevelButton.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.SetActive(false);
            restartButton.gameObject.SetActive(true);
            nextLevelButton.gameObject.SetActive(true);
            SaveLevelStatus();
        }
    }

    void SaveLevelStatus()
    {
        string levelKey = "Level_" + SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt(levelKey, levelComplete ? 1 : 0);
        PlayerPrefs.Save();
    }
    
    void LoadLevelStatus()
    {
        string levelKey = "Level_" + SceneManager.GetActiveScene().buildIndex;

        levelComplete = PlayerPrefs.GetInt(levelKey, 0) == 1;
    }
}
