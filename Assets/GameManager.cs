using UnityEngine;


public class GameManager : MonoBehaviour
{
    public GameObject gameOverText;

    public void GameOver()
    {
        gameOverText.SetActive(true);
        Debug.Log("Game Over!");
    }
}
