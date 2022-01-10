using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI[] scoreText;

    [SerializeField] private TextMeshProUGUI gameOverText;

    [SerializeField] private GameController gameController;

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
    }

}
