using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public UnityEvent RestartGameEvent;
    
    public void RestartGameMethod()
    {
        SceneManager.LoadScene("MainMenu");
        RestartGameEvent.Invoke();
    }
}
