using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] float effectDuration = 10f;
    [SerializeField] float speedMultiplier = .5f;

    Animator animator;
    AudioSource sound;
    Wheel wheel;
    float defaultWheelSpeed;

    bool pressed;
    void Start()
    {
        animator = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
        wheel = FindObjectOfType<Wheel>();
        defaultWheelSpeed = wheel.speed;
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
        wheel.ChangeSpeed(defaultWheelSpeed * speedMultiplier);
        wheel.speed = defaultWheelSpeed * speedMultiplier;
        Invoke("ResetWheelSpeed", effectDuration);
    }

    void ResetWheelSpeed()
    {
        if (wheel.speed == defaultWheelSpeed * speedMultiplier)
        {
            wheel.ResetSpeed();
        }
    }
}
