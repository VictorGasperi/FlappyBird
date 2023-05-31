using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class PipeSpawnScript : MonoBehaviour
{
    [SerializeField] private GameObject pipe;
    [SerializeField] private float spawnRate = 10;

    [SerializeField] private GameOver _gameOverScript;
    private float heightOffset = 8;


    private void OnEnable()
    {
        _gameOverScript.GameOverEvent.AddListener(OnGameOver);
    }

    private void OnDisable()
    {
        _gameOverScript.GameOverEvent.RemoveListener(OnGameOver);
    }

    private void OnGameOver()
    {
        StopCoroutine(SpawnPipe());
    }

    public float LowestPoint
    {
        get => transform.position.y - heightOffset;
    }

    public float HighestPoint
    {
        get => transform.position.y + heightOffset;
    }
    
    public UnityEvent PipeSpawnedEvent; 
    
    void Start()
    {
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(LowestPoint, HighestPoint), 0),
            transform.rotation);
        
        StartCoroutine(SpawnPipe());
    }

    private IEnumerator SpawnPipe()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            Instantiate(pipe, new Vector3(transform.position.x, Random.Range(LowestPoint, HighestPoint), 0),
                transform.rotation);
            PipeSpawnedEvent.Invoke();
        }
    }
    
}
