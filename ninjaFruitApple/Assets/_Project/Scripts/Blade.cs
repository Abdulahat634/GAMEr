using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project
{
    public class Blade : MonoBehaviour
    {
        [SerializeField] private GameObject _bladePrafab;
        [SerializeField] private float _cutDistance = 100;

        private GameObject _blade;
        private Vector3 _mouseStartPosition;

        private void Start()
        {
            _blade = Instantiate(_bladePrafab);
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    _mouseStartPosition = Input.mousePosition;
                }

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                Debug.DrawRay(ray.origin, ray.direction * 10);

                if(Physics.Raycast(ray, out RaycastHit hit))
                {
                    ItemBase item = hit.collider.GetComponent < ItemBase>();

                    if(Vector3.Distance(_mouseStartPosition, Input.mousePosition)> _cutDistance)
                    {
                        item?.OnCatch();
                    }
                }

                _blade.transform.position = new Vector3(ray.origin.x, ray.origin.y, 0);
            }
        }
    }
}