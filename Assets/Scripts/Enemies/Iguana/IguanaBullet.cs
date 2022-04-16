using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IguanaBullet : MonoBehaviour
{
    Vector3 playerPosition;
    private float speed = 20;
    private Vector3 normalizeDirection;
    void Start()
    {
        playerPosition = FindObjectOfType<Player>().transform.position;
        normalizeDirection = (playerPosition - transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    
    private void Move(){
         transform.position += normalizeDirection * speed * Time.deltaTime;
    }

    private void OnBecameInvisible() {
        Destroy(gameObject);
    }
}
