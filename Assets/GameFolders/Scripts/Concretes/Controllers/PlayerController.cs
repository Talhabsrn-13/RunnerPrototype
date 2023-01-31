using RunnerPrototype2.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerPrototype2.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        HorizontalMover _horizontalMover;
        JumpWithRigidbody _jumpWithRigidbody;

        [SerializeField] bool _isJump;
        [SerializeField] float _jumpForce;
        [SerializeField] float _horizontalDirection;
        [SerializeField] float _moveSpeed = 10f;
        private void Awake()
        {
            _horizontalMover = new HorizontalMover(this);
            _jumpWithRigidbody = new JumpWithRigidbody(this);
        }
        private void FixedUpdate()
        {
            _horizontalMover.TickFixed(_horizontalDirection, _moveSpeed);

            if (_isJump)
            {
                _jumpWithRigidbody.FixedTick(_jumpForce);
            }
            _isJump = false;

        }
    }
}
