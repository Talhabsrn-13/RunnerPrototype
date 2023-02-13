
using RunnerPrototype2.Managers;
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
            EnemyController newEnemy = EnemyManager.Instance.GetPool();
            newEnemy.transform.parent = this.transform;
            newEnemy.transform.position = this.transform.position;
            newEnemy.gameObject.SetActive(true);

            _currentTime = 0f;
            GetRandomSpawnTime();
        }
        private void GetRandomSpawnTime()
        {
            _maxSpawnTime = Random.Range(_min, _max);
        }
    }
}

