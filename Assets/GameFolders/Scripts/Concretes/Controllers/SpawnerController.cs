
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerPrototype2.Controllers
{
    public class SpawnerController : MonoBehaviour
    {
        [Range(1, 5)] [SerializeField] float _min;
        [Range(10, 15)] [SerializeField] float _max;

        [SerializeField] float _maxSpawnTime;
        [SerializeField] EnemyController _enemyController;
        float _currentTime = 0f;

        private void OnEnable()
        {
            GetRandomSpawnTime();
        }

        private void Update()
        {
            _currentTime += Time.deltaTime;
            if (_currentTime > _maxSpawnTime)
            {
                Spawn();
            }
        }
        public void Spawn()
        {
            EnemyController newEnemy = Instantiate(_enemyController, transform.position, transform.rotation);
            newEnemy.transform.parent = this.transform;
            _currentTime = 0f;          
            GetRandomSpawnTime();
        }
        private void GetRandomSpawnTime()
        {
            _maxSpawnTime = Random.Range(_min, _max);
        }
    }
}

