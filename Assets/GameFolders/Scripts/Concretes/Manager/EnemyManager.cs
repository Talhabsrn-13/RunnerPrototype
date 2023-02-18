using RunnerPrototype2.Abstract.Utilities;
using RunnerPrototype2.Controllers;
using RunnerPrototype2.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerPrototype2.Managers
{
    public class EnemyManager : SingletonMonoBehaviourObject<EnemyManager>
    {
        [SerializeField] float _addDelayTime = 50f;
        Dictionary<EnemyEnum, Queue<EnemyController>> _enemies = new Dictionary<EnemyEnum, Queue<EnemyController>>();
        [SerializeField] EnemyController[] _enemyPrefabs;

        public float AddDelayTime => _addDelayTime;

        public int Count => _enemyPrefabs.Length;

        private void Awake()
        {
            SingletonThisObject(this);
        }
        private void Start()
        {
            InitializePool();
        }

        private void InitializePool()
        {
            for (int i = 0; i < _enemyPrefabs.Length; i++)
            {
                Queue<EnemyController> enemyControllers = new Queue<EnemyController>();
                for (int j = 0; j < 10; j++)
                {
                    EnemyController newEnemy = Instantiate(_enemyPrefabs[i]);
                    newEnemy.gameObject.SetActive(false);
                    newEnemy.transform.parent = this.transform;
                    enemyControllers.Enqueue(newEnemy);
                }
                _enemies.Add((EnemyEnum)i, enemyControllers);
            }

        }
        public void SetPool(EnemyController enemyController)
        {
            enemyController.gameObject.SetActive(false);
            enemyController.transform.parent = this.transform;

            Queue<EnemyController> enemyControllers = _enemies[enemyController.EnemyType];
            enemyControllers.Enqueue(enemyController);
        }
        public EnemyController GetPool(EnemyEnum enemyType)
        {
            Queue<EnemyController> enemyControllers = _enemies[enemyType];

            if (enemyControllers.Count == 0)
            {
                for (int i = 0; i < 2; i++)
                {
                    EnemyController newEnemy = Instantiate(_enemyPrefabs[(int)enemyType]);
                    enemyControllers.Enqueue(newEnemy);
                }              
            }
            return enemyControllers.Dequeue();
        }
    }

}
