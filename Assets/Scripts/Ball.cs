using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private ScoreSystem _scoreSystem;

    private Rigidbody2D _rigidbody;
    [SerializeField] private Vector2 _startingSpeed;

    void Start()
    {
        _scoreSystem = FindObjectOfType<ScoreSystem>();

        

        _rigidbody = GetComponent<Rigidbody2D>();
        //_rigidbody.AddForce(_startingSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (transform.position.x > 0)
            _scoreSystem.PlayerOneScored();
        else
            _scoreSystem.PlayerTwoScored();

        transform.position = new Vector3(0, 0, 0);
    }

    private void Update()
    {

        _rigidbody.MovePosition(_startingSpeed);
    }
}
