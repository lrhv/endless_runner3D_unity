using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    public int skor;
    public static OyunKontrol inst;

    public Text skorText;

    public void ArtýsPuan()
    {
        skor++;
        skorText.text = "Puan: " + skor;
    }


    private void Awake()
    {
        inst = this;
    }

    void Start()
    {
        
    }

  
    void Update()
    {
        
    }
}
