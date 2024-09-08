using UnityEngine;

public class TargetDesignator : MonoBehaviour
{
    [SerializeField, Range(10, 500)] private int _lenght = 100;
    
    LineRenderer _lineRenderer;

    void Start() => _lineRenderer = GetComponent<LineRenderer>();

    void Update()
    {
        _lineRenderer.SetPosition(0, transform.position);
        _lineRenderer.SetPosition(1, transform.forward * _lenght);
    }
}
