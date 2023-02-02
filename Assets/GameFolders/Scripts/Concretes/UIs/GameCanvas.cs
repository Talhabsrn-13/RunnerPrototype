using RunnerPrototype2.Managers;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerPrototype2.UIs
{
    public class GameCanvas : MonoBehaviour
    {
        [SerializeField] GamePanel _gameOverPanel;

        private void Awake()
        {
            if (_gameOverPanel.gameObject.activeSelf)
            {
                _gameOverPanel.gameObject.SetActive(false);
            }
        }

        private void OnEnable()
        {
            GameManager.Instance.OnStopTime += HandleGameStop;
        }

        private void HandleGameStop()
        {
            _gameOverPanel.gameObject.SetActive(true);
        }

        private void OnDisable()
        {
            GameManager.Instance.OnStopTime -= HandleGameStop;
        }
      
    }
}