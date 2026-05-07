using UnityEngine;
using UnityEngine.SceneManagement;

public class levelhandler : MonoBehaviour
{
    public void level1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
