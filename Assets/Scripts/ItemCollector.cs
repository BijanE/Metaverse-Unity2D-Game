using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int cherries = 0;

    [SerializeField] private Text cherriesText;
    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    { //cherry tagini yaziyoruz, trigger olan nesne tagi
        if (collision.gameObject.CompareTag("Cherry"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            cherries++;
            //burada cherries in text kismini direkt aliyor
            cherriesText.text = "Cherries: " + cherries;
            //Debug.Log("Cherries: " + cherries);
        }
    }
}
