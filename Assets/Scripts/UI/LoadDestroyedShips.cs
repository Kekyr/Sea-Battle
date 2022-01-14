using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadDestroyedShips : MonoBehaviour
{
    private Text _numberOfDestroyedShipsText;
    
    private void Start()
    {
        _numberOfDestroyedShipsText = GetComponent<Text>();
        _numberOfDestroyedShipsText.text += PlayerPrefs.GetInt("numberOfDestroyedShips");
    }
}
