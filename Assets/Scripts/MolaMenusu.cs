using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MolaMenusu : MonoBehaviour
{
    public static bool OyunuDurdur = false;
    public GameObject MolaMenuUI;
    kayitpozisyon oyuncuVerisi;


    private void Start()
    {
        oyuncuVerisi = FindObjectOfType<kayitpozisyon>();
    }

    //Escape tusuyla oyunu durdurmak icin 
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {

            if (OyunuDurdur)
            {
                DevamEt();
                
            }
            else
            {
                Durdur();
                
            }
        }


    }
    //esc bas cek olayi



    public void DevamEt() {
        MolaMenuUI.SetActive(false);
        Time.timeScale = 1f;
        OyunuDurdur = false;
        AudioListener.pause = false;
    }
    void Durdur() {
        MolaMenuUI.SetActive(true);
        Time.timeScale = 0f;
        OyunuDurdur = true;
        AudioListener.pause = true;
    }

    //menuye yonlendirme yapar
    public void MenuYukle()
    {
        SceneManager.LoadScene(0);
    }

    //web oldugu icin cikisi yine yonlendirme yapiyoruz
    public void Cikis()
    {
        oyuncuVerisi.pozKayit();
        SceneManager.LoadScene(0);
    }

}
