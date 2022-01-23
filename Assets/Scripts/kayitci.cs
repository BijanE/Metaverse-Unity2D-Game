using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kayitci : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            string oAnEkran = SceneManager.GetActiveScene().name;
            PlayerPrefs.SetString("Bolumkayit", oAnEkran);

            //debugcheck van
            gameObject.SetActive(false);

        }
    }
}
