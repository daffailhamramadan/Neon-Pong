using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    public int PlayerScore;

    public int EnemyScore; 

    public enum GameState
    {
        Start,

        Play,

        GameOver
    }

    public GameState gameState;

    private bool isGameOver;

    private bool PlayerWin => PlayerScore == 10 && isGameOver == false;
    private bool EnemyWin => EnemyScore == 10 && isGameOver == false;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        gameState = GameState.Start;
    }

    private void Update()
    {
        if(Input.anyKeyDown && gameState == GameState.Start)
        {
            gameState = GameState.Play;
            BallSpawn.instance.InstantiateBall();
            AudioManager.instance.BackgroundMusic();
        }

        if(PlayerWin)
        {
            AudioManager.instance.PlayerWinSFX();
            isGameOver = true;
            gameState = GameState.GameOver;
        }
        else if (EnemyWin)
        {
            AudioManager.instance.PlayerWinSFX();
            isGameOver = true;
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
