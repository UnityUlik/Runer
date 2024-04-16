using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpeed : MonoBehaviour
{
    public static float _coinSpeed;
    
    private void FixedUpdate()
    {
        if(ScoreCount.Score <= 800)
        {
            _coinSpeed = 0.2f + (ScoreCount.Score / 1000f);
        }
        else 
        {
            _coinSpeed = 1f;
        }
        transform.Translate(0, _coinSpeed, 0);
    }
}
