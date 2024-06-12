using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    private int _playerOneScore;    
    private int _playerTwoScore;
    [SerializeField] private TextMeshProUGUI _playerOneScoreText;
    [SerializeField] private TextMeshProUGUI _playerTwoScoreText;

    private void Start()
    {
        _playerOneScore = 0;
        _playerTwoScore = 0;

        _playerOneScoreText.text = "0";
        _playerTwoScoreText.text = "0";
    }

    public void PlayerOneScored()
    {
        _playerOneScore++;

        _playerOneScoreText.text = _playerOneScore.ToString();
    }

    public void PlayerTwoScored()
    {
        _playerTwoScore++;

        _playerTwoScoreText.text = _playerTwoScore.ToString();

    }

    private void Update()
    {
        if( _playerOneScore == 3 || _playerTwoScore == 3 )
        {
            GameOver();
        }

        if (Input.GetKeyUp(KeyCode.Space)) { PlayerTwoScored(); }
    }

    private void GameOver()
    {
        Debug.Log("game over");
    }
}
