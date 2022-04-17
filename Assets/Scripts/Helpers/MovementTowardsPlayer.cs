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
       if(timeRemaining > 0 && target.position.x < transform.position.x) {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            timeRemaining -= Time.deltaTime;
        } else {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0), Space.World);
        }
    }
}
