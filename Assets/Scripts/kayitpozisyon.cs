using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kayitpozisyon : MonoBehaviour
{
    public GameObject player;
    private float pozisyonX; 
    private float pozisyonY;

    public void pozKayit() //Player Poz Save
    {
        PlayerPrefs.SetInt("kayit", 1);
        PlayerPrefs.SetFloat("pozisyon_X", player.transform.position.x);//x icin posizsyon kayit
        PlayerPrefs.SetFloat("pozisyon_y", player.transform.position.y);//y icin posizsyon kayit

        player.transform.position = new Vector2(pozisyonX, pozisyonY);

        PlayerPrefs.SetInt("kayit", 1);
        PlayerPrefs.Save();
    }



    void Start()
    {
        if (PlayerPrefs.GetInt("kayit") == 1 && PlayerPrefs.GetInt("Syukleme") == 1)// eger aldiysak pozlarý al
        {
            float pozisyonX = player.transform.position.x;
            float pozisyonY = player.transform.position.y;

            pozisyonX = PlayerPrefs.GetFloat("pozisyon_X");
            pozisyonY = PlayerPrefs.GetFloat("pozisyon_y");
            PlayerPrefs.SetInt("Syukleme", 0);
            PlayerPrefs.Save();//player prf save it
        }

        
    }

    void Update()
    {
        
    }
    public void pozYukleme()
    {
        PlayerPrefs.SetInt("Syukleme", 1);
        PlayerPrefs.Save();
    }
}
