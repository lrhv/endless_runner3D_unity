
using UnityEngine;

public class ZeminKontrol : MonoBehaviour
{
    public GameObject zeminkarosu;
    Vector3 siradakiZeminkarosu;

    public void Karo()
    {
        GameObject temp = Instantiate(zeminkarosu, siradakiZeminkarosu, Quaternion.identity);
        siradakiZeminkarosu = temp.transform.GetChild(1).transform.position;
    
    }

    private void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            Karo();
        }
        
    }
}
