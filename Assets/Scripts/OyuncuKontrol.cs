using UnityEngine.SceneManagement;
using UnityEngine;

public class OyuncuKontrol : MonoBehaviour
{

    bool can = true;

    public float hiz = 5;
    public Rigidbody rb;

    float tusGiris;
    public float tusKontrol = 2;

    private void FixedUpdate()
    {
        if (!can) return;

        Vector3 ileriHareket = transform.forward * hiz * Time.fixedDeltaTime;
        Vector3 yanlaraHareket = transform.right * tusGiris * hiz * Time.fixedDeltaTime * tusKontrol;
        rb.MovePosition(rb.position + ileriHareket + yanlaraHareket);
    }

    private void Update()
    {
        tusGiris = Input.GetAxis("Horizontal");

        if(transform.position.y < -5)
        {
            Olum();
        }

    }

    public void Olum()
    {
        can = false;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
}
