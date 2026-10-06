using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class SpawnerStone : MonoBehaviour
    {
        [Header("Префабы камней")]
        [SerializeField] private GameObject[] prefabs;

        public GameObject Spawn()
        {
            var prefab = GetRandomPrefab();

            if (prefab == null)
            {
                return null;
            }

            return Instantiate(prefab, transform.position, Quaternion.identity);
        }

        private GameObject GetRandomPrefab()
        {
            if (prefabs == null || prefabs.Length == 0)
            {
                return null;
            }

            int index = UnityEngine.Random.Range(0, prefabs.Length);
            return prefabs[index];
        }
    }
}