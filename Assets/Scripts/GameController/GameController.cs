using UnityEngine;

public class GameController : MonoBehaviour
{
    [HideInInspector] public int PlayerScore;

    [HideInInspector] public int EnemyScore; 

    public enum GameState
    {
        Start,

        Play,

        GameOver
    }

    public GameState gameState;

    private void Start()
    {
        gameState = GameState.Start;

        if(gameState == GameState.Start)
        {
            Time.timeScale = 0f;
        }
    }

    private void Update()
    {
        if(gameState == GameState.Play)
        {
            Time.timeScale = 1f;
        }

        if (gameState == GameState.GameOver)
        {
            Time.timeScale = 0f;
        }

        if (PlayerScore == 10 || EnemyScore == 10)
        {
            gameState = GameState.GameOver;
        }
    }

    public void AddPlayerScore (int score)
    {
        PlayerScore += score;
    }

    public void AddEnemyScore(int score)
    {
        EnemyScore += score;
    }

}
