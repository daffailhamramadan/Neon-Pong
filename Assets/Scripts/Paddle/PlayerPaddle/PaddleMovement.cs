using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    private PaddleInput paddleInput;

    private void Awake()
    {
        paddleInput = GetComponent<PaddleInput>();
    }

    private void Update()
    {
        transform.position += new Vector3(0, paddleInput.Vertical * speed * Time.deltaTime);
    }
}
