using RunnerPrototype2.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerPrototype2.Movements
{
    public class HorizontalMover
    {
        PlayerController _playerController;
        float _moveSpeed;
        float _horizontalBoundary;
        public HorizontalMover(PlayerController playerController)
        {
            _playerController = playerController;

            _moveSpeed = playerController.MoveSpeed;
            _horizontalBoundary = playerController.HorizontalBoundary;
        }

        public void TickFixed(float horizontal)
        {
            if (horizontal == 0f) return;

            _playerController.transform.Translate(Vector3.right * horizontal * Time.deltaTime * _moveSpeed);

            float boundary = Mathf.Clamp(_playerController.transform.position.x, -_horizontalBoundary, _horizontalBoundary);
            _playerController.transform.position = new Vector3(boundary, _playerController.transform.position.y, 0);
        }
    }
}
