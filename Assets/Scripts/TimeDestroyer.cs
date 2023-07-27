using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDestroyer : MonoBehaviour
{
    public float timeAlive;
    void Start()
    {
        Destroy(gameObject, timeAlive);
    }
}
