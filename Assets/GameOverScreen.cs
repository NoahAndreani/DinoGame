using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public GameObject gameOverPanel;
    public Button replayButton;

    void Start()
    {
        gameOverPanel.SetActive(false);
        replayButton.onClick.AddListener(RestartGame);
    }

    public void ShowGameOverScreen()
    {
        gameOverPanel.SetActive(true);
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Recharge la scène
    }
}