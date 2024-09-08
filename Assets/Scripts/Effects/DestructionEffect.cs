using UnityEngine;

public class DestructionEffect : MonoBehaviour
{
    [SerializeField, Range(1f, 10f)] private float _effectDuration = 1;
    [SerializeField] private GameObject _explosionEffect;

    public void PlayEffect()
    {
        GameObject explosion = Instantiate(_explosionEffect, transform.position, Quaternion.identity);
        Destroy(explosion, 2);
        Destroy(gameObject);
    }
}
