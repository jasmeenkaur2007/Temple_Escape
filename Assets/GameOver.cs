using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit: " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}