using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public ParticleSystem ps;
    public static Particle instance;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }
}
