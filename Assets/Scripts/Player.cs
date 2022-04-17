using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _speed;
    private float _xInput;
    private float _yInput;
    [SerializeField] private GameObject _playerBullet;
    private float _time;
    private float _bulletTimer;

    void Start()
    {

    }

    void Update()
    {
        Move();
        Shoot();
    }

    private void Move(){
        _xInput = Input.GetAxisRaw("Horizontal");
        _yInput = Input.GetAxisRaw("Vertical");
        transform.Translate(new Vector3(_speed * _xInput * Time.deltaTime, _speed * _yInput * Time.deltaTime, 0), Space.World);
        if (Input.GetKey(KeyCode.J)){
            _speed = 10;
        }
        else{
            _speed = 20;
        }
    }

    private void Shoot(){
        _time += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.K)){
            Instantiate(_playerBullet, gameObject.transform.position, Quaternion.identity);
            //_bulletTimer = _time;
        }
        /*if (_time - _bulletTimer >= .5){
            Instantiate(_playerBullet, gameObject.transform.position, Quaternion.identity);
        }*/
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Enemy" || other.tag == "EnemyBullet"){
            //morir
        }
    }

}
