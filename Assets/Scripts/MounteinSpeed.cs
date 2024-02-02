using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MounteinSpeed : MonoBehaviour
{
    public static float _mountainSpeed;

    private void FixedUpdate()
    {
        if(ScoreCount.Score <= 800)
        {
            _mountainSpeed = 0.2f + (ScoreCount.Score / 1000f);
        }
        else 
        {
            _mountainSpeed = 1f;
        }
        transform.Translate(-_mountainSpeed, 0, 0);
    }
}
