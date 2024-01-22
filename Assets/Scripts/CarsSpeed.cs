using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsSpeed : MonoBehaviour
{
    public static float _carSpeed;

    private void FixedUpdate()
    {
        if(ScoreCount.Score <= 800)
        {
            _carSpeed = 0.2f + (ScoreCount.Score / 1000f);
        }
        else 
        {
            _carSpeed = 1f;
        }
        transform.Translate(0, 0, _carSpeed);
    }
}
