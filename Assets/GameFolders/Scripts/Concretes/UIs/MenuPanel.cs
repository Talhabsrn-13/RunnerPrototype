using RunnerPrototype2.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerPrototype2.UIs
{
    public class MenuPanel : MonoBehaviour
    {
        public void SelectAndStart(int index)
        {
            GameManager.Instance.DifficultyIndex = index;
            GameManager.Instance.LoadScene("Game");
        }
        public void ExitButton()
        {
            GameManager.Instance.ExitGame();
        }
    }

}
