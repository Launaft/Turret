using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(DestructionEffect))]
public class EnemyController : MonoBehaviour
{
    [SerializeField, Range(1, 10)] private int _points = 1;
    [SerializeField, Range(1f, 100f)] private float _speed = 10f;
    
    private Rigidbody _rb;
    private DestructionEffect _destructionEffect;

    public void TakeDamage()
    {
        //Score.Increase(_points);
        GameObject score = GameObject.FindWithTag("Score");
        if (score != null)
            score.GetComponent<ScoreBoard>().Increase(_points);

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
            //Score.Decrease(_points);
            GameObject score = GameObject.FindWithTag("Score");
            if (score != null)//Не знаю, нужна ли эта проверка. Была в методичке, убирать не стал. В TakeDamage тоже оставил
                score.GetComponent<ScoreBoard>().Decrease(_points);

            _destructionEffect.PlayEffect();
        }
    }
}
