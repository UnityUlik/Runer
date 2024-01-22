using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonContinue : MonoBehaviour
{
    public GameObject MenuButton;
    public GameObject RestartButton;
    public GameObject ContinueButton;
    public GameObject MenuText;
    public GameObject Right;
    public GameObject Left;
    public AudioSource Phonk;
    public AudioSource Drift;

    public void OnButtonContinue()
    {
        Phonk.enabled = true;
        Drift.enabled = true;
        MenuButton.SetActive(true);
        RestartButton.SetActive(false);
        ContinueButton.SetActive(false);
        MenuText.SetActive(false);
        Right.SetActive(true);
        Left.SetActive(true);
        Time.timeScale = 1f;
    }
}
