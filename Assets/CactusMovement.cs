using UnityEngine;

public class CactusMovement : MonoBehaviour
{
    public float initialSpeed = 500f;
    public float speedIncreaseRate = 0.01f;
    public float maxSpeed = 500f;
    private float currentSpeed;
     private bool hasScored = false;

    void Start()
    {
        currentSpeed = initialSpeed;
    }

 void Update()
{
    if (currentSpeed < maxSpeed)
    {
        currentSpeed += speedIncreaseRate * Time.deltaTime;
        Debug.Log("Current Speed: " + currentSpeed);
    }
    transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
    Debug.Log("Position: " + transform.position);

    if (transform.position.x < -20)
    {
        Destroy(gameObject);
    }
    if (!hasScored && transform.position.x < Camera.main.transform.position.x - 4)
    {
        hasScored = true;
        FindObjectOfType<ScoreManager>().AddScore(1);
    }
}
}