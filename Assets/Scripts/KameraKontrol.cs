
using UnityEngine;

public class KameraKontrol : MonoBehaviour
{
    public Transform oyuncu;
    Vector3 offset;

    private void Start()
    {
        offset = transform.position - oyuncu.position;
    }

    
    private void Update()
    {
        Vector3 hedefPoz = oyuncu.position + offset;
        hedefPoz.x = 0;
        transform.position = hedefPoz;
    }
}
