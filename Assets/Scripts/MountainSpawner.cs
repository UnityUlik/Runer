using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountainSpawner : MonoBehaviour
{
    public GameObject Mountain;
    public float velocity = 0.8f;

    private void Start()
    {
        InvokeRepeating("RightSpawn", 0f, velocity);
        InvokeRepeating("LeftSpawn", 0f, velocity);
    }

    private void RightSpawn()
    {
        Instantiate(Mountain);
        Mountain.transform.position = new Vector3(250, 0, -18.1f);
    }

    private void LeftSpawn()
    {
        Instantiate(Mountain);
        Mountain.transform.position = new Vector3(250, 0, 18.6f);
    }
}
