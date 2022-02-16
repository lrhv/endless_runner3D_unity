using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puan : MonoBehaviour
{
    public float donusHizi = 90f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Engel>() != null)
        {
            Destroy(gameObject);
            return;
        }

        if (other.gameObject.name != "Oyuncu") {
            return;
        }

        OyunKontrol.inst.ArtýsPuan();


        Destroy(gameObject);
    }

    
    void Start()
    {
        
    }

    
    private void Update()
    {
        transform.Rotate(0, 0, donusHizi * Time.deltaTime);
    }
}
