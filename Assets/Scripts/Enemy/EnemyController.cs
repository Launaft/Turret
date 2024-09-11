using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(DestructionEffect))]
public class EnemyController : MonoBehaviour
{
    [SerializeField, Range(1, 10)] private int _points = 5;
    [SerializeField, Range(1f, 100f)] private float _speed = 10f;
    
    private Rigidbody _rb;
    private DestructionEffect _destructionEffect;

    public void TakeDamage()
    {
        Score.Increase(_points);

        Destroy(gameObject);
    }

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _destructionEffect = GetComponent<DestructionEffect>();
    }

    private void Update() => _rb.position += transform.forward * _speed * Time.deltaTime;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            Score.Decrease(1);

            _destructionEffect.PlayEffect();
        }
    }
}
