using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Joystick _joystick;

    [SerializeField] private float _moveSpeed;

    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, _joystick.Vertical * _moveSpeed);
    }
   
}
