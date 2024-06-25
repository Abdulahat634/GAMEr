using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Project
{
    public class Monkey : ItemBase
    {
        [SerializeField] private Transform _piecesHolder;
        private List<Transform> _piecesList;

        private void Awake()
        {
            SetupPieces();
        }

        public void SetupPieces()
        {
            _piecesList = _piecesHolder.GetComponentsInChildren<Transform>().ToList();
            _piecesList.Remove(_piecesHolder );

            foreach (Transform piece in _piecesList)
            {
                foreach (Rigidbody rigidbody in piece.GetComponents<Rigidbody>())
                {
                    DestroyImmediate(rigidbody);
                }

                foreach(Collider colider in piece.GetComponents<Collider>())
                {
                    DestroyImmediate(colider);
                }

            }
        }

        public override void OnCatch()
        {
            foreach (Transform piece in _piecesList)
            {
                piece.gameObject.AddComponent<Rigidbody>();
                piece.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                piece.gameObject.AddComponent<SphereCollider>();
            }

            Destroy(gameObject, 5);
        }
    }
}