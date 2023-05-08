using Assets.Scripts;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public GameObject panel;
    public static bool isPaused = false;
    private void Start()
    {
        isPaused = false;
    }
    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
            if(isPaused)
                ResumeGame();
            else
                PauseGame();
    }
    public void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.Confined;
        panel.SetActive(true);
        foreach (Transform child in panel.transform)
            child.gameObject.SetActive(false);
        panel.transform.GetChild(0)?.gameObject.SetActive(true);
        panel.transform.GetChild(1)?.gameObject.SetActive(true);
    }

    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        panel.SetActive(false);
        if(CfgManagement.mouseSensitivity != 0)
            MouseLook.mouseSens = CfgManagement.mouseSensitivity * 700;
    }

    public void ExitToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene((int)Scenes.Menu);
    }
}
