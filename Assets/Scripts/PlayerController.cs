using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Animator _animator;   
    [SerializeField] private float _velocity;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        if(Input.GetKey(KeyCode.W)) {

            newPosition.y = transform.position.y + 1 * _velocity * Time.deltaTime ;
            transform.position = newPosition;
            _animator.SetBool("walkForward", true);

        } else if ( Input.GetKey(KeyCode.S) ){     

            newPosition.y = transform.position.y - 1 * _velocity * Time.deltaTime ;
            transform.position = newPosition;
            _animator.SetBool("walkBackward", true);

        } else if ( Input.GetKey(KeyCode.A) ){     

            newPosition.x = transform.position.x - 1 * _velocity * Time.deltaTime ;
            transform.position = newPosition;
            _animator.SetBool("walkLeft", true);

        } else if ( Input.GetKey(KeyCode.D) ){     

            newPosition.x = transform.position.x + 1 * _velocity * Time.deltaTime ;
            transform.position = newPosition;
            _animator.SetBool("walkRight", true);
            
        } else {
            
            _animator.SetBool("walkForward", false);
            _animator.SetBool("walkBackward", false);            
            _animator.SetBool("walkRight", false);
            _animator.SetBool("walkLeft", false);
            
            _animator.SetBool("standing", true);

        }
    }
}
