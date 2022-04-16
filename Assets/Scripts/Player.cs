using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    private float _xInput;
    private float _yInput;

    void Start()
    {

    }

    void Update()
    {
        Move();
    }

    private void Move(){
        _xInput = Input.GetAxisRaw("Horizontal");
        _yInput = Input.GetAxisRaw("Vertical");
        transform.Translate(new Vector3(_speed * _xInput * Time.deltaTime, _speed * _yInput * Time.deltaTime, 0), Space.World);
        if (Input.GetKey(KeyCode.J)){
            _speed = 10;
        }
        else{
            _speed = 25;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Enemy" || other.tag == "EnemyBullet"){
            transform.position = new Vector3(5000,0,0);
        }
    }

}
