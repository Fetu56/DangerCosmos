using Assets.Scripts;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public GameObject panel;
    private void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            PauseGame();
            panel.SetActive(true);
        }
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        panel.SetActive(false);
    }

    public void ExitToMenu()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene((int)Scenes.Menu);
    }
}
