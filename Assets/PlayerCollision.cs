using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameManager gameManager;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Hit: " + collision.gameObject.name);
            gameManager.GameOver();
        }
    }
}