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
    private float fireRate = .03f;

    void Update()
    {
        Movement();
        Shooting();
        time += Time.deltaTime;
    }

    private void Movement(){
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");
        transform.Translate(new Vector3(speed * xInput * Time.deltaTime, speed * yInput * Time.deltaTime, 0), Space.World);
        if (Input.GetKey(KeyCode.J)){
            speed = 12.5f;
        }
        else{
            speed = 25;
        }
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -19.5f, 19.5f), Mathf.Clamp(transform.position.y, -11, 11), transform.position.z);
    }

    private void Shooting(){
        if (Input.GetKey(KeyCode.K) && (time - bulletTimer) >= fireRate){
            Instantiate(playerBullet, gameObject.transform.position, Quaternion.identity);
            bulletTimer = time;
            Debug.Log("shoot at " + time);
        }
    }

    private void PlayerDeath(){
        Debug.Log("you died");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Enemy" || other.tag == "EnemyBullet"){
            PlayerDeath();
        }
    }

}
