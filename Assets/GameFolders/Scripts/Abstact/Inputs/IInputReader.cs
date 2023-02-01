using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerPrototype2.Abstract.Inputs
{
    public interface IInputReader
    {
        float Horizontal { get; }
        bool IsJump { get; }
    }
}