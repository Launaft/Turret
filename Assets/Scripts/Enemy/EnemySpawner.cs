using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField, Range(0.1f, 10f)] private float _spawnRate = 1.0f;
    [SerializeField, Range(1f, 2000f)] private float _leftBoarder = 100f;
    [SerializeField, Range(1f, 2000f)] private float _rightBoarder = 100f;

    [SerializeField] private GameObject _enemy;

    private void Start() => StartCoroutine(EnemySpawn());

    private IEnumerator EnemySpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(_spawnRate);

            float shift = Random.Range(-_leftBoarder, _rightBoarder);
            Vector3 spawnPos = transform.position;
            spawnPos.x += shift;

            Vector3 rotation = new Vector3(0, 180, 0);

            Instantiate(_enemy, spawnPos, Quaternion.Euler(rotation));
        }
    }
}
