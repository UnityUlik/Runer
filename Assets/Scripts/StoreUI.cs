using UnityEngine.SceneManagement;
using UnityEngine;

public class StoreUI : MonoBehaviour
{
    public void OnButtonBackToGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
