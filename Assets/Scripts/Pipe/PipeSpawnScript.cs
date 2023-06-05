using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class PipeSpawnScript : MonoBehaviour
{
    [SerializeField] private GameObject pipe;
    public float SpawnRate
    {
        get;
        private set;
    }

    [SerializeField] private GameOver _gameOverScript;
    //public UnityEvent ChangeDifficultyEvent;
    private float heightOffset = 8;
    public int PipeSpawnedCount { get; private set; }
    private float _difficultyNumber = 1;
    
    public float LowestPoint
        {
            get => transform.position.y - heightOffset;
        }
    
        public float HighestPoint
        {
            get => transform.position.y + heightOffset;
        }
        
        public UnityEvent PipeSpawnedEvent; 

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
        StopAllCoroutines();
    }

    private void Awake()
    {
        PipeSpawnedCount = 0;
        SpawnRate = 2.5f;
    }
    void Start()
        {
            Instantiate(pipe, new Vector3(transform.position.x, Random.Range(LowestPoint, HighestPoint), 0),
                transform.rotation);
        
            StartCoroutine(SpawnPipe());
        }
    private void Update()
    {
        if (PipeSpawnedCount == 8)
        {
            PipeSpawnedCount = 0;
            _difficultyNumber++;
            SpawnRate = IncreaseDifficulty.SetNewSpawnRate(SpawnRate, _difficultyNumber);
            Debug.Log(SpawnRate);
        }
    }
    
    private IEnumerator SpawnPipe()
    {
        while (true)
        {
            yield return new WaitForSeconds(SpawnRate);
            Instantiate(pipe, new Vector3(transform.position.x, Random.Range(LowestPoint, HighestPoint), 0),
                transform.rotation);
            PipeSpawnedCount++;
            PipeSpawnedEvent.Invoke();
        }
    }
    
}
