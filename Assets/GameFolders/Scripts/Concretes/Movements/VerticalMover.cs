using RunnerPrototype2.Abstract.Controllers;
using RunnerPrototype2.Abstract.Movements;
using RunnerPrototype2.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerPrototype2.Movements
{

    public class VerticalMover : IMover
    {
        IEntityController _entityController;
        float _moveSpeed = 5f;
        public VerticalMover(IEntityController entityController)
        {
            _entityController = entityController;
            //_moveSpeed = _entityController.MoveSpeed;
        }
        public void FixedTick(float vertical = 1)
        {
            _entityController.transform.Translate(Vector3.back * Time.deltaTime * _moveSpeed * vertical);
        }
    }
}