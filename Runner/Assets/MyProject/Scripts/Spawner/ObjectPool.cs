using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace MyProject.Scripts.Spawner
{
    public class ObjectPool : MonoBehaviour
    {
        [SerializeField] private GameObject _conteiner;
        [SerializeField] private int _capasity;

        private List<GameObject> _pool = new List<GameObject>();

        protected void Initialize(GameObject prefab)
        {
            for (int i = 0; i < _capasity; i++)
            {
                GameObject spawned = Instantiate(prefab, _conteiner.transform);
                spawned.SetActive(false);

                _pool.Add(spawned);
            }
        }

        protected void Initialize(GameObject[] prefabs)
        {
            for (int i = 0; i < _capasity; i++)
            {
                int randomIndex = Random.Range(0, prefabs.Length);
                GameObject spawned = Instantiate(prefabs[randomIndex], _conteiner.transform);
                spawned.SetActive(false);
            
                _pool.Add(spawned);
            }
        }

        protected bool TryGetObject(out GameObject result)
        {
            result = _pool.FirstOrDefault(p => p.activeSelf == false);

            return result != null;
        }
    }
}
