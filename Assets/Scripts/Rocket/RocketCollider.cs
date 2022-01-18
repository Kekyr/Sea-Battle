using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketCollider : MonoBehaviour
{
    private Common _common;

    private void Start()
    {
        _common = GetComponent<Common>();
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(_common.WaitAndDestroy(gameObject));
    }
}
