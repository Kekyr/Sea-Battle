using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipCollider : MonoBehaviour
{
    [SerializeField] private GameObject _particleSystem;
    private bool _isColliding;

    private void OnCollisionEnter(Collision collision)
    {
        if (!_isColliding)
        {
            _isColliding = true;
            _particleSystem.SetActive(true);
            GameManager.instance.IncrementNumberOfDestroyedShips();
            StartCoroutine(Common.instance.WaitAndDestroy(gameObject));
        }
    }
    
    

    
}
