using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Health : MonoBehaviour
{
    public static int Hearts;
    public Text TextHearts;
    public GameObject MenuButton;
    public GameObject Restart;
    public GameObject GameOver;
    public GameObject Right;
    public GameObject Left;
    public AudioSource Phonk;
    public AudioSource Drift;

    public void Start()
    {
        Hearts = 1;
        TextHearts.text = Hearts.ToString();
    }

    public void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "RemoveCars")
        {
            Hearts = Hearts - 1;
            TextHearts.text = Hearts.ToString();
            if(Hearts <= 0)
            {
                Destroy(other.gameObject);
                Destroy(gameObject);
                StopGame();
            }  
        }
    }

    public void StopGame()
    {
        Phonk.enabled = false;
        Drift.enabled = false;
        CarsSpeed._carSpeed = 0f;
        Road._offset = 0f;
        MenuButton.SetActive(false);
        Restart.SetActive(true);
        GameOver.SetActive(true);
        Right.SetActive(false);
        Left.SetActive(false);
        Time.timeScale = 0f;
    }
}
