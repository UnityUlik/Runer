using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPlay : MonoBehaviour
{
    public GameObject HighScore;
    public GameObject Score;
    public GameObject Left;
    public GameObject Right;
    public GameObject Heart;
    public GameObject MenuButton;
    public GameObject MainMenu;
    public GameObject PlayButton;
    public GameObject StoreButton;
    public GameObject QuitButton;
    public AudioSource Phonk;
    public AudioSource Drift;

    void Awake()
    {
        Time.timeScale = 0f;
        Phonk.enabled = false;
        Drift.enabled = false;
    }

    public void StartGame()
    {

        Phonk.enabled = true;
        Drift.enabled = true;
        QuitButton.SetActive(false);
        StoreButton.SetActive(false);
        PlayButton.SetActive(false);
        MainMenu.SetActive(false);
        HighScore.SetActive(true);
        Score.SetActive(true);
        Left.SetActive(true);
        Right.SetActive(true);
        Heart.SetActive(true);
        MenuButton.SetActive(true);
        Time.timeScale = 1f;
    }
}
