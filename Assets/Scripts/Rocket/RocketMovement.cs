using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    private Rigidbody _rigidbody;

    [SerializeField] private float _rocketSpeed;
    private float _rotationZ;
    private float _rightLimit=-0.06f;
    private float _leftLimit = 0.04f;
    private Vector3 _direction;
    private Vector3 _forward;
    private Vector3 _forwardRight;
    private Vector3 _forwardLeft;

    private void Start()
    {
        InitializeRocket();
        CheckRotationZ();
    }
    
    private void InitializeRocket()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rotationZ = transform.rotation.z;
        _forward = new Vector3(0, 0, _rocketSpeed);
        _forwardRight = new Vector3(_rocketSpeed, 0, _rocketSpeed);
        _forwardLeft = new Vector3(-_rocketSpeed, 0, _rocketSpeed);
    }
    
    private void CheckRotationZ()
    {
        if (_rotationZ > _rightLimit && _rotationZ < _leftLimit)
        {
            _direction = _forward;
        }
        else if(_rotationZ>_rightLimit)
        {
            
            _direction = _forwardLeft;
        }
        else
        {
            _direction = _forwardRight;
        }
    }
    
    private void Update()
    {
        _rigidbody.AddForce(_direction);
    }

    public void IncreaseSpeed()
    {
        _rocketSpeed *= 2;
    }

    

    
}
