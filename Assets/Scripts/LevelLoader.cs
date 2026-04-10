using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public int levelIndex;

    public void LoadSelectedLevel()
    {
        SceneManager.LoadScene(levelIndex);
    }
}
