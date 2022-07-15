using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPlayer : MonoBehaviour
{
    private float speed = 250;
    
    void Update()
    {
        Move();
    }

    private void Move(){
        transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0), Space.World);
        if(transform.position.x >= 35){
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Enemy"){
            Destroy(gameObject);
        }
    }
}
