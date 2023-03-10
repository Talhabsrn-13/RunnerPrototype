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
        Abstract.Controllers.IEntityController _entityController;

        public VerticalMover(Abstract.Controllers.IEntityController entityController)
        {
            _entityController = entityController;
           
        }
        public void FixedTick(float vertical = 1)
        {
            _entityController.transform.Translate(Vector3.back * Time.deltaTime * _entityController.MoveSpeed * vertical);
        }
    }
}