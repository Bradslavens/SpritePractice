using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D _rigidBody2D;
    private Animator _animator;   
    [SerializeField] private float _velocity;
    [SerializeField] private float _force;

    private void Start() {
        _rigidBody2D  = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }
    private void FixedUpdate() {
        float _moveHorizontal = Input.GetAxisRaw("Horizontal");
        float _moveVertical = Input.GetAxisRaw("Vertical");

        _animator.SetFloat("horizontal", _moveHorizontal);
        _animator.SetFloat("vertical", _moveVertical);

        Vector3 _movement = new Vector3(_moveHorizontal, _moveVertical, 0);
        _movement *= Time.deltaTime;
        _movement *= _velocity;

        transform.Translate(_movement);

        if(Input.GetKeyDown(KeyCode.Space)){
            // Jump
            _rigidBody2D.AddForce(new Vector2(0, _force), ForceMode2D.Impulse);
        }
    }
}
