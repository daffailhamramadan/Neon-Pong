using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using DG.Tweening;

public class UiManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI[] scoreText;
    [SerializeField] private TextMeshProUGUI gameOverText;
    [SerializeField] private GameObject restartButton;
    [SerializeField] private TextMeshProUGUI startText;

    private bool GameOver => GameController.instance.gameState == GameController.GameState.GameOver;
    private bool Play => GameController.instance.gameState == GameController.GameState.Play;

    private void Start()
    {
        startText.DOFade(0, 0.5f).SetLoops(-1, LoopType.Yoyo);
    }

    private void Update()
    {
        scoreText[0].text = GameController.instance.PlayerScore.ToString();
        scoreText[1].text = GameController.instance.EnemyScore.ToString();

        if (GameController.instance.PlayerScore == 10)
        {
            gameOverText.text = "You Win!";
        }
        else if(GameController.instance.EnemyScore == 10)
        {
            gameOverText.text = "You Lost!";
        }

        if(GameOver)
        {
            restartButton.SetActive(true);
        }

        if(Play)
        {
            StartText();
        }

    }

    public void RestartButton()
    {
        SceneManager.LoadScene(0);
    }

    public void StartText()
    {
        startText.DOFade(0, 1).onComplete = () => startText.text = "";
    }

}
