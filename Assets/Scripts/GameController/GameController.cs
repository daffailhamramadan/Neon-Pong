using UnityEngine;

public class GameController : MonoBehaviour
{
    [HideInInspector] public int PlayerScore;

    [HideInInspector] public int EnemyScore; 

    public enum GameState
    {
        Play,

        GameOver
    }

    public GameState gameState;

    private void Start()
    {
        gameState = GameState.Play;

        if(gameState == GameState.Play)
        {
            Time.timeScale = 1f;
        }
    }

    private void Update()
    {
        if (PlayerScore == 10 || EnemyScore == 10)
        {
            gameState = GameState.GameOver;
        }

        if(gameState == GameState.GameOver)
        {
            Time.timeScale = 0f;
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
