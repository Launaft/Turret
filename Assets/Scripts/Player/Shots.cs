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

    void LateUpdate()
    {
        time += Time.deltaTime;
        if (time >= delay)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Score.Decrease(1);
                Instantiate(projectile, s_point.position, s_point.rotation);
                time = 0;
            }
        }
    }
}
