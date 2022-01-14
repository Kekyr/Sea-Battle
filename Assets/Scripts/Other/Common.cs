using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Common : MonoBehaviour
{
    public static Common instance { get; private set; }

    private void Awake()
    {
        instance = this;
    }
    
    public  IEnumerator WaitAndDestroy(GameObject gameObject)
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
