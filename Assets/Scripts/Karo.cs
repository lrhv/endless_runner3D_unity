
using UnityEngine;

public class Karo : MonoBehaviour
{
    ZeminKontrol zeminnkontrol;

    private void Start()
    {
        zeminnkontrol = GameObject.FindObjectOfType<ZeminKontrol>();
        EngelNoktasi();
        PuanNoktasi();
    }

    private void OnTriggerExit(Collider other)
    {
        zeminnkontrol.Karo();
        Destroy(gameObject, 2);
    }

    private void Update()
    {

    }

    public GameObject engelPrefab;

    void EngelNoktasi()
    {
        int engelNoktasiYeri = Random.Range(2, 5);
        Transform tamYeri = transform.GetChild(engelNoktasiYeri).transform;

        Instantiate(engelPrefab, tamYeri.position, Quaternion.identity, transform);
    }

    public GameObject puanPrefab;

    void PuanNoktasi()
    {
        int puanYeri = 10;
        for (int i = 0; i < puanYeri; i++)
        {
            GameObject temp = Instantiate(puanPrefab, transform);
            temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }

    Vector3 GetRandomPointInCollider (Collider collider)
    {
        Vector3 puan = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.max.z, collider.bounds.max.z)
            );
        if (puan != collider.ClosestPoint(puan))
        {
            puan = GetRandomPointInCollider(collider);
        }

        puan.y = 1;
        return puan;
    }
}
