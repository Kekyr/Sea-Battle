using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Common : MonoBehaviour
{
    
    public  IEnumerator WaitAndDestroy(GameObject gameObject)
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
