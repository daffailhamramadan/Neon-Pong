using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    private PaddleInput paddleInput;

    private bool isPlay => GameController.instance.gameState == GameController.GameState.Play;

    private void Awake()
    {
        paddleInput = GetComponent<PaddleInput>();
    }

    private void Update()
    {
        float moveY = paddleInput.Vertical * speed * Time.deltaTime;
        float minMaxY = Mathf.Clamp(transform.position.y, -4.07f, 4.07f);

        if (isPlay)
        {
            transform.position = new Vector3(transform.position.x, minMaxY) + new Vector3(0, moveY);
        }

        
    }
}
