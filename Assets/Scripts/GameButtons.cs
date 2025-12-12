using UnityEngine;
using UnityEngine.SceneManagement;

public class GameButtons : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void QuitButton()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void PlayAgainButton()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void NextButton()
    {
        SceneManager.LoadScene("IntroScene");
    }

}
