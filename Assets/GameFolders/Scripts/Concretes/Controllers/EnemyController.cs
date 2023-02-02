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
        public float MoveSpeed => _moveSpeed;
        private void Awake()
        {
            _verticalMover = new VerticalMover(this);
        }
        private void FixedUpdate()
        {
            _verticalMover.FixedTick();
        }
    }
}