using RunnerPrototype2.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerPrototype2.Movements
{

    public class VerticalMover : MonoBehaviour
    {
        EnemyController _enemyController;
        float _moveSpeed = 5f;
        public VerticalMover(EnemyController enemyController)
        {
            _enemyController = enemyController;
            _moveSpeed = _enemyController.MoveSpeed;
        }
        public void FixedTick(float vertical = 1)
        {
            _enemyController.transform.Translate(Vector3.back * Time.deltaTime * _moveSpeed * vertical);
        }
    }
}