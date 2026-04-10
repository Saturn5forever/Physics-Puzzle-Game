using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public AudioClip restartSound;
    public AudioClip nextLevelSound;
    public AudioClip mainMenuSound;
    public AudioClip startGameSound;
    public AudioClip levelLoadingSceenSound;
    public AudioClip exitGameSound;

    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void NextLevel()
    {
        if(SceneManager.GetActiveScene().buildIndex + 1 < SceneManager.sceneCountInBuildSettings)
        {
            StartCoroutine(PlayNextLevel());  
        }
        else
        {
            StartCoroutine(PlayMainMenu());
        }  
    }

    public void RestartLevel()
    {
        StartCoroutine(PlayRestart());
    }

    public void LoadMainMenu()
    {
        StartCoroutine(PlayMainMenu());
    }

    public void StartGame()
    {
        StartCoroutine(PlayStart());
    }

    public void ExitGame()
    {
        StartCoroutine(PlayExitGame());
    }

    public void LoadLevelScene()
    {
        StartCoroutine(PlayLevelSelectScreen());
    }

    IEnumerator PlayNextLevel()
    {
        audioSource.PlayOneShot(nextLevelSound);

        yield return new WaitWhile(() => audioSource.isPlaying);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator PlayRestart()
    {
        audioSource.PlayOneShot(restartSound);

        yield return new WaitWhile(() => audioSource.isPlaying);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator PlayMainMenu()
    {
        audioSource.PlayOneShot(mainMenuSound);

        yield return new WaitWhile(() => audioSource.isPlaying);

        SceneManager.LoadScene(0);
    }

    IEnumerator PlayStart()
    {
        audioSource.PlayOneShot(startGameSound);

        yield return new WaitWhile(() => audioSource.isPlaying);

        SceneManager.LoadScene(2);
    }

    IEnumerator PlayLevelSelectScreen()
    {
        audioSource.PlayOneShot(levelLoadingSceenSound);

        yield return new WaitWhile(() => audioSource.isPlaying);

        SceneManager.LoadScene(1);
    }

    IEnumerator PlayExitGame()
    {
        audioSource.PlayOneShot(exitGameSound);

        yield return new WaitWhile(() => audioSource.isPlaying);

        Application.Quit();

        #if UNITY_EDITOR
        EditorApplication.isPlaying = false;
        #endif
    }
}
