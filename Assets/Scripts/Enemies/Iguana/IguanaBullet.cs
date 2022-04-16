using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IguanaBullet : MonoBehaviour
{
    GameObject _player;
    Vector3 _playerPosition;
    private float _speed = 20;
    private Vector3 normalizeDirection;
    void Start()
    {
        _player = GameObject.Find("Player");

        var _playerPosition = _player.transform.position;
        normalizeDirection = (_player.transform.position - transform.position).normalized;

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    
    private void Move(){
         transform.position += normalizeDirection * _speed * Time.deltaTime;
    }

}
