using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerPrototype2.Abstract.Controllers
{
    public interface IEntityController
    {
        Transform transform { get; }
    }
}
