using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullets : MonoBehaviour
{
    [Range(0.5f, 5f)]
    public float lifeTime = 5;
    [Range(5f, 100f)]
    public float moveSpeed = 15;

    public GameObject explosion;

    Rigidbody rb;

    private void Start() => rb = GetComponent<Rigidbody>();

    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
        rb.position += transform.forward * moveSpeed * Time.deltaTime;

        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
            explode();
    }
    void explode()
    {
        GameObject t = Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(t, 2);
        Destroy(gameObject);
    }
}
