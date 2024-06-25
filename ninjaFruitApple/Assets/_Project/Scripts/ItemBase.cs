using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project
{
    [RequireComponent(typeof(Rigidbody))]
    public abstract class ItemBase : MonoBehaviour
    {
        [SerializeField] Rigidbody _rigidbody;
        [SerializeField] private float _force = 500;

        private void Reset()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            if(transform.position.y < -20)
            {
                Destroy(gameObject);
            }
        }

        private void Start()
        {
            if (_rigidbody != null) 
            {
                _rigidbody.GetComponent<Rigidbody>();
            }
            _rigidbody.AddForce(Vector3.up * _force);
        }

        private void OnMouseDown()
        {
            OnCatch();
        }
        public virtual void OnCatch()
        {
            Destroy(gameObject);
        }
    }
}