using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UiManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI[] scoreText;

    [SerializeField] private TextMeshProUGUI gameOverText;

    [SerializeField] private GameController gameController;

    [SerializeField] private GameObject restartButton;

    private void Update()
    {
        scoreText[0].text = gameController.PlayerScore.ToString();

        scoreText[1].text = gameController.EnemyScore.ToString();

        if (gameController.PlayerScore == 10)
        {
            gameOverText.text = "You Win!";
        }
        else if(gameController.EnemyScore == 10)
        {
            gameOverText.text = "You Lost!";
        }

        if(gameController.gameState == GameController.GameState.GameOver)
        {
            restartButton.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

}
