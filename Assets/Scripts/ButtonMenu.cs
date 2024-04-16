using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMenu : MonoBehaviour
{
    public GameObject Left;
    public GameObject Right;
    public GameObject MenuButton;
    public GameObject Menu;
    public GameObject ContinueButton;
    public GameObject QuitToMenuButton;
    public AudioSource Phonk;
    public AudioSource Drift;

    public void OnButtonMenu()
    {
        Phonk.enabled = false;
        Drift.enabled = false;
        ContinueButton.SetActive(true);
        QuitToMenuButton.SetActive(true);
        Menu.SetActive(true);
        Left.SetActive(false);
        Right.SetActive(false);
        MenuButton.SetActive(false);
        CarsSpeed._carSpeed = 0f;
        Road._offset = 0f;
        Time.timeScale = 0f;
    }
}
