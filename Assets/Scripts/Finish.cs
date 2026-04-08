using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{   public GameObject nextLevelButton;
    public GameObject restartButton;
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
        PlayerPrefs.SetInt(levelKey, levelComplete ? 0 : 1);
        PlayerPrefs.Save();
    }
    
    public void LoadLevelStatus()
    {
        string levelKey = "Level_" + SceneManager.GetActiveScene().buildIndex;

        levelComplete = PlayerPrefs.GetInt(levelKey, 0) == 1;
    }
}
