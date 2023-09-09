using UnityEngine;

namespace MyProject.Scripts.Spawner
{
    public class Spawner : ObjectPool
    {
        [SerializeField] private GameObject[] _prefabs;
        [SerializeField] private Transform[] _spawPoints;

        private void Start()
        {
            Initialize(_prefabs);
        }
        
        public void Spawn()
        {
            if (TryGetObject(out GameObject @object))
            {
                int spawnPointNumber = Random.Range(0, _spawPoints.Length);

                Show(@object, _spawPoints[spawnPointNumber].position);
            }
        }
    
        private void Show(GameObject @object, Vector3 position)
        {
            @object.SetActive(true);
        
            @object.transform.position = position;
        }
    }
}
