using System;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    float fov;
    public float speed = 25f;
    private float savedSpeed;
    public Guid currentButtonId;
    void Start()
    {
        fov = Camera.main.fieldOfView;
        savedSpeed = speed;
    }

    void Update()
    {
        transform.Rotate(Vector3.right * speed * Time.deltaTime);
    }

    public void ChangeSpeed(Guid buttonId, float multiplier)
    {
        currentButtonId = buttonId;

        this.speed = savedSpeed * multiplier;
    }

    public void ResetSpeed()
    {
        // Camera.main.fieldOfView = fov;
        speed = savedSpeed;
    }
}
