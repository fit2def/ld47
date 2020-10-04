using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HamsterCollider : MonoBehaviour
{
    [SerializeField] Hamster hamster;
    void OnParticleCollision(GameObject other)
    {
        hamster.Scorch();
    }
}
