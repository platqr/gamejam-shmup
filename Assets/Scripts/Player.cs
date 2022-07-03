using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed;
    private float xInput;
    private float yInput;
    [SerializeField] private GameObject playerBullet;
    private float time = 0f;
    private float bulletTimer = 0f;
    [SerializeField] private float fireRate = .03f;

    void Start()
    {
        Debug.Log("game start");
    }

    void Update()
    {
        Move();
        Shoot();
        time += Time.deltaTime;
    }

    private void Move(){
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");
        transform.Translate(new Vector3(speed * xInput * Time.deltaTime, speed * yInput * Time.deltaTime, 0), Space.World);
        if (Input.GetKey(KeyCode.J)){
            speed = 10;
        }
        else{
            speed = 20;
        }
    }

    private void Shoot(){
        if (Input.GetKey(KeyCode.K) && (time - bulletTimer) >= fireRate){
            Instantiate(playerBullet, gameObject.transform.position, Quaternion.identity);
            bulletTimer = time;
            Debug.Log("shoot at " + time);
        }
    }

    private void PlayerDeath(){
        Debug.Log("I died");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Enemy" || other.tag == "EnemyBullet"){
            PlayerDeath();
        }
    }

}
