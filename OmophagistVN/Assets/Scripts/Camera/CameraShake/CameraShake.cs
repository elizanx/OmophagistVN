using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public float moveStep = 1.0f; // Hoeveelheid dat de camera beweegt
    private bool moveLeft = false;

    void Update()
    {
        if (moveLeft)
        {
            transform.position += Vector3.left * moveStep * Time.deltaTime;
            moveLeft = false;
        }
    }

    public void MoveCameraLeft()
    {
        moveLeft = true;
    }
}