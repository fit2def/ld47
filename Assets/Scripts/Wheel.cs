using UnityEngine;

public class Wheel : MonoBehaviour
{
    float fov;
    public float speed = 25f;
    private float savedSpeed;

    void Start()
    {
        fov = Camera.main.fieldOfView;
        savedSpeed = speed;
    }

    void Update()
    {
        transform.Rotate(Vector3.right * speed * Time.deltaTime);
    }

    public void ChangeSpeed(float speed)
    {
        // if (speed > this.speed)
        // {
        //     Camera.main.fieldOfView = 100;
        // }

        this.speed = speed;
    }

    public void ResetSpeed()
    {
        // Camera.main.fieldOfView = fov;
        speed = savedSpeed;
    }
}
