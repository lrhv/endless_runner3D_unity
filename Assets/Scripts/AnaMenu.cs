using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnaMenu : MonoBehaviour
{
    
    public void OyunaBasla()
    {
        SceneManager.LoadScene(1);
    }

    public void OyundanCik()
    {
        Application.Quit();
    }

    public void OyunuDurdur()
    {
        SceneManager.LoadScene(0);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
