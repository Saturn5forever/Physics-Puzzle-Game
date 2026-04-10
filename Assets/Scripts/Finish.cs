using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{   public GameObject nextLevelButton;
    public GameObject restartButton;
    public bool levelComplete;

    public AudioClip finishSound;

    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        nextLevelButton.gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {            
            SaveLevelStatus();
            audioSource.PlayOneShot(finishSound);
            collision.gameObject.SetActive(false);
            nextLevelButton.gameObject.SetActive(true);

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
