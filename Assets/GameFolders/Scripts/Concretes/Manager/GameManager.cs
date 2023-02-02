using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RunnerPrototype2.Abstract.Utilities;
namespace RunnerPrototype2.Managers
{
    public class GameManager : SingletonMonoBehaviourObject<GameManager>
    {
        private void Awake()
        {
            SingletonThisObject(this);
        }

        public void StopGame()
        {
            Time.timeScale = 0f;
        }
    }
}
