using RunnerPrototype2.Abstract.Controllers;
using RunnerPrototype2.Enums;
using RunnerPrototype2.Managers;
using RunnerPrototype2.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RunnerPrototype2.Controllers
{
    public class EnemyController : MyCharacterController, Abstract.Controllers.IEntityController
    {
        VerticalMover _mover;
       
        [SerializeField] float _maxLifeTime = 7;
        float _currentLifeTime;
      
        [SerializeField] EnemyEnum _enemyEnum;
        public EnemyEnum EnemyType => _enemyEnum;
        private void Awake()
        {
            _mover = new VerticalMover(this);
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
            _mover.FixedTick();
        }

        void KillYourSelf()
        {
            EnemyManager.Instance.SetPool(this);
            GameManager.Instance.Score++;
        }
        public void SetMoveSpeed(float moveSpeed = 10f)
        {
            if (moveSpeed < _moveSpeed) return;

            _moveSpeed = moveSpeed;
        }
    }
}