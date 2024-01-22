using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public static float _offset;
    private void FixedUpdate()
    {
        if(ScoreCount.Score <= 600)
        {
            _offset -= 0.04f + (ScoreCount.Score / 10000f);
        }
        else 
        {
            _offset -= 0.1f;
        }
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(_offset, 0);
    }
}
