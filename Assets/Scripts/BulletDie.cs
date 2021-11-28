using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDie : MonoBehaviour
{
    public GameObject diePEffect;
    public float dieTime;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collisionGameObject = collision.gameObject;

        if (collisionGameObject.name != "Player")
        {
            Die();
        }
    }
    //timo to die 
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(dieTime);
        Die();
    }
    void Die()
    {
        if (diePEffect != null)
        {
            Instantiate(diePEffect, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}
