using RunnerPrototype2.Managers;
using RunnerPrototype2.ScriptableObjects;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerPrototype2.Controllers
{
    public class LevelInitializerController : MonoBehaviour
    {
        LevelDificulityData _levelDifficiultyData;

        private void Awake()
        {
            _levelDifficiultyData = GameManager.Instance.LevelDificulityData;
        }
        private void Start()
        {
            RenderSettings.skybox = _levelDifficiultyData.SkyBoxMaterial;
            Instantiate(_levelDifficiultyData.FloorPrefab);
            Instantiate(_levelDifficiultyData.SpawnerPrefab);
            EnemyManager.Instance.SetMoveSpeed(_levelDifficiultyData.MoveSpeed);
            EnemyManager.Instance.SetAddDelayTime(_levelDifficiultyData.AddDelayTime);
        }
    }

}
