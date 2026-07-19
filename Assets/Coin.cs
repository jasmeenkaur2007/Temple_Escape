using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something entered: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player collected coin");

            ScoreManager.score++;

            Debug.Log("Score = " + ScoreManager.score);

            Destroy(gameObject);
        }
    }
}