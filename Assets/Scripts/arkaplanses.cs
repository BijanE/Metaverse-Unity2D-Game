using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arkaplanses : MonoBehaviour
{
  
    void Start()
    {
        
    }
    //global oynatma bas
    //scriptimizdeki objeye ers
    private static arkaplanses ornek = null;
    private static arkaplanses Ornek
    {
        get
        {
            return ornek;
        }
    }
    private void Awake()
    {
        if(ornek != null && ornek != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            ornek = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
    //global oynatma son    
    void Update()
    {
        
    }
}
