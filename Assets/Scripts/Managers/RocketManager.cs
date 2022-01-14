using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketManager : MonoBehaviour
{ 
    [SerializeField] private GameObject _rocketPrefab;
    private GameObject _rocket;
    
    [SerializeField] private bool _increaseRocketSpeed;
    
    private int _rotationRightLimit = 2;
    private int _rotationLeftLimit = -1;
    private float _rotationModificator = 50;
    private float _rotationZ;
    private bool _isLaunching;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!GameManager.instance._gameOver)
            {
                if (!_isLaunching)
                {
                    LaunchRocket();
                }
            }
        }
    }
    
    private void LaunchRocket()
    {
        CalculateRotationZ();
        CreateRocket();
        GameManager.instance.DecrementNumberOfRockets();
    }
    
    public void CalculateRotationZ()
    {
        _rotationZ = (Input.mousePosition.x - 493) / 100f;

        if (_rotationZ > _rotationRightLimit)
        {
            _rotationZ -= _rotationModificator;
        }
        else if (_rotationZ < _rotationLeftLimit)
        {
            _rotationZ += _rotationModificator;
        }
        
    }
    
    private void CreateRocket()
    {
        _isLaunching = true;
        
        _rocket = Instantiate(_rocketPrefab);
        
        if (_increaseRocketSpeed)
        {
            _rocket.GetComponent<RocketMovement>().IncreaseSpeed();
        }
        
        _rocket.transform.Rotate(0, 0, _rotationZ);
        
        StartCoroutine(Launching());
    }
    
    private IEnumerator Launching()
    {
        yield return new WaitForSeconds(3f);
        _isLaunching = false;
    }
}
