using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kayityukle : MonoBehaviour
{
    //2d oldugu icin  x y aldik duzlemleri
    public float x;
    public float y;



    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void Kayit()
    {
        x = transform.position.x;
        y = transform.position.y;

        PlayerPrefs.SetFloat("x", x);
        PlayerPrefs.SetFloat("y", y);

    }

    public void Yukle()
    {
        PlayerPrefs.SetFloat("x", x);
        PlayerPrefs.SetFloat("y", y);

        Vector2 YuklePozisyon = new Vector2(x, x);
        transform.position = YuklePozisyon;
        SceneManager.LoadScene(1);
    }


}
