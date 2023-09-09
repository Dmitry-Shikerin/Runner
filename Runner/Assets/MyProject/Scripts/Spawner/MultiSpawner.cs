using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace MyProject.Scripts.Spawner
{
    public class MultiSpawner : MonoBehaviour
    {
        [SerializeField] private Spawner _enemySpawner;
        [SerializeField] private Spawner _healthSpawner;
        [SerializeField] private float _secondsBetweenSpawn;
        [SerializeField] private int _heathDrop;

        private float _elapsedTime = 0;

        private void Update()
        {
            _elapsedTime += Time.deltaTime;
            
            int randomSpawn = Random.Range(0, 101);
            
            if (_elapsedTime >= _secondsBetweenSpawn)
            {
                _elapsedTime = 0;

                if (randomSpawn > _heathDrop)
                {
                    _enemySpawner.Spawn();
                    return;
                }
                
                _healthSpawner.Spawn();
            }
        }
    }
}
