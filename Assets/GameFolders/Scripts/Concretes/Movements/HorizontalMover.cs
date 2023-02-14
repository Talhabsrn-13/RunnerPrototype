using RunnerPrototype2.Abstract.Controllers;
using RunnerPrototype2.Abstract.Movements;
using RunnerPrototype2.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerPrototype2.Movements
{
    public class HorizontalMover : IMover
    {
        Abstract.Controllers.IEntityController _playerController;
        float _moveSpeed;
        float _horizontalBoundary;
        public HorizontalMover(Abstract.Controllers.IEntityController entityController)
        {
            _playerController = entityController;

            _moveSpeed = entityController.MoveSpeed;
            _horizontalBoundary = entityController.MoveBoundary;
        }
 
        public void FixedTick(float horizontal)
        {
            if (horizontal == 0f) return;

            _playerController.transform.Translate(Vector3.right * horizontal * Time.deltaTime * _moveSpeed);

            float boundary = Mathf.Clamp(_playerController.transform.position.x, -_horizontalBoundary, _horizontalBoundary);
            _playerController.transform.position = new Vector3(boundary, _playerController.transform.position.y, 0);
        }
    }
}
