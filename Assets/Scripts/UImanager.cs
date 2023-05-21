using UnityEngine;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{
    [SerializeField] GameObject menuPanel;
    void Start()
    {
        menuPanel.SetActive(false);
    }

    public void MenuButton()
    {
        menuPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeButton()
    {
        menuPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void RetryButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("Lobby");
    }
}
