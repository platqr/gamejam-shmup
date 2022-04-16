using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFacedBullet : MonoBehaviour
{
    GameObject _player;
    float _playerDirectionX;
    private float _speed = 20;

    void Start()
    {
        _player = GameObject.Find("Player");

        var _playerPosition = _player.transform.TransformPoint(transform.position);
        _playerDirectionX = _playerPosition.x / System.Math.Abs(_playerPosition.x);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    
    private void Move(){
        transform.Translate(new Vector3(_speed * Time.deltaTime * _playerDirectionX, 0, 0), Space.Self);
    }

}
