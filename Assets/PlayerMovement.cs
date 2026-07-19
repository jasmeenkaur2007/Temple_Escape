using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardSpeed = 6f;
    public float sideSpeed = 5f;

    void Update()
    {
        // Move forward
        transform.position += Vector3.forward * forwardSpeed * Time.deltaTime;

        // Move left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * sideSpeed * Time.deltaTime;
        }

        // Move right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * sideSpeed * Time.deltaTime;
        }
    }
}