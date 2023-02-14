using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerPrototype2.Abstract.Movements
{
    public interface IMover
    {
        void FixedTick(float direction);
    }
}
