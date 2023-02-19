using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RunnerPrototype2.Abstract.Utilities;
using UnityEngine.SceneManagement;
using RunnerPrototype2.ScriptableObjects;

namespace RunnerPrototype2.Managers
{
    public class GameManager : SingletonMonoBehaviourObject<GameManager>
    {
        [SerializeField] LevelDificulityData[] _levelDifficultyDatas;
        public event System.Action OnStopTime;

        public LevelDificulityData LevelDificulityData => _levelDifficultyDatas[DifficultyIndex];

        int _difficultyIndex;
        public int DifficultyIndex {
            get
            {
                return _difficultyIndex;
            }
            set
            {
                if (_difficultyIndex < 0 || _difficultyIndex > _levelDifficultyDatas.Length)
                {
                    LoadSceneAsync("Menu");
                }
                else
                {
                    _difficultyIndex = value;
                }
            }
        }
        public int Score { get; set; }
        private void Awake()
        {
            SingletonThisObject(this);
        }

        public void StopGame()
        {
            Time.timeScale = 0f;
            OnStopTime?.Invoke();
        }

        public void LoadScene(string sceneName)
        {
            StartCoroutine(LoadSceneAsync(sceneName));
        }
        IEnumerator LoadSceneAsync(string sceneName)
        {
            Time.timeScale = 1f;
            yield return SceneManager.LoadSceneAsync(sceneName);
        }
        public void ExitGame()
        {
            Debug.Log("Exit on clicked");
            Application.Quit();

        }
    }
}
