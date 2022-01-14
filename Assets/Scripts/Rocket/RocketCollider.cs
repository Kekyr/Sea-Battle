using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketCollider : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(Common.instance.WaitAndDestroy(gameObject));
    }
}
