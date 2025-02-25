using UnityEngine;

public class CactusMovement : MonoBehaviour
{
    public float initialSpeed = 3f;
    public float speedIncreaseRate = 0.1f;
    public float maxSpeed = 12f;
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
      
    }
    transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
   

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