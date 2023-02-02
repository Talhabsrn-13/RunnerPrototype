using RunnerPrototype2.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RunnerPrototype2.Controllers
{
    public class EnemyController : MonoBehaviour
    {
        VerticalMover _verticalMover;
        [SerializeField] float _moveSpeed;

        [SerializeField] float _maxLifeTime = 7;
        float _currentLifeTime;
        public float MoveSpeed => _moveSpeed;
        private void Awake()
        {
            _verticalMover = new VerticalMover(this);
        }
        private void Update()
        {
            _currentLifeTime += Time.deltaTime;
            if (_currentLifeTime > _maxLifeTime)
            {
                _currentLifeTime = 0;
                KillYourSelf();
            }
        }
        private void FixedUpdate()
        {
            _verticalMover.FixedTick();
        }

        void KillYourSelf()
        {
            Destroy(this.gameObject);
        }
    }
}