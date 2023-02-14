using RunnerPrototype2.Abstract.Controllers;
using RunnerPrototype2.Abstract.Inputs;
using RunnerPrototype2.Abstract.Movements;
using RunnerPrototype2.Inputs;
using RunnerPrototype2.Managers;
using RunnerPrototype2.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace RunnerPrototype2.Controllers
{
    public class PlayerController : MonoBehaviour, IEntityController
    {

        [SerializeField] float _jumpForce;
        [SerializeField] float _moveSpeed = 10f;
        [SerializeField] float _moveBoundary = 4.5f;

        IMover _mover;
        IJump _jumpWithRigidbody;
        IInputReader _input;

        float _horizontal;
        bool _isJump;
        bool _isDead = false;

        public float MoveSpeed => _moveSpeed;
        public float HorizontalBoundary => _moveBoundary;
        private void Awake()
        {
           
            _mover = new HorizontalMover(this);
            _jumpWithRigidbody = new JumpWithRigidbody(this);

            _input = new InputReader(GetComponent<PlayerInput>());
        }

        private void Update()
        {
            if (_isDead) return;
            _horizontal = _input.Horizontal;
            if (_input.IsJump)
            {
                _isJump = true;
            }
        }
        private void FixedUpdate()
        {
            _mover.FixedTick(_horizontal);

            if (_isJump)
            {
                _jumpWithRigidbody.FixedTick(_jumpForce);
            }
            _isJump = false;
        }
        private void OnTriggerEnter(Collider other)
        {
            IEntityController entityController = other.GetComponent<IEntityController>();
            if (entityController != null)
            {
                _isDead = true;
                GameManager.Instance.StopGame();
            }
        }
    }
}
