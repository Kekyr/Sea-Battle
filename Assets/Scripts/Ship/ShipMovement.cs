using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    private Rigidbody _rigidbody;
    
    private Vector3 _direction;
    private Vector3 _right=new Vector3(2,0,0);
    private Vector3 _left=new Vector3(-1,0,0);

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        
        CheckDirection();
    }

    private void CheckDirection()
    {
        if (transform.position.x < 0)
        {
            _direction = _right;
        }
        else
        {
            _direction = _left;
        }
    }
    
    private void Update()
    {
        _rigidbody.AddForce(_direction);
    }
}
