using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject enemy;
    float spawnTime = 4.0f;
    float timer;


    void spawn()
    {
        Instantiate(enemy);
    }

    // Start is called before the first frame update
    void Start()
    {
        float timer = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnTime)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawn();
            timer = 0.0f;
        }
    }
}
