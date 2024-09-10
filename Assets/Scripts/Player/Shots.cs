using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shots : MonoBehaviour
{
    [Range(0.1f, 5f)]
    public float delay = 0.1f;

    public Transform s_point;

    public GameObject projectile;

    float time = 0;

    private void Start() => time = delay;
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void LateUpdate()
    {
        time += Time.deltaTime;
        if (time >= delay)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(projectile, s_point.position, s_point.rotation);
                time = 0;
            }
        }
    }
}
