using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawnerScript : MonoBehaviour
{

    public GameObject meat, devil, knife;
    public float meatSpawnRate, devilSpawnRate, knifeSpawnRate;
    public float meatTimer, devilTimer, knifeTimer;
    public float widthOffSet;
    public GameObject gameOver;

    void Start()
    {
        if (!gameOver.activeSelf)
        {
            InvokeRepeating("spawnMeat", meatTimer, meatSpawnRate);
            InvokeRepeating("spawnDevil", devilTimer, devilSpawnRate);
            InvokeRepeating("spawnKnife", knifeTimer, knifeSpawnRate);
        }

            

        
    }


    void spawn(GameObject gameObject)
    {
        float leftPoint = transform.position.x - widthOffSet;
        float rightPoint = transform.position.x + widthOffSet;

        Instantiate(gameObject, new Vector3(Random.Range(leftPoint, rightPoint), 
            transform.position.y, 0), transform.rotation);
    }

    void spawnMeat()
    {
        spawn(meat);
    }

    void spawnDevil()
    {
        spawn(devil);
    }
  
    void spawnKnife()
    {
        spawn(knife);
    }

    }
