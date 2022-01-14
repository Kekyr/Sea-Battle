using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject FailText; 
    public GameObject VictoryScreen;
    public Text NumberOfRocketsText;
    public Text NumberOfDestroyedShipsText;
    
    public void UpdateText(Text text, string title, int number)
    {
        text.text = title + number;
    }
    
    public void Show(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }

}
