using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFallDestroyer : MonoBehaviour
{
    public Text TextHearts;
    public GameObject MenuButton;
    public GameObject Restart;
    public GameObject GameOver;
    public GameObject Right;
    public GameObject Left;
    public AudioSource Phonk;
    public AudioSource Drift;

    public void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Player")
        {
            Destroy(other.gameObject);
            Health.Hearts = Health.Hearts - Health.Hearts;
            TextHearts.text = Health.Hearts.ToString();
            StopGame();
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
