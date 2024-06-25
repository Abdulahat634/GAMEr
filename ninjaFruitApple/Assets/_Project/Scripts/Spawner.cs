using So;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private ItemsList _itemsList;
        [SerializeField] private float _spawnRate = 2;

        private void Start()
        {
            StartCoroutine(Spawn());
        }

        private IEnumerator Spawn()
        {
            while (gameObject.activeSelf)
            {
                yield return new WaitForSeconds(_spawnRate);

                int index = Random.Range(0, _itemsList.items.Length);

                ItemBase itemCopy = Instantiate(_itemsList.items[index]);

                Vector3 newPosition = new Vector3();
                newPosition.x = Random.Range(-10, 10);
                newPosition.y = 0;
                newPosition.z = 0;

                itemCopy.transform.position = newPosition;
            }
        }
    }
}