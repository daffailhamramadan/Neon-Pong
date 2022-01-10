using UnityEngine;

public class PaddleInput : MonoBehaviour
{
    public float Vertical
    {
        get;

        private set;
    }

    private void Update()
    {
        Vertical = Input.GetAxis("Vertical");
    }
   
}
