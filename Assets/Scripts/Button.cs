using System;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] float effectDuration = 10f;
    [SerializeField] float speedMultiplier = .5f;

    Animator animator;
    AudioSource sound;
    Wheel wheel;
    float defaultWheelSpeed;

    public Guid id;

    bool pressed;
    void Start()
    {
        id = Guid.NewGuid();
        animator = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
        wheel = FindObjectOfType<Wheel>();
    }


    void OnTriggerEnter(Collider other)
    {
        if (!pressed && other.name == "HamsterCollider") Press();
    }

    void Press()
    {
        pressed = true;
        sound.Play();
        animator.Play("Press");
        ChangeWheelSpeed();
    }

    void ChangeWheelSpeed()
    {
        print(id);
        wheel.ChangeSpeed(id, speedMultiplier);
        Invoke("ResetWheelSpeed", effectDuration);
    }

    void ResetWheelSpeed()
    {
        if (wheel.speed > 0 && wheel.currentButtonId == id)
        {
            wheel.ResetSpeed();
        }
    }
}
