using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuStart : MonoBehaviour
{
    public void StartGame()
    {
        PlayerPrefs.DeleteKey("pozisyon_X");//yeni oyun dedigimizde x sil
        PlayerPrefs.DeleteKey("pozisyon_y");//yeni oyun dedigimizde y sil

        PlayerPrefs.DeleteKey("Syukleme");
        PlayerPrefs.DeleteKey("kayit");

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Load()
    {
        SceneManager.LoadScene(1);
    }
}
