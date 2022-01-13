using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    private PaddleInput paddleInput;

    private float moveY;

    private void Awake()
    {
        paddleInput = GetComponent<PaddleInput>();
    }

    private void Update()
    {
        moveY = paddleInput.Vertical * speed * Time.deltaTime;

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -4.1f, 4.1f), 0f) + new Vector3(0, moveY);
    }
}
