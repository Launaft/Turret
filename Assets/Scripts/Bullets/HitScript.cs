using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScript : MonoBehaviour
{
    [Range(0.5f, 50f)]
    public float explosionRadius = 5;

    public GameObject explosion;

    public LayerMask bomb_layer;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            dealDamage();
            explode();
        }
    }

    void dealDamage()
    {
        Collider[] cols = Physics.OverlapSphere(transform.position, explosionRadius, bomb_layer);
        foreach (Collider col in cols)
            col.transform.GetComponent<EnemyController>().TakeDamage();
    }

    void explode()
    {
        GameObject t = Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(t, 2);
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
