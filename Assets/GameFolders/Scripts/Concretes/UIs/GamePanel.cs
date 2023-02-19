using RunnerPrototype2.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
namespace RunnerPrototype2.UIs
{
    public class GamePanel : MonoBehaviour
    {
        public void YesButton()
        {
           GameManager.Instance.LoadScene("Game");
        }
        public void NoButton()
        {
           GameManager.Instance.LoadScene("Menu");
        }
      
    }

}
