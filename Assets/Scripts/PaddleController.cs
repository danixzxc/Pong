using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    [SerializeField] private float _speed;

    void Start()
    {
       _rigidbody = GetComponent<Rigidbody2D>(); 
    }
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        {
            _rigidbody.position += Vector2.up * Time.deltaTime * _speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            _rigidbody.position += Vector2.down * Time.deltaTime * _speed;
        }
    }
}
