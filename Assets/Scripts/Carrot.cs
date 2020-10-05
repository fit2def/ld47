using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrot : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 100f;
    [SerializeField] float bobbingSpeed = 3f;


    private float y;
    void Start()
    {
        y = transform.localPosition.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);

        transform.localPosition = new Vector3(
            transform.localPosition.x,
            y + .25f * Mathf.Sin(Time.time * bobbingSpeed),
            transform.localPosition.z
        );
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "HamsterCollider")
        {
            Hamster player = FindObjectOfType<Hamster>();

            player.GetCarrot();

            Destroy(gameObject);
        }
    }
}
