using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMenu : MonoBehaviour
{
    public GameObject MenuButton;
    public GameObject RestartButton;
    public GameObject ContinueButton;
    public GameObject MenuText;
    public GameObject Right;
    public GameObject Left;
    public AudioSource Phonk;
    public AudioSource Drift;

    public void OnButtonMenu()
    {
        Phonk.enabled = false;
        Drift.enabled = false;
        CarsSpeed._carSpeed = 0f;
        Road._offset = 0f;
        MenuButton.SetActive(false);
        MenuText.SetActive(true);
        RestartButton.SetActive(true);
        ContinueButton.SetActive(true);
        Right.SetActive(false);
        Left.SetActive(false);
        Time.timeScale = 0f;
    }
}
