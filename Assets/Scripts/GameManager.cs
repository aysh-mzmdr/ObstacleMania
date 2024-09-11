using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void NextLevelCaller(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
