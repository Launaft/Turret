using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shots : MonoBehaviour
{
    [Range(0.1f, 5f)]
    public float delay = 0.1f;

    public Transform s_point_L;
    public Transform s_point_R;

    public GameObject projectile;

    float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
    }
}
