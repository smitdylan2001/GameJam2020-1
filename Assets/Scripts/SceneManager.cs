using UnityEngine;

public class SceneManager : MonoBehaviour
{
    
    public void ChangeScene(int scene)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
    }

    public void quitApp()
    {
        Application.Quit();
    }
}
