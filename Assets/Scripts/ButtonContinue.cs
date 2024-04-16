using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonContinue : MonoBehaviour
{
    public GameObject HighScore;
    public GameObject Score;
    public GameObject Left;
    public GameObject Right;
    public GameObject Heart;
    public GameObject MenuButton;
    public GameObject Menu;
    public GameObject ContinueButton;
    public GameObject QuitToMenuButton;
    public AudioSource Phonk;
    public AudioSource Drift;

    public void OnButtonContinue()
    {
        Phonk.enabled = true;
        Drift.enabled = true;
        ContinueButton.SetActive(false);
        QuitToMenuButton.SetActive(false);
        Menu.SetActive(false);
        HighScore.SetActive(true);
        Score.SetActive(true);
        Left.SetActive(true);
        Right.SetActive(true);
        Heart.SetActive(true);
        MenuButton.SetActive(true);
        Time.timeScale = 1f;
    }
}
