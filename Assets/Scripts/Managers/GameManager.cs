using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }
    
    [SerializeField] private int _numberOfRockets;
    [SerializeField] private int _needToDestroyShips;
    
    private UIManager _uiManager;
    private RocketManager _rocketManager;
    
    public bool _gameOver;
    private int _numberOfDestroyedShips;
    
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        _uiManager = GetComponent<UIManager>();
        _rocketManager = GetComponent<RocketManager>();
        _uiManager.UpdateText(_uiManager.NumberOfRocketsText, "Количество торпед: ", GameManager.instance._numberOfRockets);
    }
    
    public void DecrementNumberOfRockets()
    {
        _numberOfRockets--;

        if (_numberOfRockets > 0)
        {
            _uiManager.UpdateText(_uiManager.NumberOfRocketsText, "Количество торпед: ", _numberOfRockets);
        }
        else
        {
            _uiManager.Show(_uiManager.FailText);
            _gameOver = true;
            SaveNumberOfDestroyedShips();
        }
    }

    public void IncrementNumberOfDestroyedShips()
    {
        _numberOfDestroyedShips++;

        if (_numberOfDestroyedShips != _needToDestroyShips)
        {
            _uiManager.UpdateText(_uiManager.NumberOfDestroyedShipsText, "Количество кораблей: ", _numberOfDestroyedShips);
        }
        else
        {
            _uiManager.UpdateText(_uiManager.NumberOfDestroyedShipsText, "Количество кораблей: ", _numberOfDestroyedShips);
            _uiManager.Show(_uiManager.VictoryScreen);
            _gameOver = true;
            SaveNumberOfDestroyedShips();
        }
        
        
    }
    
    private void SaveNumberOfDestroyedShips()
    {
        int numberOfShips = _numberOfDestroyedShips + PlayerPrefs.GetInt("numberOfDestroyedShips");
        PlayerPrefs.SetInt("numberOfDestroyedShips", numberOfShips);
    }




}