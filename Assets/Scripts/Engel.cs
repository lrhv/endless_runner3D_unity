using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engel : MonoBehaviour
{
    OyuncuKontrol oyuncukontrol;

    
    private void Start()
    {
        oyuncukontrol = GameObject.FindObjectOfType<OyuncuKontrol>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Oyuncu")
        {
            oyuncukontrol.Olum();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
