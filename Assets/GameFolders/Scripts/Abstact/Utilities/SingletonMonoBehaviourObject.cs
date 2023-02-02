using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerPrototype2.Abstract.Utilities
{
    public abstract class SingletonMonoBehaviourObject<T> : MonoBehaviour 
    {
        public static T  Instance { get;private set; }

        protected void SingletonThisObject(T entity)
        {
            if (Instance == null)
            {
                Instance = entity;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }

}
