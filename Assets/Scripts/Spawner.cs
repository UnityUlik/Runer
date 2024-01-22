using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Cars;
    public float velocity;

    public void Awake()
    {
        velocity = 0f;
    }

    private void Start()
    {
        Invoke("Spawn", velocity);
    }

    private void Spawn()
    {
        if(ScoreCount.Score <= 2900)
        {
            velocity = 3f - (ScoreCount.Score / 1000f);
        }
        var randomCar = Cars[Random.Range(0, Cars.Length)];
        Instantiate(randomCar);
        randomCar.transform.position = new Vector3(160, 0, Random.Range(-6, 6));
        Invoke("Start", 0f);
    }
}