using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTowardsPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private Transform target;
    private float timeRemaining = 3;

    void Start()
    {
       target = FindObjectOfType<Player>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 playerRelativeToEnemie = transform.InverseTransformPoint(target.position);
        if(timeRemaining > 0 && target.position.x < transform.position.x && playerRelativeToEnemie.y != 0) {
            transform.Translate(new Vector3(-speed * Time.deltaTime, ((playerRelativeToEnemie.y / System.Math.Abs(playerRelativeToEnemie.y) * speed) * Time.deltaTime) / 2, 0), Space.World);
            timeRemaining -= Time.deltaTime;
        } else {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0), Space.World);
        }
    }
}
