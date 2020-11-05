using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D _rigidBody2D;
    private Animator _animator;   
    [SerializeField] private float _velocity;

    private void Start() {
        _rigidBody2D  = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }
    private void FixedUpdate() {
        float _moveHorizontal = Input.GetAxis("Horizontal");
        float _moveVertical = Input.GetAxis("Vertical");
        Vector3 _movement = new Vector3(_moveHorizontal, _moveVertical, 0);
        _movement *= Time.deltaTime;
        _movement *= _velocity;

        transform.Translate(_movement);
    }
}
