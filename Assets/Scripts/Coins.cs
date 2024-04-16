using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public static int coins;
    public Text coinsText;

    public void Start()
    {
        if(PlayerPrefs.HasKey("Coins"))
        {
            coins = PlayerPrefs.GetInt("Coins");
            coinsText.text = coins.ToString();
        }
    }

    public void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Coin")
        {
            coins = coins + 1;
            coinsText.text = coins.ToString();
            Destroy(other.gameObject);
            CoinsCounter();
        }
    }

    public void CoinsCounter()
    {
        PlayerPrefs.SetInt("Coins", coins);
    }

    public void ResetCoins()
    {
        PlayerPrefs.DeleteKey("Coins");
        coins = 0;
    }
}
