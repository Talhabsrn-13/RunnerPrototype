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
        Abstract.Controllers.IEntityController _entityController;

        public HorizontalMover(Abstract.Controllers.IEntityController entityController)
        {
            _entityController = entityController;
        }
 
        public void FixedTick(float horizontal)
        {
            if (horizontal == 0f) return;

            _entityController.transform.Translate(Vector3.right * horizontal * Time.deltaTime * _entityController.MoveSpeed);

            float boundary = Mathf.Clamp(_entityController.transform.position.x, -_entityController.MoveBoundary, _entityController.MoveBoundary);
            _entityController.transform.position = new Vector3(boundary, _entityController.transform.position.y, 0);
        }
    }
}
