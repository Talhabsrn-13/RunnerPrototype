using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerPrototype2.Controllers
{
    public class FloorController : MonoBehaviour
    {
        Material _material;
        [Range(0.5f,2.5f)]
        [SerializeField] float _moveSpeed;

        private void Awake()
        {
            _material = GetComponentInChildren<MeshRenderer>().material;
        }
        private void Update()
        {
            _material.mainTextureOffset += Vector2.down * Time.deltaTime * _moveSpeed;
        }
    }
}

