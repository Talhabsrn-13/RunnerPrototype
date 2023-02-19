using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerPrototype2.Abstract.Controllers
{
    public abstract class MyCharacterController : MonoBehaviour
    {
        [SerializeField] float _moveBoundary;
        [SerializeField] protected float _moveSpeed;

        public float MoveBoundary => _moveBoundary;
        public float MoveSpeed => _moveSpeed;
    }

}
