using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject Barrel;

    public Transform fireTransform;

    public float fireForce = 500;

    Coroutine barrelfireCoroutine;
    // Start is called before the first frame update
    void Start()
    {
        barrelfireCoroutine = StartCoroutine(BarrelFiringCoRoutine());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator BarrelFiringCoRoutine()
    {
        while (true)
        {
            float timer = Random.Range(1f, 5f);
            GameObject missile = Instantiate(Barrel, fireTransform.position, transform.rotation);

            Rigidbody2D missileBody = missile.GetComponent<Rigidbody2D>();

            missileBody.AddForce(transform.up * fireForce);
            yield return new WaitForSeconds(timer);
        }

    }
}
