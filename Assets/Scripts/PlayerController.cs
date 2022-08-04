using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] Rigidbody2D _playerRigidbody;

    [SerializeField] SurfaceEffector2D _surfaceEffector;

    [SerializeField] float _torqueAmount;
    [SerializeField] float _speedBoost;
    [SerializeField] float _averageSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AddRotation();
        HandleSpeed();
    }

    void HandleSpeed()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _surfaceEffector.speed = _speedBoost;
            Debug.Log("Up");
        }
        else
        {
            _surfaceEffector.speed = _averageSpeed;
        }
    }

    void AddRotation()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            _playerRigidbody.AddTorque(-_torqueAmount);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            _playerRigidbody.AddTorque(_torqueAmount);
        }
    }
}
