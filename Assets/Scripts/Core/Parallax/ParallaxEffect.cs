using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.Parallax
{

    public class ParallaxEffect : MonoBehaviour
    {
        [SerializeField] private List<ParallaxLayer> _parallaxLayers;
        [SerializeField] private Transform _target;

        private float _previousTargetPosition;

        private void Start()
        {
            _previousTargetPosition = _target.position.x;
        }

        private void LateUpdate()
        {
            float deltaMovement = _previousTargetPosition - _target.position.x;
            foreach (var layer in _parallaxLayers)
            {
                Vector2 layerPosition = layer._transform.position;
                layerPosition.x += deltaMovement * layer._speed;
                layer._transform.position = layerPosition;
            }

            _previousTargetPosition = _target.position.x;
        }

        [Serializable]
        private class ParallaxLayer
        {
            [field: SerializeField] public Transform _transform { get; private set; }
            [field: SerializeField] public float _speed { get; private set; }
            
        }
    }    
}
