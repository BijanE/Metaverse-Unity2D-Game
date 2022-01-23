using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cikis : MonoBehaviour
{
    kayitpozisyon oyuncuVerisi;
    private void Start()
    {
        oyuncuVerisi = FindObjectOfType<kayitpozisyon>();
    } 
    public void CikisOyundan()
    {
        oyuncuVerisi.pozKayit();
        SceneManager.LoadScene("0");
    }
}
