using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayBtnScript : MonoBehaviour
{
    public void StartGameScene()
    {
        SceneManager.LoadScene("Game");
    }
}
