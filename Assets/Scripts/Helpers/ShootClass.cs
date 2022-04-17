using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootClass : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject bullet;
    public float bulletFrequency;
    public float hp;

    private float timeRemaining;

    void Start()
    {
        timeRemaining = bulletFrequency;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0 || transform.position.x < -10)
        {
            timeRemaining -= Time.deltaTime;
        } else {
            timeRemaining = bulletFrequency;
            Shoot();
        }
    }
    
    void Shoot()
    {
        Instantiate(bullet, gameObject.transform.position, Quaternion.identity);
    }

    private void GetDamage(){
        if (--hp <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "PlayerBullet"){
            GetDamage();
        }
    }
}
