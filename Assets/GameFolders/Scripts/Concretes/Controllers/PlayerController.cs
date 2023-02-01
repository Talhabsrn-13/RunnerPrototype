using RunnerPrototype2.Abstract.Inputs;
using RunnerPrototype2.Inputs;
using RunnerPrototype2.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace RunnerPrototype2.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] bool _isJump;
        [SerializeField] float _jumpForce;
        [SerializeField] float _moveSpeed = 10f;
        [SerializeField] float _horizontalBoundary = 4.5f;
        HorizontalMover _horizontalMover;
        JumpWithRigidbody _jumpWithRigidbody;

        IInputReader _input;

        float _horizontal;
        public float MoveSpeed => _moveSpeed;
        public float HorizontalBoundary => _horizontalBoundary;
        private void Awake()
        {
            _horizontalMover = new HorizontalMover(this);
            _jumpWithRigidbody = new JumpWithRigidbody(this);

            _input = new InputReader(GetComponent<PlayerInput>());
        }

        private void Update()
        {
            _horizontal = _input.Horizontal;
            if (_input.IsJump)
            {
                _isJump = true;
            }
        }
        private void FixedUpdate()
        {
            _horizontalMover.TickFixed(_horizontal);

            if (_isJump)
            {
                _jumpWithRigidbody.FixedTick(_jumpForce);
            }
            _isJump = false;

        }
    }
}
