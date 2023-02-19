using RunnerPrototype2.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerPrototype2.ScriptableObjects
{
    [CreateAssetMenu(fileName = "Level Difficulty", menuName = "Create Difficulty/Create New", order = 1)]
    public class LevelDificulityData : ScriptableObject
    {
        [SerializeField] FloorController _floorPrefab;
        [SerializeField] GameObject _spawnersPrefab;
        [SerializeField] Material _skyBoxMaterial;
        [SerializeField] float _moveSpeed = 10f;
        [SerializeField] float _addDelayTime = 50f;

        public FloorController FloorPrefab => _floorPrefab;
        public GameObject SpawnerPrefab => _spawnersPrefab;
        public Material SkyBoxMaterial => _skyBoxMaterial;
        public float MoveSpeed => _moveSpeed;
        public float AddDelayTime => _addDelayTime;
    }
}

