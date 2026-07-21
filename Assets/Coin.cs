using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource coinSound;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something entered: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player collected coin");

            ScoreManager.score++;

            Debug.Log("Score = " + ScoreManager.score);

            coinSound.Play();

            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;

            Destroy(gameObject, coinSound.clip.length);
        }
    }
}